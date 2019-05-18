using Microsoft.EntityFrameworkCore.Migrations;

namespace Version4Nemesys.Data.Migrations
{
    public partial class UpdateForignKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Votes_Reports_RelatedReportReportID",
                table: "Votes");

            migrationBuilder.DropIndex(
                name: "IX_Votes_RelatedReportReportID",
                table: "Votes");

            migrationBuilder.DropColumn(
                name: "RelatedReportReportID",
                table: "Votes");

            migrationBuilder.AddColumn<int>(
                name: "ReportID",
                table: "Votes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Votes_ReportID",
                table: "Votes",
                column: "ReportID");

            migrationBuilder.AddForeignKey(
                name: "FK_Votes_Reports_ReportID",
                table: "Votes",
                column: "ReportID",
                principalTable: "Reports",
                principalColumn: "ReportID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Votes_Reports_ReportID",
                table: "Votes");

            migrationBuilder.DropIndex(
                name: "IX_Votes_ReportID",
                table: "Votes");

            migrationBuilder.DropColumn(
                name: "ReportID",
                table: "Votes");

            migrationBuilder.AddColumn<int>(
                name: "RelatedReportReportID",
                table: "Votes",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Votes_RelatedReportReportID",
                table: "Votes",
                column: "RelatedReportReportID");

            migrationBuilder.AddForeignKey(
                name: "FK_Votes_Reports_RelatedReportReportID",
                table: "Votes",
                column: "RelatedReportReportID",
                principalTable: "Reports",
                principalColumn: "ReportID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
