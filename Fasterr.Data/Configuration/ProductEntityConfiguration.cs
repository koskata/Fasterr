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
                    BrandId = 1,
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
                    BrandId = 1,
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
                    BrandId = 1,
                    CategoryId = 1
                },

                //Kits-----------------------------------\/
                new Product
                {
                    Id = Guid.Parse("9337cd2c-b65e-4851-82be-dfacdf135c8b"),
                    Name = "DRI-FIT футболен екип PSG MBAPPE",
                    Description = "Оригинални тениска и шорти за всекидневни тренировки на футболен клуб PSG",
                    ImageURL = "https://frankfurt.apollo.olxcdn.com/v1/files/cpryl7ozvivj1-BG/image;s=1800x1846",
                    Price = 199.99m,
                    Discount = 0,
                    Rating = 0,
                    BrandId = 1,
                    CategoryId = 2
                },
                new Product
                {
                    Id = Guid.Parse("3d599ead-4054-4400-a434-6d2c2e40050a"),
                    Name = "Puma Manchester City футболен екип 2023/2024 домакински",
                    Description = "Оригинални тениска и шорти за всекидневни тренировки на футболен клуб Manchester City",
                    ImageURL = "https://sportwearbg.com/image/Produkti/Futbol/Ekipi/English/Manchester%20City/23-24/home/detski-ekip-manchester-city.jpg",
                    Price = 179.99m,
                    Discount = 0,
                    Rating = 0,
                    BrandId = 4,
                    CategoryId = 2
                },
                new Product
                {
                    Id = Guid.Parse("f1162601-e372-4c94-914f-a8cbf150c2ee"),
                    Name = "Nike Liverpool футболен екип 2023/2024 домакински",
                    Description = "Оригинални тениска и шорти за всекидневни тренировки на футболен клуб Liverpool",
                    ImageURL = "https://sportwearbg.com/image/Produkti/Futbol/Ekipi/English/Liverpool/23%2024/Home/detski_ekip_liverpool-2023-2024.jpg",
                    Price = 189.99m,
                    Discount = 0,
                    Rating = 0,
                    BrandId = 1,
                    CategoryId = 2
                },
                //Tracksuits---------------------------------\/
                new Product
                {
                    Id = Guid.Parse("91de93c1-7470-465a-9d6f-c4e0ca348b0f"),
                    Name = "Анцуг за тренировка Argentina 2023/2024",
                    Description = "Долнище и горнище за тренировки 2023/2024 Аржентина",
                    ImageURL = "https://img4.dhresource.com/webp/m/0x0/f3/albu/km/g/30/b88fd8a7-70e7-43cb-ab4d-5fd139e12cff.jpg",
                    Price = 165.99m,
                    Discount = 0,
                    Rating = 0,
                    BrandId = 2,
                    CategoryId = 3
                },
                new Product
                {
                    Id = Guid.Parse("f33d52bd-a2fa-4d77-a2cf-bd126f003b5e"),
                    Name = "Анцуг за тренировка PSG 2023/2024",
                    Description = "Долнище и горнище за тренировки 2023/2024 PSG",
                    ImageURL = "https://m.media-amazon.com/images/I/619oiA9HqZL._AC_UY1100_.jpg",
                    Price = 185.99m,
                    Discount = 0,
                    Rating = 0,
                    BrandId = 1,
                    CategoryId = 3
                },
                //Thermal underwear
                new Product
                {
                    Id = Guid.Parse("f83fff9a-01f9-46a9-9190-3c2bcebb1247"),
                    Name = "Термо блуза Under Armour",
                    Description = "Удобна и качествена тениска Under Armour",
                    ImageURL = "https://cdn.4camping.bg/files/photos/1600/a/ad473c5b-mazhka-teniska-under-armour-hg-armour-comp-ls-cheren-black-white.jpg",
                    Price = 35.99m,
                    Discount = 0,
                    Rating = 0,
                    BrandId = 3,
                    CategoryId = 4
                },
                new Product
                {
                    Id = Guid.Parse("efb16cae-f4f7-43b0-bdc5-5527c7960d11"),
                    Name = "Долен къс клин KEEPCOMFORT KIPSTA",
                    Description = "Удобен термо клин на KIPSTA",
                    ImageURL = "https://contents.mediadecathlon.com/p2480341/k$bba35f387da6b9cd9450cbcc0d46db4d/dolen-kas-klin-keepcomfort-cheren.jpg?format=auto&quality=40&f=800x800",
                    Price = 25.99m,
                    Discount = 0,
                    Rating = 0,
                    BrandId = 6,
                    CategoryId = 4
                },
            };

            return products.ToArray();
        }
    }
}
