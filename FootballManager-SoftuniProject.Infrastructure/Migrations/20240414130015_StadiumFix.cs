using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballManager_SoftuniProject.Infrastructure.Migrations
{
    public partial class StadiumFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stadiums_AspNetUsers_UserId",
                table: "Stadiums");

            migrationBuilder.DropIndex(
                name: "IX_Stadiums_UserId",
                table: "Stadiums");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Stadiums");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Stadiums",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Stadiums_UserId",
                table: "Stadiums",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Stadiums_AspNetUsers_UserId",
                table: "Stadiums",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
