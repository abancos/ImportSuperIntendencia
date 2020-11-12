using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ImportSuperIntendencia.Migrations
{
    public partial class addSC_SolvenciaComponentes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SC_SolvenciaComponentes",
                columns: table => new
                {
                    Fecha = table.Column<DateTime>(nullable: false),
                    PatrimonioTecnicoAjustado = table.Column<decimal>(nullable: false),
                    ActivosContingentesPonderados = table.Column<decimal>(nullable: false),
                    CapitalRequeridoRiesgoMercado = table.Column<decimal>(nullable: false),
                    IndiceSolvencia = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SC_SolvenciaComponentes", x => x.Fecha);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SC_SolvenciaComponentes");
        }
    }
}
