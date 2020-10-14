using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ImportSuperIntendencia.Migrations
{
    public partial class AddInversionesAcciones : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EF_InversionesAcciones",
                columns: table => new
                {
                    Fecha = table.Column<DateTime>(nullable: false),
                    InversionesAcciones = table.Column<decimal>(nullable: false),
                    ProvisionInversionesAcciones = table.Column<decimal>(nullable: false),
                    Subtotal = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EF_InversionesAcciones", x => x.Fecha);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EF_InversionesAcciones");
        }
    }
}
