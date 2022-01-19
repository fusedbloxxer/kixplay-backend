using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KixPlay_Backend.Data.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("541634b0-19f4-4ec7-8f5a-5a2864c82f5f"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6cba6777-0b8f-46e6-9d56-db40077f0eaa"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6dd2ed9f-ef4d-4903-b4af-da382fdabe4c"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("7769b68f-9495-4442-852a-c0dbe3628984"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("2c5a4336-5897-4280-8821-62e088758f5c"), "81d7708c-1bb7-4bdf-8693-2de25f376323", "Member", "MEMBER" },
                    { new Guid("4c1d70af-468b-4d05-9f84-a46fcea08ae1"), "f14c191b-a4f6-478d-a63a-b23d6bc50771", "Contributor", "CONTRIBUTOR" },
                    { new Guid("7ef0287e-f22b-434b-b59c-6e23f339abf3"), "a2284cf3-d42b-4fdc-a749-880445153253", "Moderator", "MODERATOR" },
                    { new Guid("b843cf77-4877-4b2f-b961-9dfa76c92b03"), "2f6d748f-78e3-42d7-8f5d-30f6b2f3dcc0", "Admin", "ADMIN" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("2c5a4336-5897-4280-8821-62e088758f5c"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("4c1d70af-468b-4d05-9f84-a46fcea08ae1"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("7ef0287e-f22b-434b-b59c-6e23f339abf3"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b843cf77-4877-4b2f-b961-9dfa76c92b03"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedAt", "LastUpdatedAt", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("541634b0-19f4-4ec7-8f5a-5a2864c82f5f"), "b12131e0-20dc-47c2-a9ae-9837a90a0a63", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Moderator", "MODERATOR" },
                    { new Guid("6cba6777-0b8f-46e6-9d56-db40077f0eaa"), "12d4c39d-8ed9-452c-a984-99625474befd", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Contributor", "CONTRIBUTOR" },
                    { new Guid("6dd2ed9f-ef4d-4903-b4af-da382fdabe4c"), "11daa95c-5e74-42b8-8647-663346b9b9ec", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Member", "MEMBER" },
                    { new Guid("7769b68f-9495-4442-852a-c0dbe3628984"), "219d4197-8a47-4f00-9ebc-d38bb30ddc3d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "ADMIN" }
                });
        }
    }
}
