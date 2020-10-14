using Microsoft.EntityFrameworkCore.Migrations;

namespace ImportSuperIntendencia.Migrations
{
    public partial class AddTotalActivos2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "CuentasContingentes",
                table: "EF_TotalActivos",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "CuentasOrden",
                table: "EF_TotalActivos",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CuentasContingentes",
                table: "EF_TotalActivos");

            migrationBuilder.DropColumn(
                name: "CuentasOrden",
                table: "EF_TotalActivos");
        }
    }
}
