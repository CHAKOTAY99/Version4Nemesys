using Microsoft.EntityFrameworkCore.Migrations;

namespace Version4Nemesys.Data.Migrations
{
    public partial class EditedAll : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReportUpvotes",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Reports");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "Investigations",
                newName: "ReportUsed");

            migrationBuilder.AddColumn<int>(
                name: "ReportID",
                table: "Photos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Photos_ReportID",
                table: "Photos",
                column: "ReportID");

            migrationBuilder.CreateIndex(
                name: "IX_Investigations_ReportUsed",
                table: "Investigations",
                column: "ReportUsed");

            migrationBuilder.AddForeignKey(
                name: "FK_Investigations_Reports_ReportUsed",
                table: "Investigations",
                column: "ReportUsed",
                principalTable: "Reports",
                principalColumn: "ReportID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_Reports_ReportID",
                table: "Photos",
                column: "ReportID",
                principalTable: "Reports",
                principalColumn: "ReportID",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Investigations_Reports_ReportUsed",
                table: "Investigations");

            migrationBuilder.DropForeignKey(
                name: "FK_Photos_Reports_ReportID",
                table: "Photos");

            migrationBuilder.DropIndex(
                name: "IX_Photos_ReportID",
                table: "Photos");

            migrationBuilder.DropIndex(
                name: "IX_Investigations_ReportUsed",
                table: "Investigations");

            migrationBuilder.DropColumn(
                name: "ReportID",
                table: "Photos");

            migrationBuilder.RenameColumn(
                name: "ReportUsed",
                table: "Investigations",
                newName: "UserID");

            migrationBuilder.AddColumn<int>(
                name: "ReportUpvotes",
                table: "Reports",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "Reports",
                nullable: false,
                defaultValue: 0);
        }
    }
}
