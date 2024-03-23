using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballManager_SoftuniProject.Infrastructure.Migrations
{
    public partial class TransferMarketPlayersTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TransferMarketId",
                table: "TranferMarketPlayers",
                type: "int",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_TranferMarketPlayers_TransferMarketId",
                table: "TranferMarketPlayers",
                column: "TransferMarketId");

            migrationBuilder.AddForeignKey(
                name: "FK_TranferMarketPlayers_TransferMarket_TransferMarketId",
                table: "TranferMarketPlayers",
                column: "TransferMarketId",
                principalTable: "TransferMarket",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TranferMarketPlayers_TransferMarket_TransferMarketId",
                table: "TranferMarketPlayers");

            migrationBuilder.DropIndex(
                name: "IX_TranferMarketPlayers_TransferMarketId",
                table: "TranferMarketPlayers");

            migrationBuilder.DropColumn(
                name: "TransferMarketId",
                table: "TranferMarketPlayers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "70f01426-e639-4d5d-bf6f-1d0c76642c64", "AQAAAAEAACcQAAAAEKjrvZQeF8925hkoaVIo3LX2OdQnNVSyefepDya3c7bzYgYqmdesWRPnQm7Q15kPGw==", "ad9b352b-c8cc-4fc8-963e-f7cee8d66c1c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "175ef002-8218-45be-a900-2eb018871ab9", "AQAAAAEAACcQAAAAENecSNOPVGOclzJCrwVv8FmFdHYIh/KTm2fijhclpQrH/esJksqCbH8NoPnLV1onug==", "34ecf131-2283-40c6-877d-9a129f78388c" });
        }
    }
}
