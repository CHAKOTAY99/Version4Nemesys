using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Version4Nemesys.Data.Migrations
{
    public partial class ModifiedForeignKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Votes_Reports_ReportID",
                table: "Votes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Votes",
                table: "Votes");

            migrationBuilder.DropColumn(
                name: "ReportID",
                table: "Votes");

            migrationBuilder.AddColumn<int>(
                name: "VoteID",
                table: "Votes",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "RelatedReportReportID",
                table: "Votes",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Votes",
                table: "Votes",
                column: "VoteID");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Votes_Reports_RelatedReportReportID",
                table: "Votes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Votes",
                table: "Votes");

            migrationBuilder.DropIndex(
                name: "IX_Votes_RelatedReportReportID",
                table: "Votes");

            migrationBuilder.DropColumn(
                name: "VoteID",
                table: "Votes");

            migrationBuilder.DropColumn(
                name: "RelatedReportReportID",
                table: "Votes");

            migrationBuilder.AddColumn<int>(
                name: "ReportID",
                table: "Votes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Votes",
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
    }
}
