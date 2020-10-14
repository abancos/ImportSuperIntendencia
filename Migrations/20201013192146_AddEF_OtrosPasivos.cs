using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ImportSuperIntendencia.Migrations
{
    public partial class AddEF_OtrosPasivos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EF_OtrosPasivos",
                columns: table => new
                {
                    Fecha = table.Column<DateTime>(nullable: false),
                    OtrosPasivos = table.Column<decimal>(nullable: false),
                    InteresesyComisiones = table.Column<decimal>(nullable: false),
                    Subtotal = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EF_OtrosPasivos", x => x.Fecha);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EF_OtrosPasivos");
        }
    }
}
