using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MaisonEauOr.Migrations
{
    /// <inheritdoc />
    public partial class UpdatesOrders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "OrderID",
                table: "BasketProducts",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OrderModelId",
                table: "BasketProducts",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    ClientID = table.Column<Guid>(type: "TEXT", nullable: false),
                    OrderedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ShippingPrice = table.Column<double>(type: "REAL", nullable: false),
                    ShippingTown = table.Column<string>(type: "TEXT", nullable: false),
                    ShippingPostalCode = table.Column<int>(type: "INTEGER", nullable: false),
                    ShippingAddress = table.Column<string>(type: "TEXT", nullable: false),
                    Total = table.Column<double>(type: "REAL", nullable: false),
                    Payed = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_UserAccounts_ClientID",
                        column: x => x.ClientID,
                        principalTable: "UserAccounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BasketProducts_OrderModelId",
                table: "BasketProducts",
                column: "OrderModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ClientID",
                table: "Orders",
                column: "ClientID");

            migrationBuilder.AddForeignKey(
                name: "FK_BasketProducts_Orders_OrderModelId",
                table: "BasketProducts",
                column: "OrderModelId",
                principalTable: "Orders",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BasketProducts_Orders_OrderModelId",
                table: "BasketProducts");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_BasketProducts_OrderModelId",
                table: "BasketProducts");

            migrationBuilder.DropColumn(
                name: "OrderID",
                table: "BasketProducts");

            migrationBuilder.DropColumn(
                name: "OrderModelId",
                table: "BasketProducts");
        }
    }
}
