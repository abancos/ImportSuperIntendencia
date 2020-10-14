using Microsoft.EntityFrameworkCore.Migrations;

namespace ImportSuperIntendencia.Migrations
{
    public partial class AddFondosInterbancariosctivos4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "RendimientosporCobrar",
                table: "EF_FondosInterbancariosActivos",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "RendimientosporCobrar",
                table: "EF_FondosInterbancariosActivos",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal));
        }
    }
}
