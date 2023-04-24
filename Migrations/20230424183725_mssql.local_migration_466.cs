using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace napelem_telepito_kozpont.Migrations
{
    /// <inheritdoc />
    public partial class mssqllocal_migration_466 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "helyszin",
                table: "Projekt",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "leiras",
                table: "Projekt",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "helyszin",
                table: "Projekt");

            migrationBuilder.DropColumn(
                name: "leiras",
                table: "Projekt");
        }
    }
}
