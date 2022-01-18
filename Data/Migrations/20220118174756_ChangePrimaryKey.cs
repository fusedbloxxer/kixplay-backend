using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KixPlay_Backend.Data.Migrations
{
    public partial class ChangePrimaryKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRoles",
                table: "UserRoles");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("2992ef1e-2788-48cd-b4f7-5b2d86f29e49"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("2fdfd55f-f60f-4e0c-8a18-636b2d4ff3ca"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("7ff96310-b542-4912-b170-b77ea4909406"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("df07db7b-924b-48ea-88b3-b9dcfb68dd61"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 18, 19, 47, 55, 854, DateTimeKind.Local).AddTicks(6233),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 1, 18, 19, 36, 52, 216, DateTimeKind.Local).AddTicks(1989));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 18, 19, 47, 55, 854, DateTimeKind.Local).AddTicks(6504),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 18, 19, 47, 55, 854, DateTimeKind.Local).AddTicks(6406),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRoles",
                table: "UserRoles",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("06fda579-8990-48c7-99ac-46b2ba2fa886"), "b3529e9b-823f-4e15-a012-0f4a3c00831a", "Contributor", "CONTRIBUTOR" },
                    { new Guid("65610625-1cd0-40b4-9df3-998fdab3a3ad"), "5136776d-901c-47c8-9e8d-9d1b2b7d0491", "Moderator", "MODERATOR" },
                    { new Guid("88983a3e-d0cb-4cfb-b76e-a3e0d828e7ce"), "86ab3f33-9b3f-49af-bc2b-2a4242932458", "Member", "MEMBER" },
                    { new Guid("feee86ad-ecd5-4e5d-97f5-fbe17a7bc7e4"), "250082d2-aa82-4b46-998b-b150aad58e0a", "Admin", "ADMIN" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserId",
                table: "UserRoles",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                defaultValue: new DateTime(2022, 1, 18, 19, 36, 52, 216, DateTimeKind.Local).AddTicks(1989),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 1, 18, 19, 47, 55, 854, DateTimeKind.Local).AddTicks(6233));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "UserRoles",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 1, 18, 19, 47, 55, 854, DateTimeKind.Local).AddTicks(6504));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 1, 18, 19, 47, 55, 854, DateTimeKind.Local).AddTicks(6406));

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRoles",
                table: "UserRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedAt", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("2992ef1e-2788-48cd-b4f7-5b2d86f29e49"), "d30c3b77-253b-46ea-ad1f-c3352a520d30", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Contributor", "CONTRIBUTOR" },
                    { new Guid("2fdfd55f-f60f-4e0c-8a18-636b2d4ff3ca"), "f9b800b7-ff06-4286-9d23-580b4f67e12d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "ADMIN" },
                    { new Guid("7ff96310-b542-4912-b170-b77ea4909406"), "14ea46e6-c508-4915-9961-394c8025adca", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Member", "MEMBER" },
                    { new Guid("df07db7b-924b-48ea-88b3-b9dcfb68dd61"), "0c087c3e-9412-43cd-8218-7400195a5aa4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Moderator", "MODERATOR" }
                });
        }
    }
}
