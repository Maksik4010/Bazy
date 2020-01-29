using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication16.Data.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "tresc",
                table: "posties",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "tresc",
                table: "posties",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
