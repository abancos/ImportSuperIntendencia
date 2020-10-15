using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ImportSuperIntendencia.Migrations
{
    public partial class AddEF_OtrosGastosOperacionales : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EF_OtrosGastosOperacionales",
                columns: table => new
                {
                    Fecha = table.Column<DateTime>(nullable: false),
                    ComisionesporServicios = table.Column<decimal>(nullable: false),
                    GastosDiversos = table.Column<decimal>(nullable: false),
                    Subtotal = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EF_OtrosGastosOperacionales", x => x.Fecha);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EF_OtrosGastosOperacionales");
        }
    }
}
