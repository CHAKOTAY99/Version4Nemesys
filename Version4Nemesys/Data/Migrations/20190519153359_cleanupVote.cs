using Microsoft.EntityFrameworkCore.Migrations;

namespace Version4Nemesys.Data.Migrations
{
    public partial class cleanupVote : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalVotes",
                table: "Votes");

            migrationBuilder.DropColumn(
                name: "Voted",
                table: "Votes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TotalVotes",
                table: "Votes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Voted",
                table: "Votes",
                nullable: false,
                defaultValue: false);
        }
    }
}
