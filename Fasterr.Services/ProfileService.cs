﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Fasterr.Data;
using Fasterr.Data.Models;
using Fasterr.Services.Interfaces;
using Fasterr.Web.ViewModels.Product;
using Fasterr.Web.ViewModels.User;

using Microsoft.EntityFrameworkCore;

namespace Fasterr.Services
{
    public class ProfileService : IProfileService
    {
        private readonly FasterrDbContext context;

        public ProfileService(FasterrDbContext _context)
        {
            context = _context;
        }

        public async Task<IEnumerable<ProductAllViewModel>> GetAllLikedProductsByUserAsync(string userId)
        {
            var likedProducts = await context.ProductsBuyersLike
                .Where(x => x.BuyerId.ToString() == userId)
                .Select(x => new ProductAllViewModel()
                {
                    Id = x.Product.Id.ToString(),
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
                }).ToListAsync();

            return likedProducts;
        }

        public async Task<IEnumerable<ProductAllViewModel>> GetAllPurchasedProductsByUserAsync(string userId)
        {
            var purchasedProducts = await context.ProductsBuyersPurchased
                .Where(x => x.BuyerId.ToString() == userId)
                .Select(x => new ProductAllViewModel()
                {
                    Id = x.Product.Id.ToString(),
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
                }).ToListAsync();

            return purchasedProducts;
        }

        public async Task<ApplicationUserViewModel> GetUserByIdAsync(string userId)
        {
            var user = await context.Users
                .Where(x => x.Id.ToString() == userId)
                .Select(x => new ApplicationUserViewModel()
                {
                    Id = x.Id.ToString(),
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    ImageURL = x.ImageURL
                }).FirstOrDefaultAsync();

            return user;
        }
    }
}
