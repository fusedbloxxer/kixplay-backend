using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KixPlay_Backend.Data.Migrations
{
    public partial class MarkRoleAsEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "14ee7d07-0182-4770-977c-be214ce3f404", "d7ab488e-b6e8-419a-86af-aaeb6f421cc5", "Member", "MEMBER" },
                    { "36fac547-d582-4a51-92df-5d7d389502cc", "ccbb55f0-2de9-4cca-bd48-6a944f712161", "Contributor", "CONTRIBUTOR" },
                    { "f5cce5f4-900a-41a4-a825-8aa1ad4b3cd2", "b4150a2f-0808-49c4-9055-6fa1259156c4", "Moderator", "MODERATOR" },
                    { "fa109a9e-e5a6-427f-8913-78acaf7ad3be", "79af8151-f344-40dd-9e8d-751cee7a2e7e", "Admin", "ADMIN" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "14ee7d07-0182-4770-977c-be214ce3f404");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "36fac547-d582-4a51-92df-5d7d389502cc");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "f5cce5f4-900a-41a4-a825-8aa1ad4b3cd2");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "fa109a9e-e5a6-427f-8913-78acaf7ad3be");

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
    }
}
