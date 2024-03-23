using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballManager_SoftuniProject.Infrastructure.Migrations
{
    public partial class TransferMarketPlayersPrice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "TranferMarketPlayers",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "TranferMarketPlayers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df332d45-04e6-4164-8fd6-125fe2366093", "AQAAAAEAACcQAAAAEB7cBtzBPVnKvPfEwuwJ5gZDAvWa5TA29TJTQOWOEV3OftlKSfLtOyKfVGtLDde38w==", "edda59c0-6453-4f9c-95d9-84bb570e6cd9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a218d2e1-f768-488e-85eb-c82d64c6c0e5", "AQAAAAEAACcQAAAAEOALOO2IZfIcWn8y2MHynSEwUKPIKIxV2fqkOTwxGe+78JNowi2U7lVZNEgCX8oVPA==", "6de6b609-2cf2-47a9-aeda-08f46cb25401" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "TranferMarketPlayers");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "TranferMarketPlayers");

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
    }
}
