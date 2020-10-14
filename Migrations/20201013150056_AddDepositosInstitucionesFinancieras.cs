using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ImportSuperIntendencia.Migrations
{
    public partial class AddDepositosInstitucionesFinancieras : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EF_DepositosInstitucionesFinancieras",
                columns: table => new
                {
                    Fecha = table.Column<DateTime>(nullable: false),
                    InstitucionesPais = table.Column<decimal>(nullable: false),
                    InstitucionesExterior = table.Column<decimal>(nullable: false),
                    InteresesPorPagar = table.Column<decimal>(nullable: false),
                    Subtotal = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EF_DepositosInstitucionesFinancieras", x => x.Fecha);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EF_DepositosInstitucionesFinancieras");
        }
    }
}
