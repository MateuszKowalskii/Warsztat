using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Warsztat_samochodowy.Migrations
{
    /// <inheritdoc />
    public partial class migration4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ZlecenieId",
                table: "pracownicy",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ZlecenieId",
                table: "czesci",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "zlecenia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    zleceniodawcaPESEL = table.Column<int>(type: "int", nullable: false),
                    oplata = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    dataWykonania = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    zakonczone = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_zlecenia", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_pracownicy_ZlecenieId",
                table: "pracownicy",
                column: "ZlecenieId");

            migrationBuilder.CreateIndex(
                name: "IX_czesci_ZlecenieId",
                table: "czesci",
                column: "ZlecenieId");

            migrationBuilder.AddForeignKey(
                name: "FK_czesci_zlecenia_ZlecenieId",
                table: "czesci",
                column: "ZlecenieId",
                principalTable: "zlecenia",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_pracownicy_zlecenia_ZlecenieId",
                table: "pracownicy",
                column: "ZlecenieId",
                principalTable: "zlecenia",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_czesci_zlecenia_ZlecenieId",
                table: "czesci");

            migrationBuilder.DropForeignKey(
                name: "FK_pracownicy_zlecenia_ZlecenieId",
                table: "pracownicy");

            migrationBuilder.DropTable(
                name: "zlecenia");

            migrationBuilder.DropIndex(
                name: "IX_pracownicy_ZlecenieId",
                table: "pracownicy");

            migrationBuilder.DropIndex(
                name: "IX_czesci_ZlecenieId",
                table: "czesci");

            migrationBuilder.DropColumn(
                name: "ZlecenieId",
                table: "pracownicy");

            migrationBuilder.DropColumn(
                name: "ZlecenieId",
                table: "czesci");
        }
    }
}
