using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ImportSuperIntendencia.Migrations
{
    public partial class AddObligacionesPactosRecompensaTitulos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EF_ObligacionesPactosRecompensaTitulos",
                columns: table => new
                {
                    Fecha = table.Column<DateTime>(nullable: false),
                    ObligacionesPactosRecompensaTitulos = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EF_ObligacionesPactosRecompensaTitulos", x => x.Fecha);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EF_ObligacionesPactosRecompensaTitulos");
        }
    }
}
