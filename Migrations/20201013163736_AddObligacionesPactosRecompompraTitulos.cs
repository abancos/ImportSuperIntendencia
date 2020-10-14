using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ImportSuperIntendencia.Migrations
{
    public partial class AddObligacionesPactosRecompompraTitulos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EF_ObligacionesPactosRecompensaTitulos");

            migrationBuilder.CreateTable(
                name: "EF_ObligacionesRecompraTitulos",
                columns: table => new
                {
                    Fecha = table.Column<DateTime>(nullable: false),
                    RecompraTitulos = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EF_ObligacionesRecompraTitulos", x => x.Fecha);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EF_ObligacionesRecompraTitulos");

            migrationBuilder.CreateTable(
                name: "EF_ObligacionesPactosRecompensaTitulos",
                columns: table => new
                {
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ObligacionesPactosRecompensaTitulos = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EF_ObligacionesPactosRecompensaTitulos", x => x.Fecha);
                });
        }
    }
}
