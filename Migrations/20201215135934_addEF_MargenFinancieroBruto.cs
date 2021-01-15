﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ImportSuperIntendencia.Migrations
{
    public partial class addEF_MargenFinancieroBruto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EF_MargenFinancieroBruto",
                columns: table => new
                {
                    Fecha = table.Column<DateTime>(nullable: false),
                    MargenFinancieroBruto = table.Column<decimal>(nullable: false),
                    ProvisionesCarteraCreditos = table.Column<decimal>(nullable: false),
                    ProvisionInversiones = table.Column<decimal>(nullable: false),
                    Subtotal = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EF_MargenFinancieroBruto", x => x.Fecha);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EF_MargenFinancieroBruto");
        }
    }
}
