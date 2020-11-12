using Microsoft.EntityFrameworkCore.Migrations;

namespace ImportSuperIntendencia.Migrations
{
    public partial class addSC_SolvenciaComponentes2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActivosContingentesPonderados",
                table: "SC_SolvenciaComponentes");

            migrationBuilder.AddColumn<decimal>(
                name: "ActivosContingentesPonderadosRiesgoCreditícioDeduccionesPatrimonio",
                table: "SC_SolvenciaComponentes",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ActivosContingentesPonderadosRiesgosCreditíciosMercado",
                table: "SC_SolvenciaComponentes",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActivosContingentesPonderadosRiesgoCreditícioDeduccionesPatrimonio",
                table: "SC_SolvenciaComponentes");

            migrationBuilder.DropColumn(
                name: "ActivosContingentesPonderadosRiesgosCreditíciosMercado",
                table: "SC_SolvenciaComponentes");

            migrationBuilder.AddColumn<decimal>(
                name: "ActivosContingentesPonderados",
                table: "SC_SolvenciaComponentes",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
