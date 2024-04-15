using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballManager_SoftuniProject.Infrastructure.Migrations
{
    public partial class StadiumUserId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "Id",
                keyValue: 2);

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
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Stadiums",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Admin Stadium" });

            migrationBuilder.InsertData(
                table: "Stadiums",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Santiago Bernabeu" });
        }
    }
}
