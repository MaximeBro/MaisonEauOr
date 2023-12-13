using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MaisonEauOr.Migrations
{
    /// <inheritdoc />
    public partial class AddProductTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cosmetics",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Volume = table.Column<double>(type: "REAL", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    AddedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    StockAmount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cosmetics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HairProducts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    AddedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    StockAmount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HairProducts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Honeys",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    AddedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    StockAmount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Honeys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MadeHome",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    AddedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    StockAmount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MadeHome", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mists",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    AddedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    StockAmount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MuscTaharas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    AddedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    StockAmount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MuscTaharas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Perfumes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Gourmet = table.Column<bool>(type: "INTEGER", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    AddedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    StockAmount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perfumes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Option",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    HairProductId = table.Column<Guid>(type: "TEXT", nullable: true),
                    HoneyId = table.Column<Guid>(type: "TEXT", nullable: true),
                    MadeHomeId = table.Column<Guid>(type: "TEXT", nullable: true),
                    MistId = table.Column<Guid>(type: "TEXT", nullable: true),
                    MuscTaharaId = table.Column<Guid>(type: "TEXT", nullable: true),
                    PerfumeId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Option", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Option_HairProducts_HairProductId",
                        column: x => x.HairProductId,
                        principalTable: "HairProducts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Option_Honeys_HoneyId",
                        column: x => x.HoneyId,
                        principalTable: "Honeys",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Option_MadeHome_MadeHomeId",
                        column: x => x.MadeHomeId,
                        principalTable: "MadeHome",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Option_Mists_MistId",
                        column: x => x.MistId,
                        principalTable: "Mists",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Option_MuscTaharas_MuscTaharaId",
                        column: x => x.MuscTaharaId,
                        principalTable: "MuscTaharas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Option_Perfumes_PerfumeId",
                        column: x => x.PerfumeId,
                        principalTable: "Perfumes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Option_HairProductId",
                table: "Option",
                column: "HairProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Option_HoneyId",
                table: "Option",
                column: "HoneyId");

            migrationBuilder.CreateIndex(
                name: "IX_Option_MadeHomeId",
                table: "Option",
                column: "MadeHomeId");

            migrationBuilder.CreateIndex(
                name: "IX_Option_MistId",
                table: "Option",
                column: "MistId");

            migrationBuilder.CreateIndex(
                name: "IX_Option_MuscTaharaId",
                table: "Option",
                column: "MuscTaharaId");

            migrationBuilder.CreateIndex(
                name: "IX_Option_PerfumeId",
                table: "Option",
                column: "PerfumeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cosmetics");

            migrationBuilder.DropTable(
                name: "Option");

            migrationBuilder.DropTable(
                name: "HairProducts");

            migrationBuilder.DropTable(
                name: "Honeys");

            migrationBuilder.DropTable(
                name: "MadeHome");

            migrationBuilder.DropTable(
                name: "Mists");

            migrationBuilder.DropTable(
                name: "MuscTaharas");

            migrationBuilder.DropTable(
                name: "Perfumes");
        }
    }
}
