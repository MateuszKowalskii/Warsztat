using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Warsztat_samochodowy.Migrations
{
    /// <inheritdoc />
    public partial class migration3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "czesci",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    producent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    kod = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    nazwa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ilosc = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_czesci", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "zamowienia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dostawcaNazwa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    kod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nazwa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ilosc = table.Column<int>(type: "int", nullable: false),
                    kiedyDotrze = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_zamowienia", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_czesci_kod",
                table: "czesci",
                column: "kod",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "czesci");

            migrationBuilder.DropTable(
                name: "zamowienia");
        }
    }
}
