using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ImportSuperIntendencia.Migrations
{
    public partial class AddEF_FondosTomadosPrestamos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EF_FondosTomadosPrestamos",
                columns: table => new
                {
                    Fecha = table.Column<DateTime>(nullable: false),
                    BancoCentral = table.Column<decimal>(nullable: false),
                    InstitucionesPais = table.Column<decimal>(nullable: false),
                    InstitucionesExterior = table.Column<decimal>(nullable: false),
                    Otros = table.Column<decimal>(nullable: false),
                    InteresesPagar = table.Column<decimal>(nullable: false),
                    Subtotal = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EF_FondosTomadosPrestamos", x => x.Fecha);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EF_FondosTomadosPrestamos");
        }
    }
}
