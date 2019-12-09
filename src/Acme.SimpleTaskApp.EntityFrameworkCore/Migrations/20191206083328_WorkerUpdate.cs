using Microsoft.EntityFrameworkCore.Migrations;

namespace Acme.SimpleTaskApp.Migrations
{
    public partial class WorkerUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IDCard",
                table: "Certificate");

            migrationBuilder.AddColumn<string>(
                name: "IDCard",
                table: "HouseWorker",
                maxLength: 256,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IDCard",
                table: "HouseWorker");

            migrationBuilder.AddColumn<string>(
                name: "IDCard",
                table: "Certificate",
                maxLength: 256,
                nullable: false,
                defaultValue: "");
        }
    }
}
