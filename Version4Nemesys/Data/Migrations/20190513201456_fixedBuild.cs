using Microsoft.EntityFrameworkCore.Migrations;

namespace Version4Nemesys.Data.Migrations
{
    public partial class fixedBuild : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "States",
                table: "Investigations");

            migrationBuilder.AddColumn<int>(
                name: "StatesInTest",
                table: "Investigations",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StatesInTest",
                table: "Investigations");

            migrationBuilder.AddColumn<int>(
                name: "States",
                table: "Investigations",
                nullable: false,
                defaultValue: 0);
        }
    }
}
