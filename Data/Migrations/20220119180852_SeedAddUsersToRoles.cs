using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KixPlay_Backend.Data.Migrations
{
    public partial class SeedAddUsersToRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("8c6d9a31-3e47-45b5-b940-9225fa539f15"), "dd6d4222-1f6a-496c-b72c-086eb55d260c", "Admin", "ADMIN" },
                    { new Guid("8e7640e4-8701-46e5-85b9-596e03db2944"), "d789d9ca-500f-43f7-8ac3-6f9328bbaed1", "Contributor", "CONTRIBUTOR" },
                    { new Guid("92215649-862e-4c2f-a4c6-1c61cb245ad5"), "04cd9844-ba25-4e29-8525-57dd54824a2f", "Member", "MEMBER" },
                    { new Guid("e98fc490-4589-4beb-a316-add18c8f3ddf"), "0528916f-9872-466e-956f-abb15dd5276c", "Moderator", "MODERATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3ca625e3-0648-4d1b-a456-c1c6ee0e0da8"),
                column: "ConcurrencyStamp",
                value: "9f59fc18-fdea-4f21-bdb3-d11dd49a76ad");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("71a7ed13-227f-4a94-aa9a-c0813c60f602"),
                column: "ConcurrencyStamp",
                value: "24d2365e-585c-4282-9170-95e1b189bc16");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9b0795d2-46f0-493f-b37a-f80cc4700976"),
                column: "ConcurrencyStamp",
                value: "4da668cb-6930-409d-ae94-364bbe953883");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a6a707c8-9d67-4b36-8036-86e085670b36"),
                column: "ConcurrencyStamp",
                value: "1c03c554-eac0-4ac2-a151-935e2ee288a9");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fc4ce336-fac9-49dc-88f6-f60ff4231985"),
                column: "ConcurrencyStamp",
                value: "2652abc1-a60d-4591-b15a-06155f4b4bc3");

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId", "CreatedAt", "LastUpdatedAt" },
                values: new object[,]
                {
                    { new Guid("92215649-862e-4c2f-a4c6-1c61cb245ad5"), new Guid("3ca625e3-0648-4d1b-a456-c1c6ee0e0da8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("92215649-862e-4c2f-a4c6-1c61cb245ad5"), new Guid("71a7ed13-227f-4a94-aa9a-c0813c60f602"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("92215649-862e-4c2f-a4c6-1c61cb245ad5"), new Guid("9b0795d2-46f0-493f-b37a-f80cc4700976"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8c6d9a31-3e47-45b5-b940-9225fa539f15"), new Guid("a6a707c8-9d67-4b36-8036-86e085670b36"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("92215649-862e-4c2f-a4c6-1c61cb245ad5"), new Guid("a6a707c8-9d67-4b36-8036-86e085670b36"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("92215649-862e-4c2f-a4c6-1c61cb245ad5"), new Guid("fc4ce336-fac9-49dc-88f6-f60ff4231985"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8e7640e4-8701-46e5-85b9-596e03db2944"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e98fc490-4589-4beb-a316-add18c8f3ddf"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("92215649-862e-4c2f-a4c6-1c61cb245ad5"), new Guid("3ca625e3-0648-4d1b-a456-c1c6ee0e0da8") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("92215649-862e-4c2f-a4c6-1c61cb245ad5"), new Guid("71a7ed13-227f-4a94-aa9a-c0813c60f602") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("92215649-862e-4c2f-a4c6-1c61cb245ad5"), new Guid("9b0795d2-46f0-493f-b37a-f80cc4700976") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8c6d9a31-3e47-45b5-b940-9225fa539f15"), new Guid("a6a707c8-9d67-4b36-8036-86e085670b36") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("92215649-862e-4c2f-a4c6-1c61cb245ad5"), new Guid("a6a707c8-9d67-4b36-8036-86e085670b36") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("92215649-862e-4c2f-a4c6-1c61cb245ad5"), new Guid("fc4ce336-fac9-49dc-88f6-f60ff4231985") });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8c6d9a31-3e47-45b5-b940-9225fa539f15"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("92215649-862e-4c2f-a4c6-1c61cb245ad5"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedAt", "LastUpdatedAt", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("1af0b708-0d7a-47f8-b0d7-76a369fbe344"), "80121f7a-afcc-4c08-ad68-44a55f93f0bd", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "ADMIN" },
                    { new Guid("29c36e40-9c9f-456e-9fd0-7c8a804d7afa"), "b7aab21f-759f-43e2-8158-427378f66c24", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Member", "MEMBER" },
                    { new Guid("a5a501dc-8dc4-49ab-854b-1bbdfb33ac46"), "dc44bba3-e723-4308-b10e-e5c4370dfde5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Contributor", "CONTRIBUTOR" },
                    { new Guid("e446f4c8-868b-40b0-9f94-89ed56bc556f"), "0c7474a9-bc4e-4b5f-881b-f4d7fb814a3e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Moderator", "MODERATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3ca625e3-0648-4d1b-a456-c1c6ee0e0da8"),
                column: "ConcurrencyStamp",
                value: "a1c501b6-5a39-447a-bc6e-4532f6390fe7");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("71a7ed13-227f-4a94-aa9a-c0813c60f602"),
                column: "ConcurrencyStamp",
                value: "27ab816e-f800-4d66-8ac0-905ab5ae62fa");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9b0795d2-46f0-493f-b37a-f80cc4700976"),
                column: "ConcurrencyStamp",
                value: "02ec06e9-af2e-435f-b221-e47469fd01c3");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a6a707c8-9d67-4b36-8036-86e085670b36"),
                column: "ConcurrencyStamp",
                value: "7ab4be62-fcbf-43e1-88b0-9c4c949ccab5");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fc4ce336-fac9-49dc-88f6-f60ff4231985"),
                column: "ConcurrencyStamp",
                value: "cd5a0cfc-5d4a-4f70-8c8c-accfb0b6f033");
        }
    }
}
