using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fasterr.Data.Migrations
{
    public partial class editedNamesAndPicturesOfShoes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("35c9c992-f210-4939-8a1a-b1d0ddc46daf"),
                columns: new[] { "ImageURL", "Name" },
                values: new object[] { "https://www.futbolemotion.com/imagesarticulos/199088/grandes/bota-nike-zoom-mercurial-superfly-9-elite-fg-turquesa-0.webp", "Футболни обувки Nike Zoom Mercurial Superfly 9 Elite FG Hyper Turq" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("920c24b3-0d0e-473a-b79b-0c7961654ca0"),
                columns: new[] { "ImageURL", "Name" },
                values: new object[] { "https://thirdcoastsoccer.net/cdn/shop/products/image__80827.1657841497.1280.1280.png?v=1681567637", "Футболни обувки Nike Zoom Mercurial Superfly 9 Academy FG" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("35c9c992-f210-4939-8a1a-b1d0ddc46daf"),
                columns: new[] { "ImageURL", "Name" },
                values: new object[] { "https://i1.t4s.cz/products/dj5166-146/nike-zoom-superfly-9-elite-sg-proac-545030-dj5166-146.jpg", "Футболни обувки Nike Zoom Mercurial Superfly 9 Elite FG" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("920c24b3-0d0e-473a-b79b-0c7961654ca0"),
                columns: new[] { "ImageURL", "Name" },
                values: new object[] { "https://i1.t4s.cz/products/dj5598-146/nike-zoom-superfly-9-pro-fg-547430-dj5598-148-960.webp", "Футболни обувки Nike Zoom Superfly 9 Pro FG" });
        }
    }
}
