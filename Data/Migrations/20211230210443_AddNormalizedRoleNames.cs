using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KixPlay_Backend.Data.Migrations
{
    public partial class AddNormalizedRoleNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "5bdffb7a-a1bc-4d17-9edb-909cacd3a7d5");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "5e6e69a5-13d3-4b7a-9986-3b86858ac1e7");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "73967f48-7110-4ca7-9dd0-1010b9836bf8");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8cf09eb2-550c-4c98-8b57-1a09d68c69ca");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3368fa57-184b-4ee9-a7ed-2783f2d78896", "a95d3bf7-2a34-4df9-978d-0f87421546de", "Contributor", "CONTRIBUTOR" },
                    { "69814655-a1d4-4396-9a2d-3b0ed488b3b3", "afe1ff57-6868-4fe4-968e-a73aa60cabe1", "Member", "MEMBER" },
                    { "e668cc28-b44a-43c6-8e9a-5e46380a2676", "235b365b-acc7-46ae-93cf-42c5b4bc89a4", "Moderator", "MODERATOR" },
                    { "f8b6c168-eb0d-48f3-8196-7367e27cf90f", "b2883840-4291-4506-a065-5257104804c5", "Admin", "ADMIN" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "3368fa57-184b-4ee9-a7ed-2783f2d78896");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "69814655-a1d4-4396-9a2d-3b0ed488b3b3");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "e668cc28-b44a-43c6-8e9a-5e46380a2676");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "f8b6c168-eb0d-48f3-8196-7367e27cf90f");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5bdffb7a-a1bc-4d17-9edb-909cacd3a7d5", "0cd0279d-4050-4aa1-8d47-06ad96a0fb5a", "Contributor", null },
                    { "5e6e69a5-13d3-4b7a-9986-3b86858ac1e7", "401710c9-62c3-4ab8-a462-e08db720f808", "Moderator", null },
                    { "73967f48-7110-4ca7-9dd0-1010b9836bf8", "a44f45f7-11c6-489c-ae11-96d1035fcf15", "Member", null },
                    { "8cf09eb2-550c-4c98-8b57-1a09d68c69ca", "a3223307-df9c-4e6a-b2f8-b75552bb27f6", "Admin", null }
                });
        }
    }
}
