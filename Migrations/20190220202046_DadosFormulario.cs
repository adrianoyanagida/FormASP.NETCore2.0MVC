using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FormularioTeste.Migrations
{
    public partial class DadosFormulario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DadosFormularios",
                columns: table => new
                {
                    DadosFormularioId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FormularioId = table.Column<int>(nullable: false),
                    NomeDoProprietario = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DadosFormularios", x => x.DadosFormularioId);
                    table.ForeignKey(
                        name: "FK_DadosFormularios_Formularios_FormularioId",
                        column: x => x.FormularioId,
                        principalTable: "Formularios",
                        principalColumn: "FormularioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DadosFormularios_FormularioId",
                table: "DadosFormularios",
                column: "FormularioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DadosFormularios");
        }
    }
}
