using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fasterr.Data.Migrations
{
    public partial class NewFieldForTotalPriceWithDiscountForEveryProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "TotalPrice",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                comment: "Product total price with discount");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0c9a8c04-d64a-44b7-80f6-cf09e86dfd5d"),
                column: "TotalPrice",
                value: 299.99m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1e3bc703-82d0-486a-9e86-d33f1d600f7c"),
                column: "TotalPrice",
                value: 446.99m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("35c9c992-f210-4939-8a1a-b1d0ddc46daf"),
                column: "TotalPrice",
                value: 299.99m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3622da3c-834e-4d0b-851f-2f471c4d4159"),
                column: "TotalPrice",
                value: 29.99m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3a84fcad-faa8-4ba7-bd2b-85dc1db18478"),
                column: "TotalPrice",
                value: 409.99m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3d599ead-4054-4400-a434-6d2c2e40050a"),
                column: "TotalPrice",
                value: 179.99m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4acb5c45-8d26-49b4-ac40-26ab959978e4"),
                column: "TotalPrice",
                value: 99.99m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7250d8c9-eead-49cc-b625-1f349f5db388"),
                column: "TotalPrice",
                value: 79.99m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("91de93c1-7470-465a-9d6f-c4e0ca348b0f"),
                column: "TotalPrice",
                value: 165.99m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("920c24b3-0d0e-473a-b79b-0c7961654ca0"),
                column: "TotalPrice",
                value: 309.99m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9337cd2c-b65e-4851-82be-dfacdf135c8b"),
                column: "TotalPrice",
                value: 199.99m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("efb16cae-f4f7-43b0-bdc5-5527c7960d11"),
                column: "TotalPrice",
                value: 25.99m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f1162601-e372-4c94-914f-a8cbf150c2ee"),
                column: "TotalPrice",
                value: 189.99m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f33d52bd-a2fa-4d77-a2cf-bd126f003b5e"),
                column: "TotalPrice",
                value: 185.99m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f83fff9a-01f9-46a9-9190-3c2bcebb1247"),
                column: "TotalPrice",
                value: 35.99m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "Products");
        }
    }
}
