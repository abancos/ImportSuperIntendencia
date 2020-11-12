using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ImportSuperIntendencia.Migrations
{
    public partial class addIF_Volumen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IF_Volumen",
                columns: table => new
                {
                    Fecha = table.Column<DateTime>(nullable: false),
                    TotalActivosNetos = table.Column<decimal>(nullable: false),
                    TotalPasivos = table.Column<decimal>(nullable: false),
                    TotalPatrimonioNeto = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IF_Volumen", x => x.Fecha);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IF_Volumen");
        }
    }
}
