using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Warsztat_samochodowy.Migrations
{
    /// <inheritdoc />
    public partial class migration7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_czesci_zlecenia_ZlecenieId",
                table: "czesci");

            migrationBuilder.DropIndex(
                name: "IX_czesci_ZlecenieId",
                table: "czesci");

            migrationBuilder.DropColumn(
                name: "ZlecenieId",
                table: "czesci");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "ZlecenieId",
                table: "czesci",
                type: "int",
                nullable: true);

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
        }
    }
}
