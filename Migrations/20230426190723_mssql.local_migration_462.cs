using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace napelem_telepito_kozpont.Migrations
{
    /// <inheritdoc />
    public partial class mssqllocal_migration_462 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Felhasznalo",
                table: "Felhasznalo");

            migrationBuilder.DropColumn(
                name: "ProjectManagerID",
                table: "Projekt");

            migrationBuilder.DropColumn(
                name: "itemName",
                table: "Polc");

            migrationBuilder.AlterColumn<int>(
                name: "ClientID",
                table: "Projekt",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "FelhasznaloID",
                table: "Projekt",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ArucikkID",
                table: "Polc",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Felhasznalo",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "FelhasznaloID",
                table: "Felhasznalo",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Felhasznalo",
                table: "Felhasznalo",
                column: "FelhasznaloID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Felhasznalo",
                table: "Felhasznalo");

            migrationBuilder.DropColumn(
                name: "FelhasznaloID",
                table: "Projekt");

            migrationBuilder.DropColumn(
                name: "ArucikkID",
                table: "Polc");

            migrationBuilder.DropColumn(
                name: "FelhasznaloID",
                table: "Felhasznalo");

            migrationBuilder.AlterColumn<string>(
                name: "ClientID",
                table: "Projekt",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "ProjectManagerID",
                table: "Projekt",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "itemName",
                table: "Polc",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Felhasznalo",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Felhasznalo",
                table: "Felhasznalo",
                column: "Name");
        }
    }
}
