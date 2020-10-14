using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ImportSuperIntendencia.Migrations
{
    public partial class AddFondosInterbancariosPasivos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EF_FondosInterbancarios");

            migrationBuilder.CreateTable(
                name: "EF_FondosInterbancariosActivos",
                columns: table => new
                {
                    Fecha = table.Column<DateTime>(nullable: false),
                    FondosBancarios = table.Column<decimal>(nullable: false),
                    RendimientosporCobrar = table.Column<decimal>(nullable: false),
                    Subtotal = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EF_FondosInterbancariosActivos", x => x.Fecha);
                });

            migrationBuilder.CreateTable(
                name: "EF_FondosInterbancariosPasivos",
                columns: table => new
                {
                    Fecha = table.Column<DateTime>(nullable: false),
                    FondosBancarios = table.Column<decimal>(nullable: false),
                    InteresesPorPagar = table.Column<decimal>(nullable: false),
                    Subtotal = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EF_FondosInterbancariosPasivos", x => x.Fecha);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EF_FondosInterbancariosActivos");

            migrationBuilder.DropTable(
                name: "EF_FondosInterbancariosPasivos");

            migrationBuilder.CreateTable(
                name: "EF_FondosInterbancarios",
                columns: table => new
                {
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FondosBancarios = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RendimientosporCobrar = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Subtotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EF_FondosInterbancarios", x => x.Fecha);
                });
        }
    }
}
