using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballManager_SoftuniProject.Infrastructure.Migrations
{
    public partial class DataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e", 0, "70f01426-e639-4d5d-bf6f-1d0c76642c64", "guest@mail.com", false, false, null, "guest@mail.com", "guest@mail.com", "AQAAAAEAACcQAAAAEKjrvZQeF8925hkoaVIo3LX2OdQnNVSyefepDya3c7bzYgYqmdesWRPnQm7Q15kPGw==", null, false, "ad9b352b-c8cc-4fc8-963e-f7cee8d66c1c", false, "guest@mail.com" },
                    { "dea12856-c198-4129-b3f3-b893d8395082", 0, "175ef002-8218-45be-a900-2eb018871ab9", "agent@mail.com", false, false, null, "agent@mail.com", "agent@mail.com", "AQAAAAEAACcQAAAAENecSNOPVGOclzJCrwVv8FmFdHYIh/KTm2fijhclpQrH/esJksqCbH8NoPnLV1onug==", null, false, "34ecf131-2283-40c6-877d-9a129f78388c", false, "agent@mail.com" }
                });

            migrationBuilder.InsertData(
                table: "League",
                columns: new[] { "Id", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { 2, "https://b.fssta.com/uploads/application/soccer/competition-logos/EnglishPremierLeague.png", "Premier League" },
                    { 3, "https://upload.wikimedia.org/wikipedia/fr/2/23/Logo_La_Liga.png", "LaLiga" }
                });

            migrationBuilder.InsertData(
                table: "Stadiums",
                columns: new[] { "Id", "Capacity", "Name" },
                values: new object[] { 2, 80000, "Santiago Bernabeu" });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "Country", "ImageUrl", "LeagueId", "Name", "StadiumId" },
                values: new object[] { 2, "Spain", "https://banner2.cleanpng.com/20180602/psw/kisspng-real-madrid-c-f-uefa-champions-league-la-liga-juv-5b1351b072b362.2456057615279927524698.jpg", 3, "Real Madrid", 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082");

            migrationBuilder.DeleteData(
                table: "League",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "League",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Stadiums",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
