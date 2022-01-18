using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KixPlay_Backend.Data.Migrations
{
    public partial class AddUserRoleInverseRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("06fda579-8990-48c7-99ac-46b2ba2fa886"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("65610625-1cd0-40b4-9df3-998fdab3a3ad"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("88983a3e-d0cb-4cfb-b76e-a3e0d828e7ce"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("feee86ad-ecd5-4e5d-97f5-fbe17a7bc7e4"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 18, 19, 58, 10, 80, DateTimeKind.Local).AddTicks(5731),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 1, 18, 19, 47, 55, 854, DateTimeKind.Local).AddTicks(6233));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 18, 19, 58, 10, 80, DateTimeKind.Local).AddTicks(6046),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 1, 18, 19, 47, 55, 854, DateTimeKind.Local).AddTicks(6504));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 18, 19, 58, 10, 80, DateTimeKind.Local).AddTicks(5901),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 1, 18, 19, 47, 55, 854, DateTimeKind.Local).AddTicks(6406));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("355cf7c9-c71f-4e72-a934-9e680525eedc"), "7a2328e0-f708-4768-ab79-2cfc5c121eb5", "Moderator", "MODERATOR" },
                    { new Guid("73a44695-23eb-4e20-9f96-1696bb097006"), "9ad91d6a-122c-40f9-910b-f43e4455f0f6", "Member", "MEMBER" },
                    { new Guid("b5623523-1eb1-41e1-b574-1aca5438c5f5"), "3fe3b91a-8e0f-4249-bde8-e2335d00bb73", "Admin", "ADMIN" },
                    { new Guid("da4b13e7-2dc1-4dbc-a51a-b15af2c42b94"), "c1b06c90-95c5-4151-b772-015c5cea7f77", "Contributor", "CONTRIBUTOR" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("355cf7c9-c71f-4e72-a934-9e680525eedc"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("73a44695-23eb-4e20-9f96-1696bb097006"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b5623523-1eb1-41e1-b574-1aca5438c5f5"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("da4b13e7-2dc1-4dbc-a51a-b15af2c42b94"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 18, 19, 47, 55, 854, DateTimeKind.Local).AddTicks(6233),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 1, 18, 19, 58, 10, 80, DateTimeKind.Local).AddTicks(5731));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 18, 19, 47, 55, 854, DateTimeKind.Local).AddTicks(6504),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 1, 18, 19, 58, 10, 80, DateTimeKind.Local).AddTicks(6046));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 18, 19, 47, 55, 854, DateTimeKind.Local).AddTicks(6406),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 1, 18, 19, 58, 10, 80, DateTimeKind.Local).AddTicks(5901));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedAt", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("06fda579-8990-48c7-99ac-46b2ba2fa886"), "b3529e9b-823f-4e15-a012-0f4a3c00831a", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Contributor", "CONTRIBUTOR" },
                    { new Guid("65610625-1cd0-40b4-9df3-998fdab3a3ad"), "5136776d-901c-47c8-9e8d-9d1b2b7d0491", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Moderator", "MODERATOR" },
                    { new Guid("88983a3e-d0cb-4cfb-b76e-a3e0d828e7ce"), "86ab3f33-9b3f-49af-bc2b-2a4242932458", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Member", "MEMBER" },
                    { new Guid("feee86ad-ecd5-4e5d-97f5-fbe17a7bc7e4"), "250082d2-aa82-4b46-998b-b150aad58e0a", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "ADMIN" }
                });
        }
    }
}
