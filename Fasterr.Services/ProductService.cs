using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Fasterr.Data;
using Fasterr.Services.Interfaces;
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

        public async Task<List<ProductAllViewModel>> GetAllManProductsAsync()
        {
            var products = await context.Products
                .Where(x => x.TypeId == 1)
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
                    Type = x.Type.Name
                }).ToListAsync();

            return products;
        }

        public async Task<List<ProductAllViewModel>> GetAllProductsAsync()
        {
            var products = await context.Products
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
                    Type = x.Type.Name
                }).ToListAsync();

            return products;
        }

        public async Task<List<ProductAllViewModel>> GetAllWomanProductsAsync()
        {
            var products = await context.Products
                .Where(x => x.TypeId == 2)
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
                    Type = x.Type.Name
                }).ToListAsync();

            return products;
        }

        public async Task<ProductDetailsViewModel> GetProductByIdAsync(string id)
        {
            var model = await context.Products
                .Where(x => x.Id.ToString() == id)
                .Select(x => new ProductDetailsViewModel()
                {
                    Name = x.Name,
                    Description = x.Description,
                    ImageURL = x.ImageURL,
                    Price = x.Price,
                    Discount = x.Discount,
                    Rating = x.Rating,
                    Brand = x.Brand.Name,
                    Category = x.Category.Name
                }).FirstOrDefaultAsync();

            return model;
        }

        public async Task<bool> ProductExistsByIdAsync(string id)
            => await context.Products.AnyAsync(x => x.Id.ToString() == id);
    }
}
