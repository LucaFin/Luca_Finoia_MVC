using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Luca_Finoia_MVC.RepositoryEF.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Studente_Menu_IdMenu",
                table: "Studente");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Studente",
                table: "Studente");

            migrationBuilder.RenameTable(
                name: "Studente",
                newName: "Piatto");

            migrationBuilder.RenameIndex(
                name: "IX_Studente_IdMenu",
                table: "Piatto",
                newName: "IX_Piatto_IdMenu");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Piatto",
                table: "Piatto",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Piatto_Menu_IdMenu",
                table: "Piatto",
                column: "IdMenu",
                principalTable: "Menu",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Piatto_Menu_IdMenu",
                table: "Piatto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Piatto",
                table: "Piatto");

            migrationBuilder.RenameTable(
                name: "Piatto",
                newName: "Studente");

            migrationBuilder.RenameIndex(
                name: "IX_Piatto_IdMenu",
                table: "Studente",
                newName: "IX_Studente_IdMenu");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Studente",
                table: "Studente",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Studente_Menu_IdMenu",
                table: "Studente",
                column: "IdMenu",
                principalTable: "Menu",
                principalColumn: "Id");
        }
    }
}
