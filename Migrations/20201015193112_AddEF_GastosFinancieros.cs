using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ImportSuperIntendencia.Migrations
{
    public partial class AddEF_GastosFinancieros : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EF_GastosFinancieros",
                columns: table => new
                {
                    Fecha = table.Column<DateTime>(nullable: false),
                    InteresesporCaptaciones = table.Column<decimal>(nullable: false),
                    PerdidasporInversiones = table.Column<decimal>(nullable: false),
                    InteresesComisionesFinanciamiento = table.Column<decimal>(nullable: false),
                    Subtotal = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EF_GastosFinancieros", x => x.Fecha);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EF_GastosFinancieros");
        }
    }
}
