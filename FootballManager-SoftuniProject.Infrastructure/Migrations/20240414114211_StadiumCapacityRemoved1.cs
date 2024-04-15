using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballManager_SoftuniProject.Infrastructure.Migrations
{
    public partial class StadiumCapacityRemoved1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Stadiums",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Admin Stadium");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Stadiums",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Admin");
        }
    }
}
