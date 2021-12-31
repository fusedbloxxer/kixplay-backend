using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KixPlay_Backend.Data.Migrations
{
    public partial class RemoveEmailConfirmation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "01c54754-dc3a-459b-a8c9-a614c902559b", "6dd5fa1d-fd94-4d7c-8fc4-277f9f996349", "Moderator", "MODERATOR" },
                    { "0c23fe8e-399d-417e-b94c-56e2664b19c9", "f2ceaa8e-c8bb-467c-89aa-932840dc0abc", "Member", "MEMBER" },
                    { "b5806b04-8768-4386-a3c1-88c93b44b088", "906f8bc1-24c0-42f2-8a37-5892ab9c4ec1", "Admin", "ADMIN" },
                    { "d2c82e64-725f-4083-aa82-44757d48ce8d", "680b0c69-9c9f-47d0-b18d-dff83748a7d4", "Contributor", "CONTRIBUTOR" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "01c54754-dc3a-459b-a8c9-a614c902559b");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "0c23fe8e-399d-417e-b94c-56e2664b19c9");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "b5806b04-8768-4386-a3c1-88c93b44b088");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "d2c82e64-725f-4083-aa82-44757d48ce8d");

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
    }
}
