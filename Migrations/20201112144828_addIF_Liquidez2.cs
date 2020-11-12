using Microsoft.EntityFrameworkCore.Migrations;

namespace ImportSuperIntendencia.Migrations
{
    public partial class addIF_Liquidez2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalCapacitaciones",
                table: "IF_Liquidez");

            migrationBuilder.DropColumn(
                name: "TotalCapacitacionesObligConCosto",
                table: "IF_Liquidez");

            migrationBuilder.AddColumn<decimal>(
                name: "TotalCaptaciones",
                table: "IF_Liquidez",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalCaptacionesObligConCosto",
                table: "IF_Liquidez",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalDepositos",
                table: "IF_Liquidez",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalCaptaciones",
                table: "IF_Liquidez");

            migrationBuilder.DropColumn(
                name: "TotalCaptacionesObligConCosto",
                table: "IF_Liquidez");

            migrationBuilder.DropColumn(
                name: "TotalDepositos",
                table: "IF_Liquidez");

            migrationBuilder.AddColumn<decimal>(
                name: "TotalCapacitaciones",
                table: "IF_Liquidez",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalCapacitacionesObligConCosto",
                table: "IF_Liquidez",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
