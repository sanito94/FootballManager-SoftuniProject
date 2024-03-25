using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballManager_SoftuniProject.Infrastructure.Migrations
{
    public partial class TransferMarketPlayerUpdated1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PlayerId",
                table: "TranferMarketPlayers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PlayerId",
                table: "TranferMarketPlayers");
        }
    }
}
