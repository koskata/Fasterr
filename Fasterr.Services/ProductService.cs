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
                    Brand = x.Brand,
                    Category = x.Category.Name
                }).ToListAsync();

            return products;
        }
    }
}
