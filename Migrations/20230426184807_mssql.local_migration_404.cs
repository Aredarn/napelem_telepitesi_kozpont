using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace napelem_telepito_kozpont.Migrations
{
    /// <inheritdoc />
    public partial class mssqllocal_migration_404 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Arucikk",
                table: "Arucikk");

            migrationBuilder.AlterColumn<string>(
                name: "Arucikknev",
                table: "Arucikk",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "ArucikkID",
                table: "Arucikk",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Arucikk",
                table: "Arucikk",
                column: "ArucikkID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Arucikk",
                table: "Arucikk");

            migrationBuilder.DropColumn(
                name: "ArucikkID",
                table: "Arucikk");

            migrationBuilder.AlterColumn<string>(
                name: "Arucikknev",
                table: "Arucikk",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Arucikk",
                table: "Arucikk",
                column: "Arucikknev");
        }
    }
}
