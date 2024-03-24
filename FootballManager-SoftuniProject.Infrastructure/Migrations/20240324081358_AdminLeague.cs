using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballManager_SoftuniProject.Infrastructure.Migrations
{
    public partial class AdminLeague : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "League",
                columns: new[] { "Id", "ImageUrl", "Name" },
                values: new object[] { 1, "https://c8.alamy.com/comp/2H36T4F/three-persons-admin-icon-outline-three-persons-admin-vector-icon-color-flat-isolated-2H36T4F.jpg", "Admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "League",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
