using Microsoft.EntityFrameworkCore.Migrations;

namespace ClassroomHub.Data.Migrations
{
    public partial class Modificado_campo_email__em_Professor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Teachers");

            migrationBuilder.AddColumn<string>(
                name: "Especializacao",
                table: "Teachers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Especializacao",
                table: "Teachers");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Teachers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
