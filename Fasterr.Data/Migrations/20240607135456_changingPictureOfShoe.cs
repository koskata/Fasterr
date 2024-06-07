using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fasterr.Data.Migrations
{
    public partial class changingPictureOfShoe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("35c9c992-f210-4939-8a1a-b1d0ddc46daf"),
                column: "ImageURL",
                value: "https://i1.t4s.cz/products/dj5166-146/nike-zoom-superfly-9-elite-sg-proac-545030-dj5166-146.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("35c9c992-f210-4939-8a1a-b1d0ddc46daf"),
                column: "ImageURL",
                value: "https://frankfurt.apollo.olxcdn.com/v1/files/xz34ug0kvi9b-BG/image");
        }
    }
}
