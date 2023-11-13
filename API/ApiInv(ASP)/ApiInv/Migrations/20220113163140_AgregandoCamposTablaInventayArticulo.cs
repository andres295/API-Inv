using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiInv.Migrations
{
    public partial class AgregandoCamposTablaInventayArticulo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Proveedor",
                table: "Inventa",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Rack",
                table: "Inventa",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tipo",
                table: "Inventa",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ubicacion",
                table: "Inventa",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Um",
                table: "Inventa",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PROVEEDOR",
                table: "Articulo",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TIPO",
                table: "Articulo",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UM",
                table: "Articulo",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Proveedor",
                table: "Inventa");

            migrationBuilder.DropColumn(
                name: "Rack",
                table: "Inventa");

            migrationBuilder.DropColumn(
                name: "Tipo",
                table: "Inventa");

            migrationBuilder.DropColumn(
                name: "Ubicacion",
                table: "Inventa");

            migrationBuilder.DropColumn(
                name: "Um",
                table: "Inventa");

            migrationBuilder.DropColumn(
                name: "PROVEEDOR",
                table: "Articulo");

            migrationBuilder.DropColumn(
                name: "TIPO",
                table: "Articulo");

            migrationBuilder.DropColumn(
                name: "UM",
                table: "Articulo");
        }
    }
}
