using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ImportSuperIntendencia.Migrations
{
    public partial class addIF_EstructuraGastosGeneralesAdministrativos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IF_EstructuraGastosGeneralesAdministrativos",
                columns: table => new
                {
                    Fecha = table.Column<DateTime>(nullable: false),
                    SueldosCompensacionesPersonal = table.Column<decimal>(nullable: false),
                    OtrosGastosGenerales = table.Column<decimal>(nullable: false),
                    TotalGastosGeneralesAdministrativos = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IF_EstructuraGastosGeneralesAdministrativos", x => x.Fecha);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IF_EstructuraGastosGeneralesAdministrativos");
        }
    }
}
