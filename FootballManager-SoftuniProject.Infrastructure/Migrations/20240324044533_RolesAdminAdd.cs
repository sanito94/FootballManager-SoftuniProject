using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballManager_SoftuniProject.Infrastructure.Migrations
{
    public partial class RolesAdminAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "85ce5b97-00dd-4abc-ba28-3d2d0683d7c8");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f6d58fdb-210d-4326-bf20-85e656f184bb", "6853224a-a667-489d-b442-aaac8de72029", "Admin", "ADMIN" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b2dc86eb-7cae-4213-b62e-19faf99db17e", "AQAAAAEAACcQAAAAEFpl+/ouSrNWN0X/XZGT93r8ltJmeAWQ4V7ejWzUHtbZT3A8XQm2RlghkVco0UdH1A==", "c4f0aa7e-3558-491c-a84c-f9664d88b92e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b0fb003a-e91b-438d-9b45-6c85b84727e1", "AQAAAAEAACcQAAAAEA2E0lg1I4F8iONg56538LsBbTooYXGkz/7xmXweY+DXxSqu9L8DpjFf5B1G8v7SlA==", "e12eafa2-92ec-4498-ab9f-52f4883379ad" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f6d58fdb-210d-4326-bf20-85e656f184bb");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "85ce5b97-00dd-4abc-ba28-3d2d0683d7c8", "545cfc9d-8f27-483c-b56f-c9baa5666518", "AdminTest", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2bf63f36-bd03-442e-a205-1f795b213629", "AQAAAAEAACcQAAAAELKK+NWx05ZHTV307fhXOSTvnIRoKIgfTCG+QclDgB0LPVTPB4JG3Wn5jzBZEORySg==", "f7ed6f65-2c11-4edc-ac8d-b443c67296fb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c23bbb68-6c33-4d62-bc98-8295e90ecb7f", "AQAAAAEAACcQAAAAEIWibdaki0WKzZNJvM0TmazcRapJCvRaz0KRGiMrdPq8KlY2tMJ+WK0FRhsYKinZPg==", "aefc7afd-17cd-4496-9047-ca3d8a353d21" });
        }
    }
}
