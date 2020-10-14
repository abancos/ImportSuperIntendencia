using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ImportSuperIntendencia.Migrations
{
    public partial class FondosInterbancarios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FondosInterbancarios",
                columns: table => new
                {
                    Fecha = table.Column<DateTime>(nullable: false),
                    FondosBancarios = table.Column<decimal>(nullable: false),
                    RendimientosporCobrar = table.Column<decimal>(nullable: false),
                    Subtotal = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FondosInterbancarios", x => x.Fecha);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FondosInterbancarios");
        }
    }
}
