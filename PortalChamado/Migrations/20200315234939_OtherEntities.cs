using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PortalChamado.Migrations
{
    public partial class OtherEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    Tipo = table.Column<string>(nullable: true),
                    Senha = table.Column<string>(nullable: true),
                    AcessoIdAcesso = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.IdUsuario);
                    table.ForeignKey(
                        name: "FK_Usuario_Acesso_AcessoIdAcesso",
                        column: x => x.AcessoIdAcesso,
                        principalTable: "Acesso",
                        principalColumn: "IdAcesso",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Chamado",
                columns: table => new
                {
                    IdChamado = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoginCriador = table.Column<int>(nullable: false),
                    Carteira = table.Column<int>(nullable: false),
                    Quantidade = table.Column<int>(nullable: false),
                    LoginTratamento = table.Column<int>(nullable: false),
                    Texto = table.Column<string>(nullable: true),
                    Assunto = table.Column<string>(nullable: true),
                    Importancia = table.Column<int>(nullable: false),
                    DataInicio = table.Column<DateTime>(nullable: false),
                    DataResposta = table.Column<DateTime>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    UsuarioIdUsuario = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chamado", x => x.IdChamado);
                    table.ForeignKey(
                        name: "FK_Chamado_Usuario_UsuarioIdUsuario",
                        column: x => x.UsuarioIdUsuario,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Chamado_UsuarioIdUsuario",
                table: "Chamado",
                column: "UsuarioIdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_AcessoIdAcesso",
                table: "Usuario",
                column: "AcessoIdAcesso");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Chamado");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
