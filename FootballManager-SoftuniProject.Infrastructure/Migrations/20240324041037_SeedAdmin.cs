using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballManager_SoftuniProject.Infrastructure.Migrations
{
    public partial class SeedAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "4d7047d3-a832-4e98-8677-fde0dc54d3ee", "admin@test.com", "admin@test.com", "admin@test.com", "AQAAAAEAACcQAAAAEG1ykpenoLZ98RCrL3s+9CKmv2L/AudwpcwGlZxX6VgJxmi8ERPQsnqnkaPV3Z9dmA==", "1af500eb-6aa6-4b1e-942a-c4507c75246a", "admin@test.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "a218d2e1-f768-488e-85eb-c82d64c6c0e5", "agent@mail.com", "agent@mail.com", "agent@mail.com", "AQAAAAEAACcQAAAAEOALOO2IZfIcWn8y2MHynSEwUKPIKIxV2fqkOTwxGe+78JNowi2U7lVZNEgCX8oVPA==", "6de6b609-2cf2-47a9-aeda-08f46cb25401", "agent@mail.com" });
        }
    }
}
