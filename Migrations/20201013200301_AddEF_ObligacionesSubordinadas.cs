using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ImportSuperIntendencia.Migrations
{
    public partial class AddEF_ObligacionesSubordinadas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EF_ObligacionesSubordinadas",
                columns: table => new
                {
                    Fecha = table.Column<DateTime>(nullable: false),
                    DeudasSubordinadas = table.Column<decimal>(nullable: false),
                    InteresesporPagar = table.Column<decimal>(nullable: false),
                    Subtotal = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EF_ObligacionesSubordinadas", x => x.Fecha);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EF_ObligacionesSubordinadas");
        }
    }
}
