using Microsoft.EntityFrameworkCore.Migrations;

namespace Version4Nemesys.Data.Migrations
{
    public partial class editedReport : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reports_Hazard_HazardID",
                table: "Reports");

            migrationBuilder.DropIndex(
                name: "IX_Reports_HazardID",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "HazardID",
                table: "Reports");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HazardID",
                table: "Reports",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Reports_HazardID",
                table: "Reports",
                column: "HazardID");

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_Hazard_HazardID",
                table: "Reports",
                column: "HazardID",
                principalTable: "Hazard",
                principalColumn: "HazardID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
