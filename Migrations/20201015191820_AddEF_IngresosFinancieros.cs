using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ImportSuperIntendencia.Migrations
{
    public partial class AddEF_IngresosFinancieros : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EF_IngresosFinancieros",
                columns: table => new
                {
                    Fecha = table.Column<DateTime>(nullable: false),
                    InteresesComisionesCredito = table.Column<decimal>(nullable: false),
                    InteresesInversiones = table.Column<decimal>(nullable: false),
                    GananciasInversiones = table.Column<decimal>(nullable: false),
                    Subtotal = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EF_IngresosFinancieros", x => x.Fecha);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EF_IngresosFinancieros");
        }
    }
}
