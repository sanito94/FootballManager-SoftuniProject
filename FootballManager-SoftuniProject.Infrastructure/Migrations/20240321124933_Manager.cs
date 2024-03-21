using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballManager_SoftuniProject.Infrastructure.Migrations
{
    public partial class Manager : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "YearsOfExperience",
                table: "Managers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "YearsOfExperience",
                table: "Managers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
