using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiInv.Migrations
{
    public partial class AgregandConteos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Conteo10",
                table: "Inventa",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Conteo11",
                table: "Inventa",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Conteo12",
                table: "Inventa",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Conteo13",
                table: "Inventa",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Conteo14",
                table: "Inventa",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Conteo15",
                table: "Inventa",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Conteo4",
                table: "Inventa",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Conteo5",
                table: "Inventa",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Conteo6",
                table: "Inventa",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Conteo7",
                table: "Inventa",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Conteo8",
                table: "Inventa",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Conteo9",
                table: "Inventa",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Host10",
                table: "Inventa",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Host11",
                table: "Inventa",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Host12",
                table: "Inventa",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Host13",
                table: "Inventa",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Host14",
                table: "Inventa",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Host15",
                table: "Inventa",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Host4",
                table: "Inventa",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Host5",
                table: "Inventa",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Host6",
                table: "Inventa",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Host7",
                table: "Inventa",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Host8",
                table: "Inventa",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Host9",
                table: "Inventa",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Conteo10",
                table: "Inventa");

            migrationBuilder.DropColumn(
                name: "Conteo11",
                table: "Inventa");

            migrationBuilder.DropColumn(
                name: "Conteo12",
                table: "Inventa");

            migrationBuilder.DropColumn(
                name: "Conteo13",
                table: "Inventa");

            migrationBuilder.DropColumn(
                name: "Conteo14",
                table: "Inventa");

            migrationBuilder.DropColumn(
                name: "Conteo15",
                table: "Inventa");

            migrationBuilder.DropColumn(
                name: "Conteo4",
                table: "Inventa");

            migrationBuilder.DropColumn(
                name: "Conteo5",
                table: "Inventa");

            migrationBuilder.DropColumn(
                name: "Conteo6",
                table: "Inventa");

            migrationBuilder.DropColumn(
                name: "Conteo7",
                table: "Inventa");

            migrationBuilder.DropColumn(
                name: "Conteo8",
                table: "Inventa");

            migrationBuilder.DropColumn(
                name: "Conteo9",
                table: "Inventa");

            migrationBuilder.DropColumn(
                name: "Host10",
                table: "Inventa");

            migrationBuilder.DropColumn(
                name: "Host11",
                table: "Inventa");

            migrationBuilder.DropColumn(
                name: "Host12",
                table: "Inventa");

            migrationBuilder.DropColumn(
                name: "Host13",
                table: "Inventa");

            migrationBuilder.DropColumn(
                name: "Host14",
                table: "Inventa");

            migrationBuilder.DropColumn(
                name: "Host15",
                table: "Inventa");

            migrationBuilder.DropColumn(
                name: "Host4",
                table: "Inventa");

            migrationBuilder.DropColumn(
                name: "Host5",
                table: "Inventa");

            migrationBuilder.DropColumn(
                name: "Host6",
                table: "Inventa");

            migrationBuilder.DropColumn(
                name: "Host7",
                table: "Inventa");

            migrationBuilder.DropColumn(
                name: "Host8",
                table: "Inventa");

            migrationBuilder.DropColumn(
                name: "Host9",
                table: "Inventa");
        }
    }
}
