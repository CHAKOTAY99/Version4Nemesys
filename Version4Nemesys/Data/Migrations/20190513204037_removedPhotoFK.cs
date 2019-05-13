using Microsoft.EntityFrameworkCore.Migrations;

namespace Version4Nemesys.Data.Migrations
{
    public partial class removedPhotoFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reports_Photos_PhotoID",
                table: "Reports");

            migrationBuilder.DropIndex(
                name: "IX_Reports_PhotoID",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "PhotoID",
                table: "Reports");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PhotoID",
                table: "Reports",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Reports_PhotoID",
                table: "Reports",
                column: "PhotoID");

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_Photos_PhotoID",
                table: "Reports",
                column: "PhotoID",
                principalTable: "Photos",
                principalColumn: "PhotoID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
