using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ImportSuperIntendencia.Migrations
{
    public partial class addIF_Rentabilidad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IF_Rentabilidad",
                columns: table => new
                {
                    Fecha = table.Column<DateTime>(nullable: false),
                    ROA = table.Column<decimal>(nullable: false),
                    REA = table.Column<decimal>(nullable: false),
                    IngresosFinancieros = table.Column<decimal>(nullable: false),
                    MargenFinancieroBruto = table.Column<decimal>(nullable: false),
                    ActivosProductivos = table.Column<decimal>(nullable: false),
                    MargenFinancieroBrutoMIN = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IF_Rentabilidad", x => x.Fecha);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IF_Rentabilidad");
        }
    }
}
