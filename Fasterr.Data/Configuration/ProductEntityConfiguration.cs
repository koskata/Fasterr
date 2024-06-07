using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Fasterr.Data.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Fasterr.Data.Configuration
{
    public class ProductEntityConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(GenerateProducts());
        }

        private Product[] GenerateProducts()
        {
            List<Product> products = new List<Product>()
            {
                //Shoes----------------------------\/
                new Product 
                {
                    Id = Guid.Parse("35c9c992-f210-4939-8a1a-b1d0ddc46daf"),
                    Name = "Футболни обувки Nike Zoom Mercurial Superfly 9 Elite FG Hyper Turq",
                    Description = "Стилни футболни обувки за ежедневни тренировки и мачове",
                    ImageURL = "https://www.futbolemotion.com/imagesarticulos/199088/grandes/bota-nike-zoom-mercurial-superfly-9-elite-fg-turquesa-0.webp",
                    Price = 299.99m,
                    Discount = 0,
                    Rating = 0,
                    Brand = "Nike",
                    CategoryId = 1
                },
                new Product
                {
                    Id = Guid.Parse("920c24b3-0d0e-473a-b79b-0c7961654ca0"),
                    Name = "Футболни обувки Nike Zoom Mercurial Superfly 9 Academy FG",
                    Description = "Стилни футболни обувки за ежедневни тренировки и мачове",
                    ImageURL = "https://thirdcoastsoccer.net/cdn/shop/products/image__80827.1657841497.1280.1280.png?v=1681567637",
                    Price = 309.99m,
                    Discount = 0,
                    Rating = 0,
                    Brand = "Nike",
                    CategoryId = 1
                },
                new Product
                {
                    Id = Guid.Parse("3a84fcad-faa8-4ba7-bd2b-85dc1db18478"),
                    Name = "Професионални бутонки Nike Mercurial Dream Speed Superfly 8 Elite FG",
                    Description = "Професионални футболни обувки",
                    ImageURL = "https://frankfurt.apollo.olxcdn.com/v1/files/f4eqgsde7r0w1-BG/image",
                    Price = 409.99m,
                    Discount = 0,
                    Rating = 0,
                    Brand = "Nike",
                    CategoryId = 1
                },
                //
            };

            return products.ToArray();
        }
    }
}
