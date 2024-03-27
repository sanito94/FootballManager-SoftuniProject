using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballManager_SoftuniProject.Infrastructure.Migrations
{
    public partial class TransferMarketPlayerFromUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FromUser",
                table: "TranferMarketPlayers");

            migrationBuilder.AddColumn<string>(
                name: "FromUserId",
                table: "TranferMarketPlayers",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_TranferMarketPlayers_FromUserId",
                table: "TranferMarketPlayers",
                column: "FromUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_TranferMarketPlayers_AspNetUsers_FromUserId",
                table: "TranferMarketPlayers",
                column: "FromUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TranferMarketPlayers_AspNetUsers_FromUserId",
                table: "TranferMarketPlayers");

            migrationBuilder.DropIndex(
                name: "IX_TranferMarketPlayers_FromUserId",
                table: "TranferMarketPlayers");

            migrationBuilder.DropColumn(
                name: "FromUserId",
                table: "TranferMarketPlayers");

            migrationBuilder.AddColumn<string>(
                name: "FromUser",
                table: "TranferMarketPlayers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
