using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ImportSuperIntendencia.Migrations
{
    public partial class AddEF_TotaldePasivosPatrimonio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EF_TotaldePasivosPatrimonio",
                columns: table => new
                {
                    Fecha = table.Column<DateTime>(nullable: false),
                    TotalPasivosPatrimonio = table.Column<decimal>(nullable: false),
                    CuentasContingentes = table.Column<decimal>(nullable: false),
                    CuentasOrden = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EF_TotaldePasivosPatrimonio", x => x.Fecha);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EF_TotaldePasivosPatrimonio");
        }
    }
}
