using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fasterr.Data.Migrations
{
    public partial class createAndSeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false, comment: "User first name"),
                    LastName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false, comment: "User last name"),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "User profile image"),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, comment: "Brand name")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Category identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Types",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Product identifier"),
                    Name = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false, comment: "Product name"),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false, comment: "Product description"),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Product image"),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false, comment: "Product price"),
                    Discount = table.Column<int>(type: "int", nullable: true, comment: "Product price discount"),
                    Rating = table.Column<int>(type: "int", nullable: false, comment: "Product rating"),
                    BrandId = table.Column<int>(type: "int", nullable: false, comment: "Product brand"),
                    CategoryId = table.Column<int>(type: "int", nullable: false, comment: "Product category identifier"),
                    TypeId = table.Column<int>(type: "int", nullable: false, comment: "Product type identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Types_TypeId",
                        column: x => x.TypeId,
                        principalTable: "Types",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductsBuyersCart",
                columns: table => new
                {
                    BuyerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "User identifier"),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Product identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsBuyersCart", x => new { x.BuyerId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_ProductsBuyersCart_AspNetUsers_BuyerId",
                        column: x => x.BuyerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductsBuyersCart_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductsBuyersLike",
                columns: table => new
                {
                    BuyerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsBuyersLike", x => new { x.BuyerId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_ProductsBuyersLike_AspNetUsers_BuyerId",
                        column: x => x.BuyerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductsBuyersLike_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductsBuyersPurchased",
                columns: table => new
                {
                    BuyerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "User identifier"),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Product identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsBuyersPurchased", x => new { x.BuyerId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_ProductsBuyersPurchased_AspNetUsers_BuyerId",
                        column: x => x.BuyerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductsBuyersPurchased_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductsBuyersRate",
                columns: table => new
                {
                    BuyerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsBuyersRate", x => new { x.BuyerId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_ProductsBuyersRate_AspNetUsers_BuyerId",
                        column: x => x.BuyerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductsBuyersRate_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                table: "Types",
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
                    { new Guid("0c9a8c04-d64a-44b7-80f6-cf09e86dfd5d"), 1, 1, "Професионални футболни обувки NIKE с бутони подоходящи за вътре и навънка.", 0, "https://m.media-amazon.com/images/I/61O77oYe6KL._AC_UY900_.jpg", "QILTON Women Football Shoes Professional Spikes Indoor/Outdoor", 299.99m, 0, 2 },
                    { new Guid("1e3bc703-82d0-486a-9e86-d33f1d600f7c"), 4, 1, "Висок клас футболни обувки PUMA за ежедневни тренировки и мачове.", 30, "https://images.puma.com/image/upload/f_auto,q_auto,b_rgb:fafafa/global/107599/03/sv01/fnd/ZAF/w/1000/h/1000/fmt/png", "FUTURE 7 ULTIMATE FG/AG Football Boots", 446.99m, 0, 2 },
                    { new Guid("35c9c992-f210-4939-8a1a-b1d0ddc46daf"), 1, 1, "Стилни футболни обувки за ежедневни тренировки и мачове.", 0, "https://www.futbolemotion.com/imagesarticulos/199088/grandes/bota-nike-zoom-mercurial-superfly-9-elite-fg-turquesa-0.webp", "Футболни обувки Nike Zoom Mercurial Superfly 9 Elite FG Hyper Turq", 299.99m, 0, 1 },
                    { new Guid("3622da3c-834e-4d0b-851f-2f471c4d4159"), 3, 4, "Женска термоблуза с дълъг ръкав Under Armour", 0, "https://ryos.co.nz/cdn/shop/products/1361524-001.jpg?v=1666151595", "Under Armour HeatGear® Armour Long Sleeve Top Black", 29.99m, 0, 2 },
                    { new Guid("3a84fcad-faa8-4ba7-bd2b-85dc1db18478"), 1, 1, "Професионални футболни обувки.", 0, "https://frankfurt.apollo.olxcdn.com/v1/files/f4eqgsde7r0w1-BG/image", "Професионални бутонки Nike Mercurial Dream Speed Superfly 8 Elite FG", 409.99m, 0, 1 },
                    { new Guid("3d599ead-4054-4400-a434-6d2c2e40050a"), 4, 2, "Оригинални тениска и шорти за всекидневни тренировки на футболен клуб Manchester City.", 20, "https://sportwearbg.com/image/Produkti/Futbol/Ekipi/English/Manchester%20City/23-24/home/detski-ekip-manchester-city.jpg", "Puma Manchester City футболен екип 2023/2024 домакински", 179.99m, 0, 1 },
                    { new Guid("4acb5c45-8d26-49b4-ac40-26ab959978e4"), 1, 2, "Женска тениска на Англия 2023 Домакин", 30, "https://www.pricerunner.com/product/640x640/3013004324/Nike-Women-s-England-2023-Stadium-Home-Football-Shirt.jpg?ph=true", "NIKE Women's England 2023 Stadium Home Football Shirt", 99.99m, 0, 2 },
                    { new Guid("7250d8c9-eead-49cc-b625-1f349f5db388"), 1, 2, "Женски екип Нидерландия Домакин", 50, "https://www.knvbshop.nl/media/catalog/product/cache/d81c8dc66c69ceb69419c2e7e72e896d/2/5/259628_nike-nederland-thuistenue-2024-2026-dames.jpg", "Nike Dutch Team Home Kit 2024-2026 Women", 79.99m, 0, 2 },
                    { new Guid("91de93c1-7470-465a-9d6f-c4e0ca348b0f"), 2, 3, "Долнище и горнище за тренировки 2023/2024 Аржентина.", 30, "https://img4.dhresource.com/webp/m/0x0/f3/albu/km/g/30/b88fd8a7-70e7-43cb-ab4d-5fd139e12cff.jpg", "Анцуг за тренировка Argentina 2023/2024", 165.99m, 0, 1 },
                    { new Guid("920c24b3-0d0e-473a-b79b-0c7961654ca0"), 1, 1, "Стилни футболни обувки за ежедневни тренировки и мачове.", 20, "https://thirdcoastsoccer.net/cdn/shop/products/image__80827.1657841497.1280.1280.png?v=1681567637", "Футболни обувки Nike Zoom Mercurial Superfly 9 Academy FG", 309.99m, 0, 1 },
                    { new Guid("9337cd2c-b65e-4851-82be-dfacdf135c8b"), 1, 2, "Оригинални тениска и шорти за всекидневни тренировки на футболен клуб PSG.", 25, "https://frankfurt.apollo.olxcdn.com/v1/files/cpryl7ozvivj1-BG/image;s=1800x1846", "DRI-FIT футболен екип PSG MBAPPE", 199.99m, 0, 1 },
                    { new Guid("efb16cae-f4f7-43b0-bdc5-5527c7960d11"), 6, 4, "Удобен термо клин на KIPSTA.", 0, "https://contents.mediadecathlon.com/p2480341/k$bba35f387da6b9cd9450cbcc0d46db4d/dolen-kas-klin-keepcomfort-cheren.jpg?format=auto&quality=40&f=800x800", "Долен къс клин KEEPCOMFORT KIPSTA", 25.99m, 0, 1 },
                    { new Guid("f1162601-e372-4c94-914f-a8cbf150c2ee"), 1, 2, "Оригинални тениска и шорти за всекидневни тренировки на футболен клуб Liverpool.", 0, "https://sportwearbg.com/image/Produkti/Futbol/Ekipi/English/Liverpool/23%2024/Home/detski_ekip_liverpool-2023-2024.jpg", "Nike Liverpool футболен екип 2023/2024 домакински", 189.99m, 0, 1 },
                    { new Guid("f33d52bd-a2fa-4d77-a2cf-bd126f003b5e"), 1, 3, "Долнище и горнище за тренировки 2023/2024 PSG.", 0, "https://m.media-amazon.com/images/I/619oiA9HqZL._AC_UY1100_.jpg", "Анцуг за тренировка PSG 2023/2024", 185.99m, 0, 1 },
                    { new Guid("f83fff9a-01f9-46a9-9190-3c2bcebb1247"), 3, 4, "Удобна и качествена тениска Under Armour.", 10, "https://cdn.4camping.bg/files/photos/1600/a/ad473c5b-mazhka-teniska-under-armour-hg-armour-comp-ls-cheren-black-white.jpg", "Термо блуза Under Armour", 35.99m, 0, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandId",
                table: "Products",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_TypeId",
                table: "Products",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsBuyersCart_ProductId",
                table: "ProductsBuyersCart",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsBuyersLike_ProductId",
                table: "ProductsBuyersLike",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsBuyersPurchased_ProductId",
                table: "ProductsBuyersPurchased",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsBuyersRate_ProductId",
                table: "ProductsBuyersRate",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ProductsBuyersCart");

            migrationBuilder.DropTable(
                name: "ProductsBuyersLike");

            migrationBuilder.DropTable(
                name: "ProductsBuyersPurchased");

            migrationBuilder.DropTable(
                name: "ProductsBuyersRate");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Types");
        }
    }
}
