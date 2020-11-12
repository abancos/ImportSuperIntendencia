using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ImportSuperIntendencia.Migrations
{
    public partial class addIF_EstructuraActivos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IF_EstructuraActivos",
                columns: table => new
                {
                    Fecha = table.Column<DateTime>(nullable: false),
                    DisponibilidadNeta = table.Column<decimal>(nullable: false),
                    DisponibilidadExterior = table.Column<decimal>(nullable: false),
                    TotalCarteraCreditosNeta = table.Column<decimal>(nullable: false),
                    TotalInversionesNeta = table.Column<decimal>(nullable: false),
                    ActivosFijosNetos = table.Column<decimal>(nullable: false),
                    BienesRecibidosRecuperacionCreditosNetos = table.Column<decimal>(nullable: false),
                    OtrosActivosNetos = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IF_EstructuraActivos", x => x.Fecha);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IF_EstructuraActivos");
        }
    }
}
