using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MaisonEauOr.Migrations
{
    /// <inheritdoc />
    public partial class AddsDiscounts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Discounts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    NameCode = table.Column<string>(type: "TEXT", nullable: false),
                    Discount = table.Column<double>(type: "REAL", nullable: false),
                    IsPercent = table.Column<bool>(type: "INTEGER", nullable: false),
                    DiscountPercent = table.Column<double>(type: "REAL", nullable: false),
                    ProductID = table.Column<Guid>(type: "TEXT", nullable: false),
                    Type = table.Column<int>(type: "INTEGER", nullable: false),
                    Categories = table.Column<string>(type: "TEXT", nullable: false),
                    ClientsIDs = table.Column<string>(type: "TEXT", nullable: false),
                    StartsAt = table.Column<DateTime>(type: "TEXT", nullable: true),
                    EndsAt = table.Column<DateTime>(type: "TEXT", nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discounts", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Discounts");
        }
    }
}
