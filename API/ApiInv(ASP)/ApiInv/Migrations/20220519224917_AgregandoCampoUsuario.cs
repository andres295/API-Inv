using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiInv.Migrations
{
    public partial class AgregandoCampoUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "User1",
                table: "Inventa",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "User10",
                table: "Inventa",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "User11",
                table: "Inventa",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "User12",
                table: "Inventa",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "User13",
                table: "Inventa",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "User14",
                table: "Inventa",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "User15",
                table: "Inventa",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "User2",
                table: "Inventa",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "User3",
                table: "Inventa",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "User4",
                table: "Inventa",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "User5",
                table: "Inventa",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "User6",
                table: "Inventa",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "User7",
                table: "Inventa",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "User8",
                table: "Inventa",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "User9",
                table: "Inventa",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "User1",
                table: "Inventa");

            migrationBuilder.DropColumn(
                name: "User10",
                table: "Inventa");

            migrationBuilder.DropColumn(
                name: "User11",
                table: "Inventa");

            migrationBuilder.DropColumn(
                name: "User12",
                table: "Inventa");

            migrationBuilder.DropColumn(
                name: "User13",
                table: "Inventa");

            migrationBuilder.DropColumn(
                name: "User14",
                table: "Inventa");

            migrationBuilder.DropColumn(
                name: "User15",
                table: "Inventa");

            migrationBuilder.DropColumn(
                name: "User2",
                table: "Inventa");

            migrationBuilder.DropColumn(
                name: "User3",
                table: "Inventa");

            migrationBuilder.DropColumn(
                name: "User4",
                table: "Inventa");

            migrationBuilder.DropColumn(
                name: "User5",
                table: "Inventa");

            migrationBuilder.DropColumn(
                name: "User6",
                table: "Inventa");

            migrationBuilder.DropColumn(
                name: "User7",
                table: "Inventa");

            migrationBuilder.DropColumn(
                name: "User8",
                table: "Inventa");

            migrationBuilder.DropColumn(
                name: "User9",
                table: "Inventa");
        }
    }
}
