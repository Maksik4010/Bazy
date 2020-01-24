using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication16.Data.Migrations
{
    public partial class timestamp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "haslo",
                table: "uzytkownicies",
                maxLength: 32,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<long>(
                name: "data_zalozenia",
                table: "uzytkownicies",
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "haslo",
                table: "uzytkownicies",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 32);

            migrationBuilder.AlterColumn<int>(
                name: "data_zalozenia",
                table: "uzytkownicies",
                nullable: false,
                oldClrType: typeof(long));
        }
    }
}
