using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fasterr.Data.Migrations
{
    public partial class addingMoreDataIntoProductsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Brand",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "BrandId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Product brand");

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Name" },
                values: new object[] { 6, "Kipsta" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("35c9c992-f210-4939-8a1a-b1d0ddc46daf"),
                column: "BrandId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3a84fcad-faa8-4ba7-bd2b-85dc1db18478"),
                column: "BrandId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("920c24b3-0d0e-473a-b79b-0c7961654ca0"),
                column: "BrandId",
                value: 1);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CategoryId", "Description", "Discount", "ImageURL", "Name", "Price", "Rating" },
                values: new object[,]
                {
                    { new Guid("3d599ead-4054-4400-a434-6d2c2e40050a"), 4, 2, "Оригинални тениска и шорти за всекидневни тренировки на футболен клуб Manchester City", 0, "https://sportwearbg.com/image/Produkti/Futbol/Ekipi/English/Manchester%20City/23-24/home/detski-ekip-manchester-city.jpg", "Puma Manchester City футболен екип 2023/2024 домакински", 179.99m, 0 },
                    { new Guid("91de93c1-7470-465a-9d6f-c4e0ca348b0f"), 2, 3, "Долнище и горнище за тренировки 2023/2024 Аржентина", 0, "https://img4.dhresource.com/webp/m/0x0/f3/albu/km/g/30/b88fd8a7-70e7-43cb-ab4d-5fd139e12cff.jpg", "Анцуг за тренировка Argentina 2023/2024", 165.99m, 0 },
                    { new Guid("9337cd2c-b65e-4851-82be-dfacdf135c8b"), 1, 2, "Оригинални тениска и шорти за всекидневни тренировки на футболен клуб PSG", 0, "https://frankfurt.apollo.olxcdn.com/v1/files/cpryl7ozvivj1-BG/image;s=1800x1846", "DRI-FIT футболен екип PSG MBAPPE", 199.99m, 0 },
                    { new Guid("f1162601-e372-4c94-914f-a8cbf150c2ee"), 1, 2, "Оригинални тениска и шорти за всекидневни тренировки на футболен клуб Liverpool", 0, "https://sportwearbg.com/image/Produkti/Futbol/Ekipi/English/Liverpool/23%2024/Home/detski_ekip_liverpool-2023-2024.jpg", "Nike Liverpool футболен екип 2023/2024 домакински", 189.99m, 0 },
                    { new Guid("f33d52bd-a2fa-4d77-a2cf-bd126f003b5e"), 1, 3, "Долнище и горнище за тренировки 2023/2024 PSG", 0, "https://m.media-amazon.com/images/I/619oiA9HqZL._AC_UY1100_.jpg", "Анцуг за тренировка PSG 2023/2024", 185.99m, 0 },
                    { new Guid("f83fff9a-01f9-46a9-9190-3c2bcebb1247"), 3, 4, "Удобна и качествена тениска Under Armour", 0, "https://cdn.4camping.bg/files/photos/1600/a/ad473c5b-mazhka-teniska-under-armour-hg-armour-comp-ls-cheren-black-white.jpg", "Термо блуза Under Armour", 35.99m, 0 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CategoryId", "Description", "Discount", "ImageURL", "Name", "Price", "Rating" },
                values: new object[] { new Guid("efb16cae-f4f7-43b0-bdc5-5527c7960d11"), 6, 4, "Удобен термо клин на KIPSTA", 0, "https://contents.mediadecathlon.com/p2480341/k$bba35f387da6b9cd9450cbcc0d46db4d/dolen-kas-klin-keepcomfort-cheren.jpg?format=auto&quality=40&f=800x800", "Долен къс клин KEEPCOMFORT KIPSTA", 25.99m, 0 });

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandId",
                table: "Products",
                column: "BrandId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Brands_BrandId",
                table: "Products",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Brands_BrandId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_BrandId",
                table: "Products");

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
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DropColumn(
                name: "BrandId",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "Brand",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                comment: "Product brand");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("35c9c992-f210-4939-8a1a-b1d0ddc46daf"),
                column: "Brand",
                value: "Nike");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3a84fcad-faa8-4ba7-bd2b-85dc1db18478"),
                column: "Brand",
                value: "Nike");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("920c24b3-0d0e-473a-b79b-0c7961654ca0"),
                column: "Brand",
                value: "Nike");
        }
    }
}
