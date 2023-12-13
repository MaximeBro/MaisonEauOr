using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MaisonEauOr.Migrations
{
    /// <inheritdoc />
    public partial class UpdatesProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Perfumes",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsAvailable",
                table: "Perfumes",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "MuscTaharas",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsAvailable",
                table: "MuscTaharas",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Mists",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsAvailable",
                table: "Mists",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "MadeHome",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsAvailable",
                table: "MadeHome",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Honeys",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsAvailable",
                table: "Honeys",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "HairProducts",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsAvailable",
                table: "HairProducts",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Cosmetics",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsAvailable",
                table: "Cosmetics",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Perfumes");

            migrationBuilder.DropColumn(
                name: "IsAvailable",
                table: "Perfumes");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "MuscTaharas");

            migrationBuilder.DropColumn(
                name: "IsAvailable",
                table: "MuscTaharas");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Mists");

            migrationBuilder.DropColumn(
                name: "IsAvailable",
                table: "Mists");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "MadeHome");

            migrationBuilder.DropColumn(
                name: "IsAvailable",
                table: "MadeHome");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Honeys");

            migrationBuilder.DropColumn(
                name: "IsAvailable",
                table: "Honeys");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "HairProducts");

            migrationBuilder.DropColumn(
                name: "IsAvailable",
                table: "HairProducts");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Cosmetics");

            migrationBuilder.DropColumn(
                name: "IsAvailable",
                table: "Cosmetics");
        }
    }
}
