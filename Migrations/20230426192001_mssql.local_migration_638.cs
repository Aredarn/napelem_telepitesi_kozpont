using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace napelem_telepito_kozpont.Migrations
{
    /// <inheritdoc />
    public partial class mssqllocal_migration_638 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Arucikknev",
                table: "ProjektekArucikkhez");

            migrationBuilder.AddColumn<int>(
                name: "ArucikkID",
                table: "ProjektekArucikkhez",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArucikkID",
                table: "ProjektekArucikkhez");

            migrationBuilder.AddColumn<string>(
                name: "Arucikknev",
                table: "ProjektekArucikkhez",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
