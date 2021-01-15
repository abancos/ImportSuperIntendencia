using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ImportSuperIntendencia.Migrations
{
    public partial class addEF_MargenFinancieroNeto2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EF_MargenFinancieroNet");

            migrationBuilder.CreateTable(
                name: "EF_MargenFinancieroNeto",
                columns: table => new
                {
                    Fecha = table.Column<DateTime>(nullable: false),
                    MargenFinacieroNeto = table.Column<decimal>(nullable: false),
                    IngresosPorDiferenciaCambio = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EF_MargenFinancieroNeto", x => x.Fecha);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EF_MargenFinancieroNeto");

            migrationBuilder.CreateTable(
                name: "EF_MargenFinancieroNet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IngresosPorDiferenciaCambio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MargenFinacieroNeto = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EF_MargenFinancieroNet", x => x.Id);
                });
        }
    }
}
