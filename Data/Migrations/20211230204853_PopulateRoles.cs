using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KixPlay_Backend.Data.Migrations
{
    public partial class PopulateRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
