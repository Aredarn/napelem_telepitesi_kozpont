using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace napelem_telepito_kozpont.Migrations
{
    /// <inheritdoc />
    public partial class mssqllocal_migration_224 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Polc_Arucikk_ItemName",
                table: "Polc");

            migrationBuilder.DropIndex(
                name: "IX_Polc_ItemName",
                table: "Polc");

            migrationBuilder.RenameColumn(
                name: "ItemName",
                table: "Polc",
                newName: "itemName");

            migrationBuilder.AlterColumn<string>(
                name: "itemName",
                table: "Polc",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Megrendelok",
                columns: table => new
                {
                    ClientID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phoneNum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Megrendelok", x => x.ClientID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Megrendelok");

            migrationBuilder.RenameColumn(
                name: "itemName",
                table: "Polc",
                newName: "ItemName");

            migrationBuilder.AlterColumn<string>(
                name: "ItemName",
                table: "Polc",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Polc_ItemName",
                table: "Polc",
                column: "ItemName");

            migrationBuilder.AddForeignKey(
                name: "FK_Polc_Arucikk_ItemName",
                table: "Polc",
                column: "ItemName",
                principalTable: "Arucikk",
                principalColumn: "Arucikknev");
        }
    }
}
