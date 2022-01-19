using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KixPlay_Backend.Data.Migrations
{
    public partial class SeedUsersWithUsernames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a5e3ec25-c31d-4362-8e69-0e4d1a8b486a"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e50caf86-d3af-47ce-a09e-2b0bb5d565eb"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e798d498-29b9-4672-a2a2-4c45ba028788"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("f607b058-01e6-409c-be9b-990606f487c5"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("1af0b708-0d7a-47f8-b0d7-76a369fbe344"), "80121f7a-afcc-4c08-ad68-44a55f93f0bd", "Admin", "ADMIN" },
                    { new Guid("29c36e40-9c9f-456e-9fd0-7c8a804d7afa"), "b7aab21f-759f-43e2-8158-427378f66c24", "Member", "MEMBER" },
                    { new Guid("a5a501dc-8dc4-49ab-854b-1bbdfb33ac46"), "dc44bba3-e723-4308-b10e-e5c4370dfde5", "Contributor", "CONTRIBUTOR" },
                    { new Guid("e446f4c8-868b-40b0-9f94-89ed56bc556f"), "0c7474a9-bc4e-4b5f-881b-f4d7fb814a3e", "Moderator", "MODERATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3ca625e3-0648-4d1b-a456-c1c6ee0e0da8"),
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "UserName" },
                values: new object[] { "a1c501b6-5a39-447a-bc6e-4532f6390fe7", "ERENYEAGER", "ErenYeager" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("71a7ed13-227f-4a94-aa9a-c0813c60f602"),
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "UserName" },
                values: new object[] { "27ab816e-f800-4d66-8ac0-905ab5ae62fa", "MIKASAACKERMAN", "MikasaAckerman" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9b0795d2-46f0-493f-b37a-f80cc4700976"),
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "UserName" },
                values: new object[] { "02ec06e9-af2e-435f-b221-e47469fd01c3", "ARMINARLERT", "ArminArlert" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a6a707c8-9d67-4b36-8036-86e085670b36"),
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "UserName" },
                values: new object[] { "7ab4be62-fcbf-43e1-88b0-9c4c949ccab5", "ERWINSMITH", "ErwinSmith" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fc4ce336-fac9-49dc-88f6-f60ff4231985"),
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "UserName" },
                values: new object[] { "cd5a0cfc-5d4a-4f70-8c8c-accfb0b6f033", "LEVILEVI", "LeviLevi" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1af0b708-0d7a-47f8-b0d7-76a369fbe344"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("29c36e40-9c9f-456e-9fd0-7c8a804d7afa"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a5a501dc-8dc4-49ab-854b-1bbdfb33ac46"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e446f4c8-868b-40b0-9f94-89ed56bc556f"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedAt", "LastUpdatedAt", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("a5e3ec25-c31d-4362-8e69-0e4d1a8b486a"), "f8abbc53-373c-4135-b2e5-55f4c9f56a78", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Contributor", "CONTRIBUTOR" },
                    { new Guid("e50caf86-d3af-47ce-a09e-2b0bb5d565eb"), "3624e941-8905-4742-8795-e289f1142d2b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Moderator", "MODERATOR" },
                    { new Guid("e798d498-29b9-4672-a2a2-4c45ba028788"), "1eb4fe79-6929-4271-a899-1c931caa2a7a", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Member", "MEMBER" },
                    { new Guid("f607b058-01e6-409c-be9b-990606f487c5"), "4ad22e1b-eea0-4d57-93e8-360e45d96530", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3ca625e3-0648-4d1b-a456-c1c6ee0e0da8"),
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "UserName" },
                values: new object[] { "bde69f3e-5cac-4aef-a404-e924c85487f0", null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("71a7ed13-227f-4a94-aa9a-c0813c60f602"),
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "UserName" },
                values: new object[] { "0ec18281-41d8-44f9-b106-9e7f7fcbcd07", null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9b0795d2-46f0-493f-b37a-f80cc4700976"),
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "UserName" },
                values: new object[] { "0bcc75cb-032a-49ae-9010-8be2c8b6a881", null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a6a707c8-9d67-4b36-8036-86e085670b36"),
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "UserName" },
                values: new object[] { "98dedf5c-c006-4489-b283-e431fd541ac8", null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fc4ce336-fac9-49dc-88f6-f60ff4231985"),
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "UserName" },
                values: new object[] { "dfae3e13-d5f4-47bc-b309-2dfbc1b96ab8", null, null });
        }
    }
}
