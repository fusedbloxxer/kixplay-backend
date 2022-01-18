using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KixPlay_Backend.Data.Migrations
{
    public partial class AddUserTimestamp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("012be97b-1239-4b5b-bdec-604ddb47aff8"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("25d6b8cd-19c0-4308-9cef-f57cde8928de"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c3c45ac9-f93d-4da0-8bad-d0b0a2e799ab"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ec7022cc-686b-4d38-9626-f3fd4741e11a"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 1, 18, 19, 36, 52, 216, DateTimeKind.Local).AddTicks(1989),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 1, 18, 19, 36, 52, 216, DateTimeKind.Local).AddTicks(1989));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedAt", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("012be97b-1239-4b5b-bdec-604ddb47aff8"), "06a57bbd-5d84-4ee0-ae3e-ca311154f270", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Member", "MEMBER" },
                    { new Guid("25d6b8cd-19c0-4308-9cef-f57cde8928de"), "0b182a05-1e2c-4671-911f-5b2d3961a8a2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "ADMIN" },
                    { new Guid("c3c45ac9-f93d-4da0-8bad-d0b0a2e799ab"), "32fbb40d-b624-4dba-b0eb-f2c69e5e2823", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Moderator", "MODERATOR" },
                    { new Guid("ec7022cc-686b-4d38-9626-f3fd4741e11a"), "d8a62103-81ae-4fc6-ab27-303c5dfb4744", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Contributor", "CONTRIBUTOR" }
                });
        }
    }
}
