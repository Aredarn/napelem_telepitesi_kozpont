using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace napelem_telepito_kozpont.Migrations
{
    /// <inheritdoc />
    public partial class Create : Migration
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
                    Password = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Felhasznalo", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Projekt",
                columns: table => new
                {
                    ProjectID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projekt", x => x.ProjectID);
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

            migrationBuilder.CreateTable(
                name: "ProjektekArucikkhez",
                columns: table => new
                {
                    ProjectToItemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    IsReserved = table.Column<bool>(type: "bit", nullable: false),
                    ProjectID = table.Column<int>(type: "int", nullable: false),
                    Arucikknev = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjektekArucikkhez", x => x.ProjectToItemID);
                    table.ForeignKey(
                        name: "FK_ProjektekArucikkhez_Arucikk_Arucikknev",
                        column: x => x.Arucikknev,
                        principalTable: "Arucikk",
                        principalColumn: "Arucikknev");
                    table.ForeignKey(
                        name: "FK_ProjektekArucikkhez_Projekt_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Projekt",
                        principalColumn: "ProjectID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Polc_ItemName",
                table: "Polc",
                column: "ItemName");

            migrationBuilder.CreateIndex(
                name: "IX_ProjektekArucikkhez_Arucikknev",
                table: "ProjektekArucikkhez",
                column: "Arucikknev");

            migrationBuilder.CreateIndex(
                name: "IX_ProjektekArucikkhez_ProjectID",
                table: "ProjektekArucikkhez",
                column: "ProjectID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Felhasznalo");

            migrationBuilder.DropTable(
                name: "Polc");

            migrationBuilder.DropTable(
                name: "ProjektekArucikkhez");

            migrationBuilder.DropTable(
                name: "Státusz");

            migrationBuilder.DropTable(
                name: "Arucikk");

            migrationBuilder.DropTable(
                name: "Projekt");
        }
    }
}
