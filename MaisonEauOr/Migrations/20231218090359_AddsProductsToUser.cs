using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MaisonEauOr.Migrations
{
    /// <inheritdoc />
    public partial class AddsProductsToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BasketProducts_UserAccounts_UserId",
                table: "BasketProducts");

            migrationBuilder.DropIndex(
                name: "IX_BasketProducts_UserId",
                table: "BasketProducts");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "BasketProducts");

            migrationBuilder.CreateIndex(
                name: "IX_BasketProducts_ClientID",
                table: "BasketProducts",
                column: "ClientID");

            migrationBuilder.AddForeignKey(
                name: "FK_BasketProducts_UserAccounts_ClientID",
                table: "BasketProducts",
                column: "ClientID",
                principalTable: "UserAccounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BasketProducts_UserAccounts_ClientID",
                table: "BasketProducts");

            migrationBuilder.DropIndex(
                name: "IX_BasketProducts_ClientID",
                table: "BasketProducts");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "BasketProducts",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BasketProducts_UserId",
                table: "BasketProducts",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BasketProducts_UserAccounts_UserId",
                table: "BasketProducts",
                column: "UserId",
                principalTable: "UserAccounts",
                principalColumn: "Id");
        }
    }
}
