using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballManager_SoftuniProject.Infrastructure.Migrations
{
    public partial class StadiumCapacityRemoved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Capacity",
                table: "Stadiums");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Capacity",
                table: "Stadiums",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Stadiums",
                keyColumn: "Id",
                keyValue: 1,
                column: "Capacity",
                value: 100000);

            migrationBuilder.UpdateData(
                table: "Stadiums",
                keyColumn: "Id",
                keyValue: 2,
                column: "Capacity",
                value: 80000);
        }
    }
}
