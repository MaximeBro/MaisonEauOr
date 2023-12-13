using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MaisonEauOr.Migrations
{
    /// <inheritdoc />
    public partial class UpdatesIProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CosmeticsId",
                table: "Option",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Option_CosmeticsId",
                table: "Option",
                column: "CosmeticsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Option_Cosmetics_CosmeticsId",
                table: "Option",
                column: "CosmeticsId",
                principalTable: "Cosmetics",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Option_Cosmetics_CosmeticsId",
                table: "Option");

            migrationBuilder.DropIndex(
                name: "IX_Option_CosmeticsId",
                table: "Option");

            migrationBuilder.DropColumn(
                name: "CosmeticsId",
                table: "Option");
        }
    }
}
