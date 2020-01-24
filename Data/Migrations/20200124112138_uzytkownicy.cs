using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication16.Data.Migrations
{
    public partial class uzytkownicy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_fanpages_uzytkownicies_id_uzytkownicy",
                table: "fanpages");

            migrationBuilder.DropForeignKey(
                name: "FK_filmies_uzytkownicies_id_uzytkownicy",
                table: "filmies");

            migrationBuilder.DropForeignKey(
                name: "FK_grupy_Dyskusyjnes_uzytkownicies_id_uzytkownicy",
                table: "grupy_Dyskusyjnes");

            migrationBuilder.DropForeignKey(
                name: "FK_komentarze_uzytkownicies_id_uzytkownicy",
                table: "komentarze");

            migrationBuilder.DropForeignKey(
                name: "FK_plikis_uzytkownicies_id_uzytkownicy",
                table: "plikis");

            migrationBuilder.DropForeignKey(
                name: "FK_posties_uzytkownicies_uzytkownicyId_uzytkownicy",
                table: "posties");

            migrationBuilder.DropForeignKey(
                name: "FK_reakcja_Na_Posties_uzytkownicies_id_uzytkownicy",
                table: "reakcja_Na_Posties");

            migrationBuilder.DropForeignKey(
                name: "FK_wiadomoscis_uzytkownicies_id_uzytkownicy",
                table: "wiadomoscis");

            migrationBuilder.DropForeignKey(
                name: "FK_zainteresowanias_uzytkownicies_id_uzytkownicy",
                table: "zainteresowanias");

            migrationBuilder.DropForeignKey(
                name: "FK_zaproszenia_Do_Znajomyches_uzytkownicies_id_uzytkownicy",
                table: "zaproszenia_Do_Znajomyches");

            migrationBuilder.DropForeignKey(
                name: "FK_zdjecias_uzytkownicies_uzytkownicyId_uzytkownicy",
                table: "zdjecias");

            migrationBuilder.DropForeignKey(
                name: "FK_znajomis_uzytkownicies_Id_uzytkownicy",
                table: "znajomis");

            migrationBuilder.DropIndex(
                name: "IX_znajomis_Id_uzytkownicy",
                table: "znajomis");

            migrationBuilder.DropIndex(
                name: "IX_zaproszenia_Do_Znajomyches_id_uzytkownicy",
                table: "zaproszenia_Do_Znajomyches");

            migrationBuilder.DropIndex(
                name: "IX_zainteresowanias_id_uzytkownicy",
                table: "zainteresowanias");

            migrationBuilder.DropIndex(
                name: "IX_wiadomoscis_id_uzytkownicy",
                table: "wiadomoscis");

            migrationBuilder.DropIndex(
                name: "IX_reakcja_Na_Posties_id_uzytkownicy",
                table: "reakcja_Na_Posties");

            migrationBuilder.DropIndex(
                name: "IX_plikis_id_uzytkownicy",
                table: "plikis");

            migrationBuilder.DropIndex(
                name: "IX_komentarze_id_uzytkownicy",
                table: "komentarze");

            migrationBuilder.DropIndex(
                name: "IX_grupy_Dyskusyjnes_id_uzytkownicy",
                table: "grupy_Dyskusyjnes");

            migrationBuilder.DropIndex(
                name: "IX_filmies_id_uzytkownicy",
                table: "filmies");

            migrationBuilder.DropIndex(
                name: "IX_fanpages_id_uzytkownicy",
                table: "fanpages");

            migrationBuilder.RenameColumn(
                name: "uzytkownicyId_uzytkownicy",
                table: "zdjecias",
                newName: "uzytkownicyid");

            migrationBuilder.RenameIndex(
                name: "IX_zdjecias_uzytkownicyId_uzytkownicy",
                table: "zdjecias",
                newName: "IX_zdjecias_uzytkownicyid");

            migrationBuilder.RenameColumn(
                name: "Id_uzytkownicy",
                table: "uzytkownicies",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "uzytkownicyId_uzytkownicy",
                table: "posties",
                newName: "uzytkownicyid");

            migrationBuilder.RenameIndex(
                name: "IX_posties_uzytkownicyId_uzytkownicy",
                table: "posties",
                newName: "IX_posties_uzytkownicyid");

            migrationBuilder.AddColumn<int>(
                name: "uzytkownicyid",
                table: "znajomis",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "uzytkownicyid",
                table: "zaproszenia_Do_Znajomyches",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "uzytkownicyid",
                table: "zainteresowanias",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "uzytkownicyid",
                table: "wiadomoscis",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nazwisko",
                table: "uzytkownicies",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "login",
                table: "uzytkownicies",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ksywka",
                table: "uzytkownicies",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "kraj",
                table: "uzytkownicies",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "imie",
                table: "uzytkownicies",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "haslo",
                table: "uzytkownicies",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "uzytkownicyid",
                table: "reakcja_Na_Posties",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "uzytkownicyid",
                table: "plikis",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "uzytkownicyid",
                table: "komentarze",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "uzytkownicyid",
                table: "grupy_Dyskusyjnes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "uzytkownicyid",
                table: "filmies",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "uzytkownicyid",
                table: "fanpages",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_znajomis_uzytkownicyid",
                table: "znajomis",
                column: "uzytkownicyid");

            migrationBuilder.CreateIndex(
                name: "IX_zaproszenia_Do_Znajomyches_uzytkownicyid",
                table: "zaproszenia_Do_Znajomyches",
                column: "uzytkownicyid");

            migrationBuilder.CreateIndex(
                name: "IX_zainteresowanias_uzytkownicyid",
                table: "zainteresowanias",
                column: "uzytkownicyid");

            migrationBuilder.CreateIndex(
                name: "IX_wiadomoscis_uzytkownicyid",
                table: "wiadomoscis",
                column: "uzytkownicyid");

            migrationBuilder.CreateIndex(
                name: "IX_reakcja_Na_Posties_uzytkownicyid",
                table: "reakcja_Na_Posties",
                column: "uzytkownicyid");

            migrationBuilder.CreateIndex(
                name: "IX_plikis_uzytkownicyid",
                table: "plikis",
                column: "uzytkownicyid");

            migrationBuilder.CreateIndex(
                name: "IX_komentarze_uzytkownicyid",
                table: "komentarze",
                column: "uzytkownicyid");

            migrationBuilder.CreateIndex(
                name: "IX_grupy_Dyskusyjnes_uzytkownicyid",
                table: "grupy_Dyskusyjnes",
                column: "uzytkownicyid");

            migrationBuilder.CreateIndex(
                name: "IX_filmies_uzytkownicyid",
                table: "filmies",
                column: "uzytkownicyid");

            migrationBuilder.CreateIndex(
                name: "IX_fanpages_uzytkownicyid",
                table: "fanpages",
                column: "uzytkownicyid");

            migrationBuilder.AddForeignKey(
                name: "FK_fanpages_uzytkownicies_uzytkownicyid",
                table: "fanpages",
                column: "uzytkownicyid",
                principalTable: "uzytkownicies",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_filmies_uzytkownicies_uzytkownicyid",
                table: "filmies",
                column: "uzytkownicyid",
                principalTable: "uzytkownicies",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_grupy_Dyskusyjnes_uzytkownicies_uzytkownicyid",
                table: "grupy_Dyskusyjnes",
                column: "uzytkownicyid",
                principalTable: "uzytkownicies",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_komentarze_uzytkownicies_uzytkownicyid",
                table: "komentarze",
                column: "uzytkownicyid",
                principalTable: "uzytkownicies",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_plikis_uzytkownicies_uzytkownicyid",
                table: "plikis",
                column: "uzytkownicyid",
                principalTable: "uzytkownicies",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_posties_uzytkownicies_uzytkownicyid",
                table: "posties",
                column: "uzytkownicyid",
                principalTable: "uzytkownicies",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_reakcja_Na_Posties_uzytkownicies_uzytkownicyid",
                table: "reakcja_Na_Posties",
                column: "uzytkownicyid",
                principalTable: "uzytkownicies",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_wiadomoscis_uzytkownicies_uzytkownicyid",
                table: "wiadomoscis",
                column: "uzytkownicyid",
                principalTable: "uzytkownicies",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_zainteresowanias_uzytkownicies_uzytkownicyid",
                table: "zainteresowanias",
                column: "uzytkownicyid",
                principalTable: "uzytkownicies",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_zaproszenia_Do_Znajomyches_uzytkownicies_uzytkownicyid",
                table: "zaproszenia_Do_Znajomyches",
                column: "uzytkownicyid",
                principalTable: "uzytkownicies",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_zdjecias_uzytkownicies_uzytkownicyid",
                table: "zdjecias",
                column: "uzytkownicyid",
                principalTable: "uzytkownicies",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_znajomis_uzytkownicies_uzytkownicyid",
                table: "znajomis",
                column: "uzytkownicyid",
                principalTable: "uzytkownicies",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_fanpages_uzytkownicies_uzytkownicyid",
                table: "fanpages");

            migrationBuilder.DropForeignKey(
                name: "FK_filmies_uzytkownicies_uzytkownicyid",
                table: "filmies");

            migrationBuilder.DropForeignKey(
                name: "FK_grupy_Dyskusyjnes_uzytkownicies_uzytkownicyid",
                table: "grupy_Dyskusyjnes");

            migrationBuilder.DropForeignKey(
                name: "FK_komentarze_uzytkownicies_uzytkownicyid",
                table: "komentarze");

            migrationBuilder.DropForeignKey(
                name: "FK_plikis_uzytkownicies_uzytkownicyid",
                table: "plikis");

            migrationBuilder.DropForeignKey(
                name: "FK_posties_uzytkownicies_uzytkownicyid",
                table: "posties");

            migrationBuilder.DropForeignKey(
                name: "FK_reakcja_Na_Posties_uzytkownicies_uzytkownicyid",
                table: "reakcja_Na_Posties");

            migrationBuilder.DropForeignKey(
                name: "FK_wiadomoscis_uzytkownicies_uzytkownicyid",
                table: "wiadomoscis");

            migrationBuilder.DropForeignKey(
                name: "FK_zainteresowanias_uzytkownicies_uzytkownicyid",
                table: "zainteresowanias");

            migrationBuilder.DropForeignKey(
                name: "FK_zaproszenia_Do_Znajomyches_uzytkownicies_uzytkownicyid",
                table: "zaproszenia_Do_Znajomyches");

            migrationBuilder.DropForeignKey(
                name: "FK_zdjecias_uzytkownicies_uzytkownicyid",
                table: "zdjecias");

            migrationBuilder.DropForeignKey(
                name: "FK_znajomis_uzytkownicies_uzytkownicyid",
                table: "znajomis");

            migrationBuilder.DropIndex(
                name: "IX_znajomis_uzytkownicyid",
                table: "znajomis");

            migrationBuilder.DropIndex(
                name: "IX_zaproszenia_Do_Znajomyches_uzytkownicyid",
                table: "zaproszenia_Do_Znajomyches");

            migrationBuilder.DropIndex(
                name: "IX_zainteresowanias_uzytkownicyid",
                table: "zainteresowanias");

            migrationBuilder.DropIndex(
                name: "IX_wiadomoscis_uzytkownicyid",
                table: "wiadomoscis");

            migrationBuilder.DropIndex(
                name: "IX_reakcja_Na_Posties_uzytkownicyid",
                table: "reakcja_Na_Posties");

            migrationBuilder.DropIndex(
                name: "IX_plikis_uzytkownicyid",
                table: "plikis");

            migrationBuilder.DropIndex(
                name: "IX_komentarze_uzytkownicyid",
                table: "komentarze");

            migrationBuilder.DropIndex(
                name: "IX_grupy_Dyskusyjnes_uzytkownicyid",
                table: "grupy_Dyskusyjnes");

            migrationBuilder.DropIndex(
                name: "IX_filmies_uzytkownicyid",
                table: "filmies");

            migrationBuilder.DropIndex(
                name: "IX_fanpages_uzytkownicyid",
                table: "fanpages");

            migrationBuilder.DropColumn(
                name: "uzytkownicyid",
                table: "znajomis");

            migrationBuilder.DropColumn(
                name: "uzytkownicyid",
                table: "zaproszenia_Do_Znajomyches");

            migrationBuilder.DropColumn(
                name: "uzytkownicyid",
                table: "zainteresowanias");

            migrationBuilder.DropColumn(
                name: "uzytkownicyid",
                table: "wiadomoscis");

            migrationBuilder.DropColumn(
                name: "uzytkownicyid",
                table: "reakcja_Na_Posties");

            migrationBuilder.DropColumn(
                name: "uzytkownicyid",
                table: "plikis");

            migrationBuilder.DropColumn(
                name: "uzytkownicyid",
                table: "komentarze");

            migrationBuilder.DropColumn(
                name: "uzytkownicyid",
                table: "grupy_Dyskusyjnes");

            migrationBuilder.DropColumn(
                name: "uzytkownicyid",
                table: "filmies");

            migrationBuilder.DropColumn(
                name: "uzytkownicyid",
                table: "fanpages");

            migrationBuilder.RenameColumn(
                name: "uzytkownicyid",
                table: "zdjecias",
                newName: "uzytkownicyId_uzytkownicy");

            migrationBuilder.RenameIndex(
                name: "IX_zdjecias_uzytkownicyid",
                table: "zdjecias",
                newName: "IX_zdjecias_uzytkownicyId_uzytkownicy");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "uzytkownicies",
                newName: "Id_uzytkownicy");

            migrationBuilder.RenameColumn(
                name: "uzytkownicyid",
                table: "posties",
                newName: "uzytkownicyId_uzytkownicy");

            migrationBuilder.RenameIndex(
                name: "IX_posties_uzytkownicyid",
                table: "posties",
                newName: "IX_posties_uzytkownicyId_uzytkownicy");

            migrationBuilder.AlterColumn<string>(
                name: "nazwisko",
                table: "uzytkownicies",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "login",
                table: "uzytkownicies",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ksywka",
                table: "uzytkownicies",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "kraj",
                table: "uzytkownicies",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "imie",
                table: "uzytkownicies",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "haslo",
                table: "uzytkownicies",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.CreateIndex(
                name: "IX_znajomis_Id_uzytkownicy",
                table: "znajomis",
                column: "Id_uzytkownicy");

            migrationBuilder.CreateIndex(
                name: "IX_zaproszenia_Do_Znajomyches_id_uzytkownicy",
                table: "zaproszenia_Do_Znajomyches",
                column: "id_uzytkownicy");

            migrationBuilder.CreateIndex(
                name: "IX_zainteresowanias_id_uzytkownicy",
                table: "zainteresowanias",
                column: "id_uzytkownicy");

            migrationBuilder.CreateIndex(
                name: "IX_wiadomoscis_id_uzytkownicy",
                table: "wiadomoscis",
                column: "id_uzytkownicy");

            migrationBuilder.CreateIndex(
                name: "IX_reakcja_Na_Posties_id_uzytkownicy",
                table: "reakcja_Na_Posties",
                column: "id_uzytkownicy");

            migrationBuilder.CreateIndex(
                name: "IX_plikis_id_uzytkownicy",
                table: "plikis",
                column: "id_uzytkownicy");

            migrationBuilder.CreateIndex(
                name: "IX_komentarze_id_uzytkownicy",
                table: "komentarze",
                column: "id_uzytkownicy");

            migrationBuilder.CreateIndex(
                name: "IX_grupy_Dyskusyjnes_id_uzytkownicy",
                table: "grupy_Dyskusyjnes",
                column: "id_uzytkownicy");

            migrationBuilder.CreateIndex(
                name: "IX_filmies_id_uzytkownicy",
                table: "filmies",
                column: "id_uzytkownicy");

            migrationBuilder.CreateIndex(
                name: "IX_fanpages_id_uzytkownicy",
                table: "fanpages",
                column: "id_uzytkownicy");

            migrationBuilder.AddForeignKey(
                name: "FK_fanpages_uzytkownicies_id_uzytkownicy",
                table: "fanpages",
                column: "id_uzytkownicy",
                principalTable: "uzytkownicies",
                principalColumn: "Id_uzytkownicy",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_filmies_uzytkownicies_id_uzytkownicy",
                table: "filmies",
                column: "id_uzytkownicy",
                principalTable: "uzytkownicies",
                principalColumn: "Id_uzytkownicy",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_grupy_Dyskusyjnes_uzytkownicies_id_uzytkownicy",
                table: "grupy_Dyskusyjnes",
                column: "id_uzytkownicy",
                principalTable: "uzytkownicies",
                principalColumn: "Id_uzytkownicy",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_komentarze_uzytkownicies_id_uzytkownicy",
                table: "komentarze",
                column: "id_uzytkownicy",
                principalTable: "uzytkownicies",
                principalColumn: "Id_uzytkownicy",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_plikis_uzytkownicies_id_uzytkownicy",
                table: "plikis",
                column: "id_uzytkownicy",
                principalTable: "uzytkownicies",
                principalColumn: "Id_uzytkownicy",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_posties_uzytkownicies_uzytkownicyId_uzytkownicy",
                table: "posties",
                column: "uzytkownicyId_uzytkownicy",
                principalTable: "uzytkownicies",
                principalColumn: "Id_uzytkownicy",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_reakcja_Na_Posties_uzytkownicies_id_uzytkownicy",
                table: "reakcja_Na_Posties",
                column: "id_uzytkownicy",
                principalTable: "uzytkownicies",
                principalColumn: "Id_uzytkownicy",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_wiadomoscis_uzytkownicies_id_uzytkownicy",
                table: "wiadomoscis",
                column: "id_uzytkownicy",
                principalTable: "uzytkownicies",
                principalColumn: "Id_uzytkownicy",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_zainteresowanias_uzytkownicies_id_uzytkownicy",
                table: "zainteresowanias",
                column: "id_uzytkownicy",
                principalTable: "uzytkownicies",
                principalColumn: "Id_uzytkownicy",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_zaproszenia_Do_Znajomyches_uzytkownicies_id_uzytkownicy",
                table: "zaproszenia_Do_Znajomyches",
                column: "id_uzytkownicy",
                principalTable: "uzytkownicies",
                principalColumn: "Id_uzytkownicy",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_zdjecias_uzytkownicies_uzytkownicyId_uzytkownicy",
                table: "zdjecias",
                column: "uzytkownicyId_uzytkownicy",
                principalTable: "uzytkownicies",
                principalColumn: "Id_uzytkownicy",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_znajomis_uzytkownicies_Id_uzytkownicy",
                table: "znajomis",
                column: "Id_uzytkownicy",
                principalTable: "uzytkownicies",
                principalColumn: "Id_uzytkownicy",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
