using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Processos.Migrations
{
    /// <inheritdoc />
    public partial class P0001 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ANEXO_PROCESSO",
                columns: table => new
                {
                    codigoAnexo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codigoProcesso = table.Column<int>(type: "int", nullable: false),
                    dataHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    nomeAnexo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ANEXO_PROCESSO", x => x.codigoAnexo);
                });

            migrationBuilder.CreateTable(
                name: "FLUXO",
                columns: table => new
                {
                    codigoFluxo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codigoSetorOrigem = table.Column<int>(type: "int", nullable: false),
                    codigoSetorDestino = table.Column<int>(type: "int", nullable: false),
                    codigoTipoProcesso = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FLUXO", x => x.codigoFluxo);
                });

            migrationBuilder.CreateTable(
                name: "INTERESSADO",
                columns: table => new
                {
                    codigoInteressado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cpfCnpjInteressado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telefone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    logradouro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    numero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    complemento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bairro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    uf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pais = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cep = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INTERESSADO", x => x.codigoInteressado);
                });

            migrationBuilder.CreateTable(
                name: "MOVIMENTACAO",
                columns: table => new
                {
                    codigoMovimentacao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codigoProcesso = table.Column<int>(type: "int", nullable: false),
                    dataHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    cpfUsuarioTramite = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    codigoSetorLocalizacao = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MOVIMENTACAO", x => x.codigoMovimentacao);
                });

            migrationBuilder.CreateTable(
                name: "PROCESSO",
                columns: table => new
                {
                    codigoProcesso = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codigoInteressado = table.Column<int>(type: "int", nullable: false),
                    codigoTipoProcesso = table.Column<int>(type: "int", nullable: false),
                    cpfProtocolista = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    codigoSetor = table.Column<int>(type: "int", nullable: false),
                    dataHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    resumo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    assunto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    situacaoProcesso = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PROCESSO", x => x.codigoProcesso);
                });

            migrationBuilder.CreateTable(
                name: "SETOR",
                columns: table => new
                {
                    codigoSetor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SETOR", x => x.codigoSetor);
                });

            migrationBuilder.CreateTable(
                name: "TIPO_PROCESSO",
                columns: table => new
                {
                    codigoTipoProcesso = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nomeTipoProcesso = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TIPO_PROCESSO", x => x.codigoTipoProcesso);
                });

            migrationBuilder.CreateTable(
                name: "USUARIO",
                columns: table => new
                {
                    cpfUsuario = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    senha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    administrativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USUARIO", x => x.cpfUsuario);
                });

            migrationBuilder.CreateTable(
                name: "USUARIO_TEM_SETOR",
                columns: table => new
                {
                    sequencial = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cpfUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    codigoSetor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USUARIO_TEM_SETOR", x => x.sequencial);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ANEXO_PROCESSO");

            migrationBuilder.DropTable(
                name: "FLUXO");

            migrationBuilder.DropTable(
                name: "INTERESSADO");

            migrationBuilder.DropTable(
                name: "MOVIMENTACAO");

            migrationBuilder.DropTable(
                name: "PROCESSO");

            migrationBuilder.DropTable(
                name: "SETOR");

            migrationBuilder.DropTable(
                name: "TIPO_PROCESSO");

            migrationBuilder.DropTable(
                name: "USUARIO");

            migrationBuilder.DropTable(
                name: "USUARIO_TEM_SETOR");
        }
    }
}
