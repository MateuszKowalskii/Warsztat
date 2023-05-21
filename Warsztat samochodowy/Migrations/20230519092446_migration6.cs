using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Warsztat_samochodowy.Migrations
{
    /// <inheritdoc />
    public partial class migration6 : Migration
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
