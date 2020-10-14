using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ImportSuperIntendencia.Migrations
{
    public partial class AddObligacionesPublico : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EF_ObligacionesPublico",
                columns: table => new
                {
                    Fecha = table.Column<DateTime>(nullable: false),
                    ALaVista = table.Column<decimal>(nullable: false),
                    Ahorro = table.Column<decimal>(nullable: false),
                    Plazo = table.Column<decimal>(nullable: false),
                    InteresesPorPagar = table.Column<decimal>(nullable: false),
                    Subtotal = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EF_ObligacionesPublico", x => x.Fecha);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EF_ObligacionesPublico");
        }
    }
}
