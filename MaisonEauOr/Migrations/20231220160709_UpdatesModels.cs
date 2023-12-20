using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MaisonEauOr.Migrations
{
    /// <inheritdoc />
    public partial class UpdatesModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NameCode",
                table: "Discounts",
                newName: "CodeName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CodeName",
                table: "Discounts",
                newName: "NameCode");
        }
    }
}
