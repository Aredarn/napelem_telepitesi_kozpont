using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace napelem_telepito_kozpont.Migrations
{
    /// <inheritdoc />
    public partial class mssqllocal_migration_714 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Arucikk",
                columns: table => new
                {
                    Arucikknev = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    MaxOnShelf = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arucikk", x => x.Arucikknev);
                });

            migrationBuilder.CreateTable(
                name: "Felhasznalo",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Felhasznalo", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "projectStatuszok",
                columns: table => new
                {
                    StateID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectID = table.Column<int>(type: "int", nullable: false),
                    StatusID = table.Column<int>(type: "int", nullable: false),
                    FazisKezdete = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_projectStatuszok", x => x.StateID);
                });

            migrationBuilder.CreateTable(
                name: "Projekt",
                columns: table => new
                {
                    ProjectID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectManagerID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApproxTimeToFinish = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ApproxCost = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projekt", x => x.ProjectID);
                });

            migrationBuilder.CreateTable(
                name: "ProjektekArucikkhez",
                columns: table => new
                {
                    ProjectToItemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    IsReserved = table.Column<bool>(type: "bit", nullable: false),
                    ProjectID = table.Column<int>(type: "int", nullable: false),
                    Arucikknev = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjektekArucikkhez", x => x.ProjectToItemID);
                });

            migrationBuilder.CreateTable(
                name: "Státusz",
                columns: table => new
                {
                    StatusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusInfo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Státusz", x => x.StatusID);
                });

            migrationBuilder.CreateTable(
                name: "ujArucikkIgeny",
                columns: table => new
                {
                    AruIgenyID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AruNev = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mennyiseg = table.Column<int>(type: "int", nullable: false),
                    ProjectID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ujArucikkIgeny", x => x.AruIgenyID);
                });

            migrationBuilder.CreateTable(
                name: "Polc",
                columns: table => new
                {
                    ShelfID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Row = table.Column<int>(type: "int", nullable: false),
                    Column = table.Column<int>(type: "int", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    ItemsInShelf = table.Column<int>(type: "int", nullable: false),
                    ItemName = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Polc", x => x.ShelfID);
                    table.ForeignKey(
                        name: "FK_Polc_Arucikk_ItemName",
                        column: x => x.ItemName,
                        principalTable: "Arucikk",
                        principalColumn: "Arucikknev");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Polc_ItemName",
                table: "Polc",
                column: "ItemName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Felhasznalo");

            migrationBuilder.DropTable(
                name: "Polc");

            migrationBuilder.DropTable(
                name: "projectStatuszok");

            migrationBuilder.DropTable(
                name: "Projekt");

            migrationBuilder.DropTable(
                name: "ProjektekArucikkhez");

            migrationBuilder.DropTable(
                name: "Státusz");

            migrationBuilder.DropTable(
                name: "ujArucikkIgeny");

            migrationBuilder.DropTable(
                name: "Arucikk");
        }
    }
}
