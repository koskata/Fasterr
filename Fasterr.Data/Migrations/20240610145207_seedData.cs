using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fasterr.Data.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Nike" },
                    { 2, "Adidas" },
                    { 3, "Under Armour" },
                    { 4, "Puma" },
                    { 5, "Reebok" },
                    { 6, "Kipsta" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Shoes" },
                    { 2, "Kits" },
                    { 3, "Tracksuits" },
                    { 4, "Thermal underwear" }
                });

            migrationBuilder.InsertData(
                table: "Type",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Man" },
                    { 2, "Women" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CategoryId", "Description", "Discount", "ImageURL", "Name", "Price", "Rating", "TypeId" },
                values: new object[,]
                {
                    { new Guid("35c9c992-f210-4939-8a1a-b1d0ddc46daf"), 1, 1, "Стилни футболни обувки за ежедневни тренировки и мачове", 0, "https://www.futbolemotion.com/imagesarticulos/199088/grandes/bota-nike-zoom-mercurial-superfly-9-elite-fg-turquesa-0.webp", "Футболни обувки Nike Zoom Mercurial Superfly 9 Elite FG Hyper Turq", 299.99m, 0, 1 },
                    { new Guid("3a84fcad-faa8-4ba7-bd2b-85dc1db18478"), 1, 1, "Професионални футболни обувки", 0, "https://frankfurt.apollo.olxcdn.com/v1/files/f4eqgsde7r0w1-BG/image", "Професионални бутонки Nike Mercurial Dream Speed Superfly 8 Elite FG", 409.99m, 0, 1 },
                    { new Guid("3d599ead-4054-4400-a434-6d2c2e40050a"), 4, 2, "Оригинални тениска и шорти за всекидневни тренировки на футболен клуб Manchester City", 0, "https://sportwearbg.com/image/Produkti/Futbol/Ekipi/English/Manchester%20City/23-24/home/detski-ekip-manchester-city.jpg", "Puma Manchester City футболен екип 2023/2024 домакински", 179.99m, 0, 1 },
                    { new Guid("91de93c1-7470-465a-9d6f-c4e0ca348b0f"), 2, 3, "Долнище и горнище за тренировки 2023/2024 Аржентина", 0, "https://img4.dhresource.com/webp/m/0x0/f3/albu/km/g/30/b88fd8a7-70e7-43cb-ab4d-5fd139e12cff.jpg", "Анцуг за тренировка Argentina 2023/2024", 165.99m, 0, 1 },
                    { new Guid("920c24b3-0d0e-473a-b79b-0c7961654ca0"), 1, 1, "Стилни футболни обувки за ежедневни тренировки и мачове", 0, "https://thirdcoastsoccer.net/cdn/shop/products/image__80827.1657841497.1280.1280.png?v=1681567637", "Футболни обувки Nike Zoom Mercurial Superfly 9 Academy FG", 309.99m, 0, 1 },
                    { new Guid("9337cd2c-b65e-4851-82be-dfacdf135c8b"), 1, 2, "Оригинални тениска и шорти за всекидневни тренировки на футболен клуб PSG", 0, "https://frankfurt.apollo.olxcdn.com/v1/files/cpryl7ozvivj1-BG/image;s=1800x1846", "DRI-FIT футболен екип PSG MBAPPE", 199.99m, 0, 1 },
                    { new Guid("efb16cae-f4f7-43b0-bdc5-5527c7960d11"), 6, 4, "Удобен термо клин на KIPSTA", 0, "https://contents.mediadecathlon.com/p2480341/k$bba35f387da6b9cd9450cbcc0d46db4d/dolen-kas-klin-keepcomfort-cheren.jpg?format=auto&quality=40&f=800x800", "Долен къс клин KEEPCOMFORT KIPSTA", 25.99m, 0, 1 },
                    { new Guid("f1162601-e372-4c94-914f-a8cbf150c2ee"), 1, 2, "Оригинални тениска и шорти за всекидневни тренировки на футболен клуб Liverpool", 0, "https://sportwearbg.com/image/Produkti/Futbol/Ekipi/English/Liverpool/23%2024/Home/detski_ekip_liverpool-2023-2024.jpg", "Nike Liverpool футболен екип 2023/2024 домакински", 189.99m, 0, 1 },
                    { new Guid("f33d52bd-a2fa-4d77-a2cf-bd126f003b5e"), 1, 3, "Долнище и горнище за тренировки 2023/2024 PSG", 0, "https://m.media-amazon.com/images/I/619oiA9HqZL._AC_UY1100_.jpg", "Анцуг за тренировка PSG 2023/2024", 185.99m, 0, 1 },
                    { new Guid("f83fff9a-01f9-46a9-9190-3c2bcebb1247"), 3, 4, "Удобна и качествена тениска Under Armour", 0, "https://cdn.4camping.bg/files/photos/1600/a/ad473c5b-mazhka-teniska-under-armour-hg-armour-comp-ls-cheren-black-white.jpg", "Термо блуза Under Armour", 35.99m, 0, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("35c9c992-f210-4939-8a1a-b1d0ddc46daf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3a84fcad-faa8-4ba7-bd2b-85dc1db18478"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3d599ead-4054-4400-a434-6d2c2e40050a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("91de93c1-7470-465a-9d6f-c4e0ca348b0f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("920c24b3-0d0e-473a-b79b-0c7961654ca0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9337cd2c-b65e-4851-82be-dfacdf135c8b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("efb16cae-f4f7-43b0-bdc5-5527c7960d11"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f1162601-e372-4c94-914f-a8cbf150c2ee"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f33d52bd-a2fa-4d77-a2cf-bd126f003b5e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f83fff9a-01f9-46a9-9190-3c2bcebb1247"));

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
