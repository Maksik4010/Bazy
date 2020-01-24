using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication16.Data.Migrations
{
    public partial class migration004 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_komentarze_posties_id_posty",
                table: "komentarze");

            migrationBuilder.DropForeignKey(
                name: "FK_posties_uzytkownicies_uzytkownicyid",
                table: "posties");

            migrationBuilder.DropIndex(
                name: "IX_komentarze_id_posty",
                table: "komentarze");

            migrationBuilder.DropColumn(
                name: "id_uzytkownika",
                table: "posties");

            migrationBuilder.RenameColumn(
                name: "uzytkownicyid",
                table: "posties",
                newName: "id_uzytkownikaid");

            migrationBuilder.RenameColumn(
                name: "id_posty",
                table: "posties",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_posties_uzytkownicyid",
                table: "posties",
                newName: "IX_posties_id_uzytkownikaid");

            migrationBuilder.AlterColumn<long>(
                name: "data_utworzenia",
                table: "posties",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "postyid",
                table: "komentarze",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_komentarze_postyid",
                table: "komentarze",
                column: "postyid");

            migrationBuilder.AddForeignKey(
                name: "FK_komentarze_posties_postyid",
                table: "komentarze",
                column: "postyid",
                principalTable: "posties",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_posties_uzytkownicies_id_uzytkownikaid",
                table: "posties",
                column: "id_uzytkownikaid",
                principalTable: "uzytkownicies",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_komentarze_posties_postyid",
                table: "komentarze");

            migrationBuilder.DropForeignKey(
                name: "FK_posties_uzytkownicies_id_uzytkownikaid",
                table: "posties");

            migrationBuilder.DropIndex(
                name: "IX_komentarze_postyid",
                table: "komentarze");

            migrationBuilder.DropColumn(
                name: "postyid",
                table: "komentarze");

            migrationBuilder.RenameColumn(
                name: "id_uzytkownikaid",
                table: "posties",
                newName: "uzytkownicyid");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "posties",
                newName: "id_posty");

            migrationBuilder.RenameIndex(
                name: "IX_posties_id_uzytkownikaid",
                table: "posties",
                newName: "IX_posties_uzytkownicyid");

            migrationBuilder.AlterColumn<int>(
                name: "data_utworzenia",
                table: "posties",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AddColumn<int>(
                name: "id_uzytkownika",
                table: "posties",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_komentarze_id_posty",
                table: "komentarze",
                column: "id_posty");

            migrationBuilder.AddForeignKey(
                name: "FK_komentarze_posties_id_posty",
                table: "komentarze",
                column: "id_posty",
                principalTable: "posties",
                principalColumn: "id_posty",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_posties_uzytkownicies_uzytkownicyid",
                table: "posties",
                column: "uzytkownicyid",
                principalTable: "uzytkownicies",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
