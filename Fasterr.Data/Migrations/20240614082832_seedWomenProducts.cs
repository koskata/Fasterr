using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fasterr.Data.Migrations
{
    public partial class seedWomenProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("35c9c992-f210-4939-8a1a-b1d0ddc46daf"),
                column: "Description",
                value: "Стилни футболни обувки за ежедневни тренировки и мачове.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3a84fcad-faa8-4ba7-bd2b-85dc1db18478"),
                column: "Description",
                value: "Професионални футболни обувки.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3d599ead-4054-4400-a434-6d2c2e40050a"),
                column: "Description",
                value: "Оригинални тениска и шорти за всекидневни тренировки на футболен клуб Manchester City.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("91de93c1-7470-465a-9d6f-c4e0ca348b0f"),
                column: "Description",
                value: "Долнище и горнище за тренировки 2023/2024 Аржентина.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("920c24b3-0d0e-473a-b79b-0c7961654ca0"),
                column: "Description",
                value: "Стилни футболни обувки за ежедневни тренировки и мачове.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9337cd2c-b65e-4851-82be-dfacdf135c8b"),
                column: "Description",
                value: "Оригинални тениска и шорти за всекидневни тренировки на футболен клуб PSG.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("efb16cae-f4f7-43b0-bdc5-5527c7960d11"),
                column: "Description",
                value: "Удобен термо клин на KIPSTA.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f1162601-e372-4c94-914f-a8cbf150c2ee"),
                column: "Description",
                value: "Оригинални тениска и шорти за всекидневни тренировки на футболен клуб Liverpool.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f33d52bd-a2fa-4d77-a2cf-bd126f003b5e"),
                column: "Description",
                value: "Долнище и горнище за тренировки 2023/2024 PSG.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f83fff9a-01f9-46a9-9190-3c2bcebb1247"),
                column: "Description",
                value: "Удобна и качествена тениска Under Armour.");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CategoryId", "Description", "Discount", "ImageURL", "Name", "Price", "Rating", "TypeId" },
                values: new object[,]
                {
                    { new Guid("0c9a8c04-d64a-44b7-80f6-cf09e86dfd5d"), 1, 1, "Професионални футболни обувки NIKE с бутони подоходящи за вътре и навънка.", 0, "https://m.media-amazon.com/images/I/61O77oYe6KL._AC_UY900_.jpg", "QILTON Women Football Shoes Professional Spikes Indoor/Outdoor", 299.99m, 0, 2 },
                    { new Guid("1e3bc703-82d0-486a-9e86-d33f1d600f7c"), 4, 1, "Висок клас футболни обувки PUMA за ежедневни тренировки и мачове.", 0, "https://images.puma.com/image/upload/f_auto,q_auto,b_rgb:fafafa/global/107599/03/sv01/fnd/ZAF/w/1000/h/1000/fmt/png", "FUTURE 7 ULTIMATE FG/AG Football Boots", 446.99m, 0, 2 },
                    { new Guid("3622da3c-834e-4d0b-851f-2f471c4d4159"), 3, 4, "Женска термоблуза с дълъг ръкав Under Armour", 0, "https://ryos.co.nz/cdn/shop/products/1361524-001.jpg?v=1666151595", "Under Armour HeatGear® Armour Long Sleeve Top Black", 29.99m, 0, 2 },
                    { new Guid("4acb5c45-8d26-49b4-ac40-26ab959978e4"), 1, 2, "Женска тениска на Англия 2023 Домакин", 0, "https://www.pricerunner.com/product/640x640/3013004324/Nike-Women-s-England-2023-Stadium-Home-Football-Shirt.jpg?ph=true", "NIKE Women's England 2023 Stadium Home Football Shirt", 99.99m, 0, 2 },
                    { new Guid("7250d8c9-eead-49cc-b625-1f349f5db388"), 1, 2, "Женски екип Нидерландия Домакин", 0, "https://www.knvbshop.nl/media/catalog/product/cache/d81c8dc66c69ceb69419c2e7e72e896d/2/5/259628_nike-nederland-thuistenue-2024-2026-dames.jpg", "Nike Dutch Team Home Kit 2024-2026 Women", 79.99m, 0, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0c9a8c04-d64a-44b7-80f6-cf09e86dfd5d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1e3bc703-82d0-486a-9e86-d33f1d600f7c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3622da3c-834e-4d0b-851f-2f471c4d4159"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4acb5c45-8d26-49b4-ac40-26ab959978e4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7250d8c9-eead-49cc-b625-1f349f5db388"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("35c9c992-f210-4939-8a1a-b1d0ddc46daf"),
                column: "Description",
                value: "Стилни футболни обувки за ежедневни тренировки и мачове");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3a84fcad-faa8-4ba7-bd2b-85dc1db18478"),
                column: "Description",
                value: "Професионални футболни обувки");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3d599ead-4054-4400-a434-6d2c2e40050a"),
                column: "Description",
                value: "Оригинални тениска и шорти за всекидневни тренировки на футболен клуб Manchester City");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("91de93c1-7470-465a-9d6f-c4e0ca348b0f"),
                column: "Description",
                value: "Долнище и горнище за тренировки 2023/2024 Аржентина");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("920c24b3-0d0e-473a-b79b-0c7961654ca0"),
                column: "Description",
                value: "Стилни футболни обувки за ежедневни тренировки и мачове");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9337cd2c-b65e-4851-82be-dfacdf135c8b"),
                column: "Description",
                value: "Оригинални тениска и шорти за всекидневни тренировки на футболен клуб PSG");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("efb16cae-f4f7-43b0-bdc5-5527c7960d11"),
                column: "Description",
                value: "Удобен термо клин на KIPSTA");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f1162601-e372-4c94-914f-a8cbf150c2ee"),
                column: "Description",
                value: "Оригинални тениска и шорти за всекидневни тренировки на футболен клуб Liverpool");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f33d52bd-a2fa-4d77-a2cf-bd126f003b5e"),
                column: "Description",
                value: "Долнище и горнище за тренировки 2023/2024 PSG");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f83fff9a-01f9-46a9-9190-3c2bcebb1247"),
                column: "Description",
                value: "Удобна и качествена тениска Under Armour");
        }
    }
}
