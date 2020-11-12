using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ImportSuperIntendencia.Migrations
{
    public partial class addIF_Gestion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IF_Gestion",
                columns: table => new
                {
                    Fecha = table.Column<DateTime>(nullable: false),
                    TotalGastosGeneralesAdministrativosTotalCaptaciones = table.Column<decimal>(nullable: false),
                    GastosExplotacionMargenOperacionalBruto = table.Column<decimal>(nullable: false),
                    GastosFinancierosCaptacionesCaptacionesCosto = table.Column<decimal>(nullable: false),
                    GastosFinancierosTotalCaptacionesObligCosto = table.Column<decimal>(nullable: false),
                    GastosFinancierosCaptacionesCostosObligacionesCosto = table.Column<decimal>(nullable: false),
                    TotalGastosGeneralesAdministTotalCaptacionesObligCosto = table.Column<decimal>(nullable: false),
                    GastosFinancierosActivosProductivosCE = table.Column<decimal>(nullable: false),
                    GastosFinancierosActivosFinancierosCF = table.Column<decimal>(nullable: false),
                    GastosFinancierosIngresosFinancieros = table.Column<decimal>(nullable: false),
                    GastosOperacionalesIngresosOperacionalesBrutos = table.Column<decimal>(nullable: false),
                    TotalGastosGeneralesAdministrativosActivosTotales = table.Column<decimal>(nullable: false),
                    GastosExplotacionActivosProductivos = table.Column<decimal>(nullable: false),
                    GastoPersonalGastosExplotacion = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IF_Gestion", x => x.Fecha);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IF_Gestion");
        }
    }
}
