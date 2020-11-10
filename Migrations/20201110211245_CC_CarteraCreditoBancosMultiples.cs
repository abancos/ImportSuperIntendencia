using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ImportSuperIntendencia.Migrations
{
    public partial class CC_CarteraCreditoBancosMultiples : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CC_CarteraCreditoBancosMultiples",
                columns: table => new
                {
                    Fecha = table.Column<DateTime>(nullable: false),
                    CreditosComercialesMayoresDeudoresMN = table.Column<decimal>(nullable: false),
                    CreditosComercialesMedianosDeudoresMN = table.Column<decimal>(nullable: false),
                    CreditosComercialesMenoresDeudoresMN = table.Column<decimal>(nullable: false),
                    CreditosComercialesMicrocreditoMN = table.Column<decimal>(nullable: false),
                    CreditosAtravesTarjetasCreditosPersonalesMN = table.Column<decimal>(nullable: false),
                    CreditosConsumoMN = table.Column<decimal>(nullable: false),
                    CreditosHipotecariosMN = table.Column<decimal>(nullable: false),
                    CreditosComercialesMayoresDeudoresEXT = table.Column<decimal>(nullable: false),
                    CreditosComercialesMedianosDeudoresEXT = table.Column<decimal>(nullable: false),
                    CreditosComercialesMenoresDeudoresEXT = table.Column<decimal>(nullable: false),
                    CreditosComercialesMicrocreditoEXT = table.Column<decimal>(nullable: false),
                    CreditosAtravesTarjetasCreditosPersonalesEXT = table.Column<decimal>(nullable: false),
                    CreditosConsumoEXT = table.Column<decimal>(nullable: false),
                    CreditosHipotecariosEXT = table.Column<decimal>(nullable: false),
                    GrandTotal = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CC_CarteraCreditoBancosMultiples", x => x.Fecha);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CC_CarteraCreditoBancosMultiples");
        }
    }
}
