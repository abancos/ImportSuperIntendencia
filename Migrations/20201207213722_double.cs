using Microsoft.EntityFrameworkCore.Migrations;

namespace ImportSuperIntendencia.Migrations
{
    public partial class @double : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "PatrimonioTecnicoAjustado",
                table: "SC_SolvenciaComponentes",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<double>(
                name: "IndiceSolvencia",
                table: "SC_SolvenciaComponentes",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<double>(
                name: "CapitalRequeridoRiesgoMercado",
                table: "SC_SolvenciaComponentes",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<double>(
                name: "ActivosContingentesPonderadosRiesgosCreditíciosMercado",
                table: "SC_SolvenciaComponentes",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<double>(
                name: "ActivosContingentesPonderadosRiesgoCreditícioDeduccionesPatrimonio",
                table: "SC_SolvenciaComponentes",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "PatrimonioTecnicoAjustado",
                table: "SC_SolvenciaComponentes",
                type: "real",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<float>(
                name: "IndiceSolvencia",
                table: "SC_SolvenciaComponentes",
                type: "real",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<float>(
                name: "CapitalRequeridoRiesgoMercado",
                table: "SC_SolvenciaComponentes",
                type: "real",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<float>(
                name: "ActivosContingentesPonderadosRiesgosCreditíciosMercado",
                table: "SC_SolvenciaComponentes",
                type: "real",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<float>(
                name: "ActivosContingentesPonderadosRiesgoCreditícioDeduccionesPatrimonio",
                table: "SC_SolvenciaComponentes",
                type: "real",
                nullable: false,
                oldClrType: typeof(double));
        }
    }
}
