using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ImportSuperIntendencia.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FondosDisponibles",
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
                    table.PrimaryKey("PK_FondosDisponibles", x => x.Fecha);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FondosDisponibles");
        }
    }
}
