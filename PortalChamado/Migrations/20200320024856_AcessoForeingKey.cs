using Microsoft.EntityFrameworkCore.Migrations;

namespace PortalChamado.Migrations
{
    public partial class AcessoForeingKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdAcesso",
                table: "Usuario",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdAcesso",
                table: "Usuario");
        }
    }
}
