using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KixPlay_Backend.Data.Migrations
{
    public partial class KeepTwoKeysForUserRoleInternals : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRoles",
                table: "UserRoles");

            migrationBuilder.DropIndex(
                name: "IX_UserRoles_UserId",
                table: "UserRoles");

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

            migrationBuilder.DropColumn(
                name: "Id",
                table: "UserRoles");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "UserRoles");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 18, 20, 3, 16, 280, DateTimeKind.Local).AddTicks(3287),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 1, 18, 19, 58, 10, 80, DateTimeKind.Local).AddTicks(5731));

            migrationBuilder.AddColumn<DateTime>(
                name: "AddedAt",
                table: "UserRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 18, 20, 3, 16, 280, DateTimeKind.Local).AddTicks(3585));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 18, 20, 3, 16, 280, DateTimeKind.Local).AddTicks(3480),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 1, 18, 19, 58, 10, 80, DateTimeKind.Local).AddTicks(5901));

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRoles",
                table: "UserRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("5c598e20-5a61-4e58-87e2-c469c50b6c15"), "3635bdc6-dcd4-4fc7-a35d-57ea9ab3b9f4", "Moderator", "MODERATOR" },
                    { new Guid("6be2ead8-61d6-4ec1-9197-a5258d58ccc6"), "0494848e-cff4-4b64-b009-7aa053a02b7f", "Contributor", "CONTRIBUTOR" },
                    { new Guid("aa6ea8ce-f0b0-4dc9-a71e-784d2d59f1b4"), "c36e1e37-7a38-4b41-aacb-217b6457873e", "Admin", "ADMIN" },
                    { new Guid("f2e8f759-0bc3-464c-b02d-fad41584addd"), "1d79dca7-737c-4a90-b2dd-a41c7283881c", "Member", "MEMBER" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRoles",
                table: "UserRoles");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("5c598e20-5a61-4e58-87e2-c469c50b6c15"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6be2ead8-61d6-4ec1-9197-a5258d58ccc6"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("aa6ea8ce-f0b0-4dc9-a71e-784d2d59f1b4"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("f2e8f759-0bc3-464c-b02d-fad41584addd"));

            migrationBuilder.DropColumn(
                name: "AddedAt",
                table: "UserRoles");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 18, 19, 58, 10, 80, DateTimeKind.Local).AddTicks(5731),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 1, 18, 20, 3, 16, 280, DateTimeKind.Local).AddTicks(3287));

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "UserRoles",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "UserRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 18, 19, 58, 10, 80, DateTimeKind.Local).AddTicks(6046));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 18, 19, 58, 10, 80, DateTimeKind.Local).AddTicks(5901),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 1, 18, 20, 3, 16, 280, DateTimeKind.Local).AddTicks(3480));

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRoles",
                table: "UserRoles",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedAt", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("355cf7c9-c71f-4e72-a934-9e680525eedc"), "7a2328e0-f708-4768-ab79-2cfc5c121eb5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Moderator", "MODERATOR" },
                    { new Guid("73a44695-23eb-4e20-9f96-1696bb097006"), "9ad91d6a-122c-40f9-910b-f43e4455f0f6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Member", "MEMBER" },
                    { new Guid("b5623523-1eb1-41e1-b574-1aca5438c5f5"), "3fe3b91a-8e0f-4249-bde8-e2335d00bb73", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "ADMIN" },
                    { new Guid("da4b13e7-2dc1-4dbc-a51a-b15af2c42b94"), "c1b06c90-95c5-4151-b772-015c5cea7f77", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Contributor", "CONTRIBUTOR" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserId",
                table: "UserRoles",
                column: "UserId");
        }
    }
}
