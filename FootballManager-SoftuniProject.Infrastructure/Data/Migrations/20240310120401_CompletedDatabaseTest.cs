using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballManager_SoftuniProject.Data.Migrations
{
    public partial class CompletedDatabaseTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeamsPlayers_Players_PlayerId",
                table: "TeamsPlayers");

            migrationBuilder.DropForeignKey(
                name: "FK_TeamsPlayers_Players_PlayerId1",
                table: "TeamsPlayers");

            migrationBuilder.DropIndex(
                name: "IX_TeamsPlayers_PlayerId1",
                table: "TeamsPlayers");

            migrationBuilder.DropColumn(
                name: "PlayerId1",
                table: "TeamsPlayers");

            migrationBuilder.AddForeignKey(
                name: "FK_TeamsPlayers_Players_PlayerId",
                table: "TeamsPlayers",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeamsPlayers_Players_PlayerId",
                table: "TeamsPlayers");

            migrationBuilder.AddColumn<int>(
                name: "PlayerId1",
                table: "TeamsPlayers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TeamsPlayers_PlayerId1",
                table: "TeamsPlayers",
                column: "PlayerId1");

            migrationBuilder.AddForeignKey(
                name: "FK_TeamsPlayers_Players_PlayerId",
                table: "TeamsPlayers",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TeamsPlayers_Players_PlayerId1",
                table: "TeamsPlayers",
                column: "PlayerId1",
                principalTable: "Players",
                principalColumn: "Id");
        }
    }
}
