using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ImportSuperIntendencia.Migrations
{
    public partial class addIF_EstructuraPasivos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IF_EstructuraPasivos",
                columns: table => new
                {
                    Fecha = table.Column<DateTime>(nullable: false),
                    TotalPasivos = table.Column<decimal>(nullable: false),
                    CarteraCreditosBruta = table.Column<decimal>(nullable: false),
                    TotalCaptaciones = table.Column<decimal>(nullable: false),
                    ValoresCirculacionPublico = table.Column<decimal>(nullable: false),
                    TotalDepositos = table.Column<decimal>(nullable: false),
                    DepositosALaVista = table.Column<decimal>(nullable: false),
                    DepositosAhorro = table.Column<decimal>(nullable: false),
                    DepositosPlazo = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IF_EstructuraPasivos", x => x.Fecha);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IF_EstructuraPasivos");
        }
    }
}
