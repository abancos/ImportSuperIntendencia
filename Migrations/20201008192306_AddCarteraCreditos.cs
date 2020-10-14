using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ImportSuperIntendencia.Migrations
{
    public partial class AddCarteraCreditos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EF_CarteraCreditos",
                columns: table => new
                {
                    Fecha = table.Column<DateTime>(nullable: false),
                    Vigente = table.Column<decimal>(nullable: false),
                    Reestructurada = table.Column<decimal>(nullable: false),
                    CobranzaJudicial = table.Column<decimal>(nullable: false),
                    RendimientosCObrar = table.Column<decimal>(nullable: false),
                    ProvisionesCredito = table.Column<decimal>(nullable: false),
                    Subtotal = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EF_CarteraCreditos", x => x.Fecha);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EF_CarteraCreditos");
        }
    }
}
