using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Processos.Migrations
{
    /// <inheritdoc />
    public partial class M0001 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TIPO_PROCESSO");
        }
    }
}
