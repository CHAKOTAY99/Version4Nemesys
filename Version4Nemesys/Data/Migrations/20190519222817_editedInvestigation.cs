using Microsoft.EntityFrameworkCore.Migrations;

namespace Version4Nemesys.Data.Migrations
{
    public partial class editedInvestigation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StatesInTest",
                table: "Investigations");

            migrationBuilder.AddColumn<int>(
                name: "InvestigationsInTest",
                table: "Investigations",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InvestigationsInTest",
                table: "Investigations");

            migrationBuilder.AddColumn<int>(
                name: "StatesInTest",
                table: "Investigations",
                nullable: false,
                defaultValue: 0);
        }
    }
}
