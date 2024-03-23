using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballManager_SoftuniProject.Infrastructure.Migrations
{
    public partial class TransferMarketPlayersTest1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "16e32cf1-258a-455b-b5c2-d2a739a4e0c1", "AQAAAAEAACcQAAAAEPjG0YKRe4WoZg9pjFZtJLmXBiiQ7LYzPdHnZfrjayU1BnShD8YKLKcFGzzLCCcv5A==", "a3074755-c250-4601-bf52-8c8143c42319" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5921159f-448b-4715-a002-597e0eaf7bcd", "AQAAAAEAACcQAAAAEFtMihonhg+kx4Q1BXamdysFfQ8KgL/i2pygCvdQGNm5F1SSQLK8BT8H5iyyMra2ww==", "0bf6cb7f-cfb2-46cc-9aa1-0753cd2cf60b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "54c2974b-ba90-4adc-869d-563367622a62", "AQAAAAEAACcQAAAAEM1luw447xBphk9rnJJO0aEWmPglzd2p4HBhS+pRP0sAgxBitnbfhSe5N3sOs8228A==", "0283756f-cdb5-4d05-9e23-4c0b71de76ad" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "42f39f26-6697-4959-ad94-a57ef4f173a0", "AQAAAAEAACcQAAAAEN1j5pGw77DEFnaYFh3lDmyq0l/lV5mGJT0l8gXy6kW6Ft69piPYnwyglo3+TWnewQ==", "85678a0b-6d8d-4cab-af47-0127ff9eddad" });
        }
    }
}
