using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PortalIT.Data.Migrations
{
    public partial class terceira : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "TempoDeDuracao",
                table: "Curso",
                nullable: true,
                oldClrType: typeof(DateTime));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "TempoDeDuracao",
                table: "Curso",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);
        }
    }
}
