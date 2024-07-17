using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Fasterr.Data;
using Fasterr.Data.Models;
using Fasterr.Services.Interfaces;
using Fasterr.Web.ViewModels.Enums;
using Fasterr.Web.ViewModels.Product;

using Microsoft.EntityFrameworkCore;

namespace Fasterr.Services
{
    public class ProductService : IProductService
    {
        private readonly FasterrDbContext context;

        public ProductService(FasterrDbContext _context)
        {
            context = _context;
        }

        public async Task AddToCartAsync(ProductDetailsViewModel model, string productId, string userId)
        {
            var product = await context.Products.FirstOrDefaultAsync(x => x.Id.ToString() == productId);

            var productBuyerCart = new ProductBuyerCart()
            {
                BuyerId = Guid.Parse(userId),
                ProductId = Guid.Parse(productId)
            };

            await context.ProductsBuyersCart.AddAsync(productBuyerCart);
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<string>> AllCategoriesNamesAsync()
            => await context.Categories.Select(c => c.Name).ToListAsync();

        public async Task<ProductQueryServiceModel> GetAllProductsAsync(string category = null,
                                                                               string searchTerm = null,
                                                                               ProductSorting sorting = ProductSorting.HighestRating)
        {
            var productsQuery = context.Products.AsQueryable();

            if (!string.IsNullOrWhiteSpace(category))
            {
                productsQuery = context.Products.Where(x => x.Category.Name == category);
            }

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                productsQuery = productsQuery.Where(x =>
                                                        x.Name.ToLower().Contains(searchTerm.ToLower()) ||
                                                        x.Description.ToLower().Contains(searchTerm.ToLower()) ||
                                                        x.Brand.Name.ToLower().Contains(searchTerm.ToLower()));
            }

            productsQuery = sorting switch
            {
                ProductSorting.HighestPrice => productsQuery.OrderByDescending(x => x.TotalPrice),
                ProductSorting.LowestPrice => productsQuery.OrderBy(x => x.TotalPrice),
                ProductSorting.LowestRating => productsQuery.OrderBy(x => x.Rating),
                _ => productsQuery.OrderByDescending(x => x.Rating)
            };


            var products = await productsQuery
                .Select(x => new ProductAllViewModel()
                {
                    Id = x.Id.ToString(),
                    Name = x.Name,
                    Description = x.Description,
                    ImageURL = x.ImageURL,
                    Price = x.Price,
                    Discount = x.Discount,
                    Rating = x.Rating,
                    Brand = x.Brand.Name,
                    Category = x.Category.Name,
                    Type = x.Type.Name,
                    RatingCount = x.ProductsBuyersRate.Count()
                }).ToListAsync();

            var totalProducts = productsQuery.Count();

            return new ProductQueryServiceModel()
            {
                TotalProductsCount = totalProducts,
                Products = products
            };
        }

        public async Task<List<ProductAllViewModel>> GetAllProductsInCartAsync(string userId)
        {
            var products = await context.ProductsBuyersCart
                .Where(x => x.BuyerId.ToString() == userId)
                .Select(x => new ProductAllViewModel()
                {
                    Id = x.ProductId.ToString(),
                    Name = x.Product.Name,
                    Description = x.Product.Description,
                    ImageURL = x.Product.ImageURL,
                    Price = x.Product.Price,
                    Discount = x.Product.Discount,
                    Rating = x.Product.Rating,
                    Brand = x.Product.Brand.Name,
                    Category = x.Product.Category.Name,
                    Type = x.Product.Type.Name,
                    RatingCount = x.Product.ProductsBuyersRate.Count()
                })
                .ToListAsync();

            return products;

        }

        public async Task<ProductDetailsViewModel> GetProductByIdAsync(string id)
        {
            var model = await context.Products
                .Where(x => x.Id.ToString() == id)
                .Select(x => new ProductDetailsViewModel()
                {
                    Id = x.Id.ToString(),
                    Name = x.Name,
                    Description = x.Description,
                    ImageURL = x.ImageURL,
                    Price = x.Price,
                    Discount = x.Discount,
                    Rating = x.Rating,
                    Brand = x.Brand.Name,
                    Category = x.Category.Name,
                    RatingCount = x.ProductsBuyersRate.Count()
                }).FirstOrDefaultAsync();

            return model;
        }

        public async Task<bool> LikeAsync(ProductDetailsViewModel model, string productId, string userId)
        {
            var product = await context.Products.FirstOrDefaultAsync(x => x.Id.ToString() == productId);

            bool isAny = false;

            var productBuyerLike = new ProductBuyerLike()
            {
                BuyerId = Guid.Parse(userId),
                ProductId = Guid.Parse(productId)
            };

            if (!await context.ProductsBuyersLike.AnyAsync(x => x.BuyerId.ToString() == userId && x.ProductId.ToString() == productId))
            {
                await context.ProductsBuyersLike.AddAsync(productBuyerLike);
            }
            else
            {
                context.ProductsBuyersLike.Remove(productBuyerLike);

                isAny = true;
            }

            await context.SaveChangesAsync();

            return isAny;
        }

        public async Task<bool> ProductExistsByIdAsync(string id)
            => await context.Products.AnyAsync(x => x.Id.ToString() == id);

        public async Task<bool> RateAsync(ProductDetailsViewModel model, string productId, int rating, string userId)
        {
            var product = await context.Products.FirstOrDefaultAsync(x => x.Id.ToString() == productId);

            bool isAny = false;

            if (await context.ProductsBuyersRate.AnyAsync(x => x.BuyerId.ToString() == userId && x.ProductId.ToString() == productId))
            {
                isAny = true;
            }

            if (product != null && isAny == false)
            {
                product.Rating += rating;

                var productBuyerRate = new ProductBuyerRate()
                {
                    BuyerId = Guid.Parse(userId),
                    ProductId = Guid.Parse(productId)
                };

                await context.ProductsBuyersRate.AddAsync(productBuyerRate);

                await context.SaveChangesAsync();
            }

            return isAny;
        }

        public async Task RemoveProductFromCartAsync(string userId, string productId)
        {
            var model = new ProductBuyerCart()
            {
                BuyerId = Guid.Parse(userId),
                ProductId = Guid.Parse(productId)
            };

            context.ProductsBuyersCart.Remove(model);
            await context.SaveChangesAsync();
        }
    }
}
