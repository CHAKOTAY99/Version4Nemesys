using Microsoft.EntityFrameworkCore.Migrations;

namespace Version4Nemesys.Data.Migrations
{
    public partial class changingEnum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "States",
                table: "Reports");

            migrationBuilder.AddColumn<int>(
                name: "HazardsInTest",
                table: "Reports",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StatesInTest",
                table: "Reports",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HazardsInTest",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "StatesInTest",
                table: "Reports");

            migrationBuilder.AddColumn<int>(
                name: "States",
                table: "Reports",
                nullable: false,
                defaultValue: 0);
        }
    }
}
