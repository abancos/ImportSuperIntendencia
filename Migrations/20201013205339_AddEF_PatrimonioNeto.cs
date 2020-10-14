using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ImportSuperIntendencia.Migrations
{
    public partial class AddEF_PatrimonioNeto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EF_PatrimonioNeto",
                columns: table => new
                {
                    Fecha = table.Column<DateTime>(nullable: false),
                    CapitalPagado = table.Column<decimal>(nullable: false),
                    ReservaLegalBancaria = table.Column<decimal>(nullable: false),
                    CapitalAdicionalPagado = table.Column<decimal>(nullable: false),
                    OtrasReservasPatrimoniales = table.Column<decimal>(nullable: false),
                    SuperavitporRevaluacion = table.Column<decimal>(nullable: false),
                    GanaciasNoRealizadas = table.Column<decimal>(nullable: false),
                    ResultadosAcumuladosEjerciciosAnt = table.Column<decimal>(nullable: false),
                    ResultadoDelEjercicio = table.Column<decimal>(nullable: false),
                    TotalPatrimonioNeto = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EF_PatrimonioNeto", x => x.Fecha);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EF_PatrimonioNeto");
        }
    }
}
