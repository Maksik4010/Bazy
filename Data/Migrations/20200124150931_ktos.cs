using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication16.Data.Migrations
{
    public partial class ktos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_posties_uzytkownicies_id_uzytkownikaid",
                table: "posties");

            migrationBuilder.RenameColumn(
                name: "id_uzytkownikaid",
                table: "posties",
                newName: "uzytkownicyid");

            migrationBuilder.RenameIndex(
                name: "IX_posties_id_uzytkownikaid",
                table: "posties",
                newName: "IX_posties_uzytkownicyid");

            migrationBuilder.AlterColumn<string>(
                name: "tresc",
                table: "posties",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "id_uzytkownika",
                table: "posties",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_posties_uzytkownicies_uzytkownicyid",
                table: "posties",
                column: "uzytkownicyid",
                principalTable: "uzytkownicies",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_posties_uzytkownicies_uzytkownicyid",
                table: "posties");

            migrationBuilder.DropColumn(
                name: "id_uzytkownika",
                table: "posties");

            migrationBuilder.RenameColumn(
                name: "uzytkownicyid",
                table: "posties",
                newName: "id_uzytkownikaid");

            migrationBuilder.RenameIndex(
                name: "IX_posties_uzytkownicyid",
                table: "posties",
                newName: "IX_posties_id_uzytkownikaid");

            migrationBuilder.AlterColumn<string>(
                name: "tresc",
                table: "posties",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddForeignKey(
                name: "FK_posties_uzytkownicies_id_uzytkownikaid",
                table: "posties",
                column: "id_uzytkownikaid",
                principalTable: "uzytkownicies",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
