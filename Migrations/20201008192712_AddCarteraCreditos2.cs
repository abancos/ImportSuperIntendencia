using Microsoft.EntityFrameworkCore.Migrations;

namespace ImportSuperIntendencia.Migrations
{
    public partial class AddCarteraCreditos2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RendimientosCObrar",
                table: "EF_CarteraCreditos",
                newName: "RendimientosCobrar");

            migrationBuilder.AddColumn<decimal>(
                name: "Vencida",
                table: "EF_CarteraCreditos",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Vencida",
                table: "EF_CarteraCreditos");

            migrationBuilder.RenameColumn(
                name: "RendimientosCobrar",
                table: "EF_CarteraCreditos",
                newName: "RendimientosCObrar");
        }
    }
}
