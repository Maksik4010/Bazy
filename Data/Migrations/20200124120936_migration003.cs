using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication16.Data.Migrations
{
    public partial class migration003 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id_zuytkownicy",
                table: "posties",
                newName: "id_uzytkownika");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id_uzytkownika",
                table: "posties",
                newName: "id_zuytkownicy");
        }
    }
}
