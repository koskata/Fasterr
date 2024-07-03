using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fasterr.Data.Migrations
{
    public partial class addingDiscountsToSomeProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1e3bc703-82d0-486a-9e86-d33f1d600f7c"),
                column: "Discount",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3d599ead-4054-4400-a434-6d2c2e40050a"),
                column: "Discount",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4acb5c45-8d26-49b4-ac40-26ab959978e4"),
                column: "Discount",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7250d8c9-eead-49cc-b625-1f349f5db388"),
                column: "Discount",
                value: 50);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("91de93c1-7470-465a-9d6f-c4e0ca348b0f"),
                column: "Discount",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("920c24b3-0d0e-473a-b79b-0c7961654ca0"),
                column: "Discount",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9337cd2c-b65e-4851-82be-dfacdf135c8b"),
                column: "Discount",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f83fff9a-01f9-46a9-9190-3c2bcebb1247"),
                column: "Discount",
                value: 10);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1e3bc703-82d0-486a-9e86-d33f1d600f7c"),
                column: "Discount",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3d599ead-4054-4400-a434-6d2c2e40050a"),
                column: "Discount",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4acb5c45-8d26-49b4-ac40-26ab959978e4"),
                column: "Discount",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7250d8c9-eead-49cc-b625-1f349f5db388"),
                column: "Discount",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("91de93c1-7470-465a-9d6f-c4e0ca348b0f"),
                column: "Discount",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("920c24b3-0d0e-473a-b79b-0c7961654ca0"),
                column: "Discount",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9337cd2c-b65e-4851-82be-dfacdf135c8b"),
                column: "Discount",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f83fff9a-01f9-46a9-9190-3c2bcebb1247"),
                column: "Discount",
                value: 0);
        }
    }
}
