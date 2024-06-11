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
                ProductSorting.HighestPrice => productsQuery.OrderByDescending(x => x.Price),
                ProductSorting.LowestPrice => productsQuery.OrderBy(x => x.Price),
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

        public async Task<bool> ProductExistsByIdAsync(string id)
            => await context.Products.AnyAsync(x => x.Id.ToString() == id);

        public async Task Rate(ProductDetailsViewModel model, string productId, int rating, string userId)
        {
            var product = await context.Products.FirstOrDefaultAsync(x => x.Id.ToString() == productId);

            if (product != null)
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
        }
    }
}
