using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Fasterr.Data.Configuration;
using Fasterr.Data.Models;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Fasterr.Data
{
    public class FasterrDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public FasterrDbContext(DbContextOptions<FasterrDbContext> options)
            : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductBuyerCart> ProductsBuyersCart { get; set; }
        public DbSet<ProductBuyerPurchased> ProductsBuyersPurchased { get; set; }
        public DbSet<Brand> Brands { get; set; }

        public DbSet<Models.Type> Types { get; set; }
        public DbSet<ProductBuyerRate> ProductsBuyersRate { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ProductBuyerCart>().HasKey(x => new { x.BuyerId, x.ProductId });
            builder.Entity<ProductBuyerPurchased>().HasKey(x => new { x.BuyerId, x.ProductId });
            builder.Entity<ProductBuyerRate>().HasKey(x => new { x.BuyerId, x.ProductId });

            builder.ApplyConfiguration(new CategoryEntityConfiguration());
            builder.ApplyConfiguration(new BrandEntityConfiguration());
            builder.ApplyConfiguration(new ProductEntityConfiguration());
            builder.ApplyConfiguration(new TypeEntityConfiguration());

            base.OnModelCreating(builder);
        }
    }
}
