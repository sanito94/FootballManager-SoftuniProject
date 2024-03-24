using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballManager_SoftuniProject.Infrastructure.Migrations
{
    public partial class RolesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "85ce5b97-00dd-4abc-ba28-3d2d0683d7c8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e965e5f-f6db-4b68-8ecb-ec3a1784cd3a", "AQAAAAEAACcQAAAAEPZV6+A5YLk0YPqka/azHBCvVD+3858xvaVYxzcj75Rou2kVbLUqyMnFKR22kSzLxQ==", "9082a464-b0eb-4ce4-82c2-a0b9b7af0303" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d7047d3-a832-4e98-8677-fde0dc54d3ee", "AQAAAAEAACcQAAAAEG1ykpenoLZ98RCrL3s+9CKmv2L/AudwpcwGlZxX6VgJxmi8ERPQsnqnkaPV3Z9dmA==", "1af500eb-6aa6-4b1e-942a-c4507c75246a" });
        }
    }
}
