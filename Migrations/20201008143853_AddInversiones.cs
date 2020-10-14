using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ImportSuperIntendencia.Migrations
{
    public partial class AddInversiones : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FondosDisponibles");

            migrationBuilder.DropTable(
                name: "FondosInterbancarios");

            migrationBuilder.CreateTable(
                name: "EF_FondosDisponibles",
                columns: table => new
                {
                    Fecha = table.Column<DateTime>(nullable: false),
                    Caja = table.Column<decimal>(nullable: false),
                    BancoCentral = table.Column<decimal>(nullable: false),
                    BancosPais = table.Column<decimal>(nullable: false),
                    BancosExtranjeros = table.Column<decimal>(nullable: false),
                    Otras = table.Column<decimal>(nullable: false),
                    RendimientosCobrar = table.Column<decimal>(nullable: false),
                    Subtotal = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EF_FondosDisponibles", x => x.Fecha);
                });

            migrationBuilder.CreateTable(
                name: "EF_FondosInterbancarios",
                columns: table => new
                {
                    Fecha = table.Column<DateTime>(nullable: false),
                    FondosBancarios = table.Column<decimal>(nullable: false),
                    RendimientosporCobrar = table.Column<decimal>(nullable: false),
                    Subtotal = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EF_FondosInterbancarios", x => x.Fecha);
                });

            migrationBuilder.CreateTable(
                name: "EF_Inversiones",
                columns: table => new
                {
                    Fecha = table.Column<DateTime>(nullable: false),
                    Negociables = table.Column<decimal>(nullable: false),
                    DisponiblesVenta = table.Column<decimal>(nullable: false),
                    MantenidasVencimiento = table.Column<decimal>(nullable: false),
                    InversionesInstDeudas = table.Column<decimal>(nullable: false),
                    InversionesDepositosValores = table.Column<decimal>(nullable: false),
                    RendimientoPorCobrar = table.Column<decimal>(nullable: false),
                    ProvisionInversiones = table.Column<decimal>(nullable: false),
                    Subtotal = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EF_Inversiones", x => x.Fecha);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EF_FondosDisponibles");

            migrationBuilder.DropTable(
                name: "EF_FondosInterbancarios");

            migrationBuilder.DropTable(
                name: "EF_Inversiones");

            migrationBuilder.CreateTable(
                name: "FondosDisponibles",
                columns: table => new
                {
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BancoCentral = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BancosExtranjeros = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BancosPais = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Caja = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Otras = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RendimientosCobrar = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Subtotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FondosDisponibles", x => x.Fecha);
                });

            migrationBuilder.CreateTable(
                name: "FondosInterbancarios",
                columns: table => new
                {
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FondosBancarios = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RendimientosporCobrar = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Subtotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FondosInterbancarios", x => x.Fecha);
                });
        }
    }
}
