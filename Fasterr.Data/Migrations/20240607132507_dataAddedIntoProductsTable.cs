using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fasterr.Data.Migrations
{
    public partial class dataAddedIntoProductsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(70)",
                maxLength: 70,
                nullable: false,
                comment: "Product name",
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40,
                oldComment: "Product name");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "CategoryId", "Description", "Discount", "ImageURL", "Name", "Price", "Rating" },
                values: new object[] { new Guid("35c9c992-f210-4939-8a1a-b1d0ddc46daf"), "Nike", 1, "Стилни футболни обувки за ежедневни тренировки и мачове", 0, "https://frankfurt.apollo.olxcdn.com/v1/files/xz34ug0kvi9b-BG/image", "Футболни обувки Nike Zoom Mercurial Superfly 9 Elite FG", 299.99m, 0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "CategoryId", "Description", "Discount", "ImageURL", "Name", "Price", "Rating" },
                values: new object[] { new Guid("3a84fcad-faa8-4ba7-bd2b-85dc1db18478"), "Nike", 1, "Професионални футболни обувки", 0, "https://frankfurt.apollo.olxcdn.com/v1/files/f4eqgsde7r0w1-BG/image", "Професионални бутонки Nike Mercurial Dream Speed Superfly 8 Elite FG", 409.99m, 0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "CategoryId", "Description", "Discount", "ImageURL", "Name", "Price", "Rating" },
                values: new object[] { new Guid("920c24b3-0d0e-473a-b79b-0c7961654ca0"), "Nike", 1, "Стилни футболни обувки за ежедневни тренировки и мачове", 0, "https://i1.t4s.cz/products/dj5598-146/nike-zoom-superfly-9-pro-fg-547430-dj5598-148-960.webp", "Футболни обувки Nike Zoom Superfly 9 Pro FG", 309.99m, 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                keyValue: new Guid("920c24b3-0d0e-473a-b79b-0c7961654ca0"));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                comment: "Product name",
                oldClrType: typeof(string),
                oldType: "nvarchar(70)",
                oldMaxLength: 70,
                oldComment: "Product name");
        }
    }
}
