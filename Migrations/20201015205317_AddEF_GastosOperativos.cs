using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ImportSuperIntendencia.Migrations
{
    public partial class AddEF_GastosOperativos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EF_GastosOperativos",
                columns: table => new
                {
                    Fecha = table.Column<DateTime>(nullable: false),
                    SueldosCompensacionesPersonal = table.Column<decimal>(nullable: false),
                    ServiciosATerceros = table.Column<decimal>(nullable: false),
                    DepreciacionAmortizaciones = table.Column<decimal>(nullable: false),
                    OtrasProvisiones = table.Column<decimal>(nullable: false),
                    OtrosGastos = table.Column<decimal>(nullable: false),
                    Subtotal = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EF_GastosOperativos", x => x.Fecha);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EF_GastosOperativos");
        }
    }
}
