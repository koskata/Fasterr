using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Fasterr.Data;
using Fasterr.Data.Models;
using Fasterr.Services.Interfaces;
using Fasterr.Web.ViewModels.Product;

using Microsoft.EntityFrameworkCore;

namespace Fasterr.Services
{
    public class CartService : ICartService
    {
        private readonly FasterrDbContext context;

        public CartService(FasterrDbContext _context)
        {
            context = _context;
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
