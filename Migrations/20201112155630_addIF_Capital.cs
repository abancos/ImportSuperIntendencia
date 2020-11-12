using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ImportSuperIntendencia.Migrations
{
    public partial class addIF_Capital : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IF_Capital",
                columns: table => new
                {
                    Fecha = table.Column<DateTime>(nullable: false),
                    IndiceSolvencia = table.Column<decimal>(nullable: false),
                    Endeudamiento = table.Column<decimal>(nullable: false),
                    ActivosNeto = table.Column<decimal>(nullable: false),
                    CarteraCreditoVencida = table.Column<decimal>(nullable: false),
                    CarteraCreditoBruta = table.Column<decimal>(nullable: false),
                    ActivosImproductivos = table.Column<decimal>(nullable: false),
                    OtrosActivos = table.Column<decimal>(nullable: false),
                    PatrimonioNetoActivosNetos = table.Column<decimal>(nullable: false),
                    PatrimonioNetoTotalPasivos = table.Column<decimal>(nullable: false),
                    PatrimonioNetoTotalCaptaciones = table.Column<decimal>(nullable: false),
                    PatrimonioNetoActivosNetosExcluyendoDisponibilidades = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IF_Capital", x => x.Fecha);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IF_Capital");
        }
    }
}
