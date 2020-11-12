using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ImportSuperIntendencia.Migrations
{
    public partial class addIF_Liquidez : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IF_Liquidez",
                columns: table => new
                {
                    Fecha = table.Column<DateTime>(nullable: false),
                    TotalCapacitacionesObligConCosto = table.Column<decimal>(nullable: false),
                    TotalCapacitaciones = table.Column<decimal>(nullable: false),
                    TotalActivos = table.Column<decimal>(nullable: false),
                    ActivosProductivos = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IF_Liquidez", x => x.Fecha);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IF_Liquidez");
        }
    }
}
