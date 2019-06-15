using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PortalIT.Data.Migrations
{
    public partial class novarelacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CursoId",
                table: "Departamento",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "TempoDeDuracao",
                table: "Curso",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Curso",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Curso",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Departamento_CursoId",
                table: "Departamento",
                column: "CursoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Departamento_Curso_CursoId",
                table: "Departamento",
                column: "CursoId",
                principalTable: "Curso",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departamento_Curso_CursoId",
                table: "Departamento");

            migrationBuilder.DropIndex(
                name: "IX_Departamento_CursoId",
                table: "Departamento");

            migrationBuilder.DropColumn(
                name: "CursoId",
                table: "Departamento");

            migrationBuilder.AlterColumn<DateTime>(
                name: "TempoDeDuracao",
                table: "Curso",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Curso",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Curso",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
