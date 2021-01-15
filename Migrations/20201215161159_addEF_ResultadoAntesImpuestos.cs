using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ImportSuperIntendencia.Migrations
{
    public partial class addEF_ResultadoAntesImpuestos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EF_ResultadoAntesImpuestos",
                columns: table => new
                {
                    Fecha = table.Column<DateTime>(nullable: false),
                    ResultadoAntesImpuestos = table.Column<decimal>(nullable: false),
                    ImpuestosSobreLaRenta = table.Column<decimal>(nullable: false),
                    ResultadoEjercicio = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EF_ResultadoAntesImpuestos", x => x.Fecha);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EF_ResultadoAntesImpuestos");
        }
    }
}
