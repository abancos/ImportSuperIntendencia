using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ImportSuperIntendencia.Migrations
{
    public partial class addIF_EstructuraCarteraCreditos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IF_EstructuraCarteraCreditos",
                columns: table => new
                {
                    Fecha = table.Column<DateTime>(nullable: false),
                    CarteraCreditosVencida = table.Column<decimal>(nullable: false),
                    CarteraCreditosVigente = table.Column<decimal>(nullable: false),
                    TotalCarteraVencida = table.Column<decimal>(nullable: false),
                    TotalCarteraCreditoBruta = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IF_EstructuraCarteraCreditos", x => x.Fecha);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IF_EstructuraCarteraCreditos");
        }
    }
}
