using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Warsztat_samochodowy.Migrations
{
    /// <inheritdoc />
    public partial class migration8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_pracownicy_zlecenia_ZlecenieId",
                table: "pracownicy");

            migrationBuilder.DropIndex(
                name: "IX_pracownicy_ZlecenieId",
                table: "pracownicy");

            migrationBuilder.DropColumn(
                name: "ZlecenieId",
                table: "pracownicy");

            migrationBuilder.CreateTable(
                name: "PracownikZlecenie",
                columns: table => new
                {
                    pracownicyId = table.Column<int>(type: "int", nullable: false),
                    zleceniaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PracownikZlecenie", x => new { x.pracownicyId, x.zleceniaId });
                    table.ForeignKey(
                        name: "FK_PracownikZlecenie_pracownicy_pracownicyId",
                        column: x => x.pracownicyId,
                        principalTable: "pracownicy",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PracownikZlecenie_zlecenia_zleceniaId",
                        column: x => x.zleceniaId,
                        principalTable: "zlecenia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PracownikZlecenie_zleceniaId",
                table: "PracownikZlecenie",
                column: "zleceniaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PracownikZlecenie");

            migrationBuilder.AddColumn<int>(
                name: "ZlecenieId",
                table: "pracownicy",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_pracownicy_ZlecenieId",
                table: "pracownicy",
                column: "ZlecenieId");

            migrationBuilder.AddForeignKey(
                name: "FK_pracownicy_zlecenia_ZlecenieId",
                table: "pracownicy",
                column: "ZlecenieId",
                principalTable: "zlecenia",
                principalColumn: "Id");
        }
    }
}
