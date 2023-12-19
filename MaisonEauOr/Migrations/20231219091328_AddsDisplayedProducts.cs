using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MaisonEauOr.Migrations
{
    /// <inheritdoc />
    public partial class AddsDisplayedProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BasketProducts_ProductModel_ProductID",
                table: "BasketProducts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductModel",
                table: "ProductModel");

            migrationBuilder.RenameTable(
                name: "ProductModel",
                newName: "Products");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "DisplayedProducts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    ProductID = table.Column<Guid>(type: "TEXT", nullable: false),
                    Index = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DisplayedProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DisplayedProducts_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DisplayedProducts_ProductID",
                table: "DisplayedProducts",
                column: "ProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_BasketProducts_Products_ProductID",
                table: "BasketProducts",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BasketProducts_Products_ProductID",
                table: "BasketProducts");

            migrationBuilder.DropTable(
                name: "DisplayedProducts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "ProductModel");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductModel",
                table: "ProductModel",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BasketProducts_ProductModel_ProductID",
                table: "BasketProducts",
                column: "ProductID",
                principalTable: "ProductModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
