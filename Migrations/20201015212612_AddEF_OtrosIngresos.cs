using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ImportSuperIntendencia.Migrations
{
    public partial class AddEF_OtrosIngresos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EF_OtrosIngresos",
                columns: table => new
                {
                    Fecha = table.Column<DateTime>(nullable: false),
                    OtrosIngresos = table.Column<decimal>(nullable: false),
                    OtrosGastos = table.Column<decimal>(nullable: false),
                    Subtotal = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EF_OtrosIngresos", x => x.Fecha);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EF_OtrosIngresos");
        }
    }
}
