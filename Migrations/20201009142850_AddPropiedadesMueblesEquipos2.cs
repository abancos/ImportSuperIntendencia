using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ImportSuperIntendencia.Migrations
{
    public partial class AddPropiedadesMueblesEquipos2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EF_PropiedadMueblesEquipos",
                columns: table => new
                {
                    Fecha = table.Column<DateTime>(nullable: false),
                    PropiedadMueblesEquipos = table.Column<decimal>(nullable: false),
                    DepreciacionAcumulada = table.Column<decimal>(nullable: false),
                    Subtotal = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EF_PropiedadMueblesEquipos", x => x.Fecha);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EF_PropiedadMueblesEquipos");
        }
    }
}
