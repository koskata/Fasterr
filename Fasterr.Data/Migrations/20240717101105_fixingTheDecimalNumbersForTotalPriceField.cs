using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fasterr.Data.Migrations
{
    public partial class fixingTheDecimalNumbersForTotalPriceField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1e3bc703-82d0-486a-9e86-d33f1d600f7c"),
                column: "TotalPrice",
                value: 312.893m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3d599ead-4054-4400-a434-6d2c2e40050a"),
                column: "TotalPrice",
                value: 143.992m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4acb5c45-8d26-49b4-ac40-26ab959978e4"),
                column: "TotalPrice",
                value: 69.993m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7250d8c9-eead-49cc-b625-1f349f5db388"),
                column: "TotalPrice",
                value: 39.995m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("91de93c1-7470-465a-9d6f-c4e0ca348b0f"),
                column: "TotalPrice",
                value: 116.193m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("920c24b3-0d0e-473a-b79b-0c7961654ca0"),
                column: "TotalPrice",
                value: 247.992m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9337cd2c-b65e-4851-82be-dfacdf135c8b"),
                column: "TotalPrice",
                value: 149.9925m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f83fff9a-01f9-46a9-9190-3c2bcebb1247"),
                column: "TotalPrice",
                value: 32.391m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1e3bc703-82d0-486a-9e86-d33f1d600f7c"),
                column: "TotalPrice",
                value: 446.99m);

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
                keyValue: new Guid("f83fff9a-01f9-46a9-9190-3c2bcebb1247"),
                column: "TotalPrice",
                value: 35.99m);
        }
    }
}
