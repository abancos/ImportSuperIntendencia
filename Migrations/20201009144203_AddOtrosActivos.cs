using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ImportSuperIntendencia.Migrations
{
    public partial class AddOtrosActivos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EF_OtrosActivos",
                columns: table => new
                {
                    Fecha = table.Column<DateTime>(nullable: false),
                    CargosDiferidos = table.Column<decimal>(nullable: false),
                    Intangibles = table.Column<decimal>(nullable: false),
                    ActivosDiversos = table.Column<decimal>(nullable: false),
                    AmortizacionAcumulada = table.Column<decimal>(nullable: false),
                    Subtotal = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EF_OtrosActivos", x => x.Fecha);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EF_OtrosActivos");
        }
    }
}
