using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ImportSuperIntendencia.Migrations
{
    public partial class AddCuentasCobrar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EF_CuentasCobrar",
                columns: table => new
                {
                    Fecha = table.Column<DateTime>(nullable: false),
                    CuentasCobrar = table.Column<decimal>(nullable: false),
                    RendimientosCobrar = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EF_CuentasCobrar", x => x.Fecha);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EF_CuentasCobrar");
        }
    }
}
