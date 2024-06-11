using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fasterr.Data.Migrations
{
    public partial class updatedTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductBuyerRate_AspNetUsers_BuyerId",
                table: "ProductBuyerRate");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductBuyerRate_Products_ProductId",
                table: "ProductBuyerRate");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Type_TypeId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Type",
                table: "Type");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductBuyerRate",
                table: "ProductBuyerRate");

            migrationBuilder.RenameTable(
                name: "Type",
                newName: "Types");

            migrationBuilder.RenameTable(
                name: "ProductBuyerRate",
                newName: "ProductsBuyersRate");

            migrationBuilder.RenameIndex(
                name: "IX_ProductBuyerRate_ProductId",
                table: "ProductsBuyersRate",
                newName: "IX_ProductsBuyersRate_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Types",
                table: "Types",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductsBuyersRate",
                table: "ProductsBuyersRate",
                columns: new[] { "BuyerId", "ProductId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Types_TypeId",
                table: "Products",
                column: "TypeId",
                principalTable: "Types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsBuyersRate_AspNetUsers_BuyerId",
                table: "ProductsBuyersRate",
                column: "BuyerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsBuyersRate_Products_ProductId",
                table: "ProductsBuyersRate",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Types_TypeId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductsBuyersRate_AspNetUsers_BuyerId",
                table: "ProductsBuyersRate");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductsBuyersRate_Products_ProductId",
                table: "ProductsBuyersRate");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Types",
                table: "Types");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductsBuyersRate",
                table: "ProductsBuyersRate");

            migrationBuilder.RenameTable(
                name: "Types",
                newName: "Type");

            migrationBuilder.RenameTable(
                name: "ProductsBuyersRate",
                newName: "ProductBuyerRate");

            migrationBuilder.RenameIndex(
                name: "IX_ProductsBuyersRate_ProductId",
                table: "ProductBuyerRate",
                newName: "IX_ProductBuyerRate_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Type",
                table: "Type",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductBuyerRate",
                table: "ProductBuyerRate",
                columns: new[] { "BuyerId", "ProductId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ProductBuyerRate_AspNetUsers_BuyerId",
                table: "ProductBuyerRate",
                column: "BuyerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductBuyerRate_Products_ProductId",
                table: "ProductBuyerRate",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Type_TypeId",
                table: "Products",
                column: "TypeId",
                principalTable: "Type",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
