using Microsoft.EntityFrameworkCore.Migrations;

namespace ImportSuperIntendencia.Migrations
{
    public partial class @float : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "PatrimonioTecnicoAjustado",
                table: "SC_SolvenciaComponentes",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<float>(
                name: "IndiceSolvencia",
                table: "SC_SolvenciaComponentes",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<float>(
                name: "CapitalRequeridoRiesgoMercado",
                table: "SC_SolvenciaComponentes",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<float>(
                name: "ActivosContingentesPonderadosRiesgosCreditíciosMercado",
                table: "SC_SolvenciaComponentes",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<float>(
                name: "ActivosContingentesPonderadosRiesgoCreditícioDeduccionesPatrimonio",
                table: "SC_SolvenciaComponentes",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "PatrimonioTecnicoAjustado",
                table: "SC_SolvenciaComponentes",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<decimal>(
                name: "IndiceSolvencia",
                table: "SC_SolvenciaComponentes",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<decimal>(
                name: "CapitalRequeridoRiesgoMercado",
                table: "SC_SolvenciaComponentes",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<decimal>(
                name: "ActivosContingentesPonderadosRiesgosCreditíciosMercado",
                table: "SC_SolvenciaComponentes",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<decimal>(
                name: "ActivosContingentesPonderadosRiesgoCreditícioDeduccionesPatrimonio",
                table: "SC_SolvenciaComponentes",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(float));
        }
    }
}
