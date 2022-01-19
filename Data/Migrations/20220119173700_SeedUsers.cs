using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KixPlay_Backend.Data.Migrations
{
    public partial class SeedUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("785fb371-e93a-40fd-b1b6-b6c4723c2d71"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("9d82a50c-d0ea-4408-a0fd-bd68eb3a3897"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("da901306-4172-4a38-a619-f26c574a6bf0"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ed1237cc-1a4c-40c4-9f9a-622b9b127e7f"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("1708e2f4-40e9-4cb2-bd7f-b5014228b20a"), "4fedafb0-a8ab-4d84-8828-7f46a073806e", "Admin", "ADMIN" },
                    { new Guid("348726da-395c-47de-96d1-d448be7c168d"), "f5374193-7fc8-41a0-a7e4-0e72d4d8ce8f", "Member", "MEMBER" },
                    { new Guid("38590fcb-f8d0-40d6-a7fd-52b0f0c37860"), "41070366-9de1-43b6-ab13-470948c596f7", "Moderator", "MODERATOR" },
                    { new Guid("8feb1e02-7031-44fa-be32-c72f8d7a9093"), "9b1350c9-1380-466b-8653-5b49f93029c0", "Contributor", "CONTRIBUTOR" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("3ca625e3-0648-4d1b-a456-c1c6ee0e0da8"), 0, "928a6e28-dfbf-4212-bb8b-d026aa656024", new DateTime(1995, 1, 19, 0, 0, 0, 0, DateTimeKind.Local), null, false, "Eren", "Yeager", false, null, null, null, null, null, false, null, false, null },
                    { new Guid("71a7ed13-227f-4a94-aa9a-c0813c60f602"), 0, "96700734-afbf-4121-895c-693038bd5e33", new DateTime(1998, 1, 19, 0, 0, 0, 0, DateTimeKind.Local), null, false, "Mikasa", "Ackerman", false, null, null, null, null, null, false, null, false, null },
                    { new Guid("9b0795d2-46f0-493f-b37a-f80cc4700976"), 0, "3190038d-b638-4f66-8459-31c79a81eab2", new DateTime(2004, 1, 19, 0, 0, 0, 0, DateTimeKind.Local), null, false, "Armin", "Arlert", false, null, null, null, null, null, false, null, false, null },
                    { new Guid("a6a707c8-9d67-4b36-8036-86e085670b36"), 0, "e5b0c7f9-e4d4-4942-8a08-bfb08351e4e8", new DateTime(2000, 1, 19, 0, 0, 0, 0, DateTimeKind.Local), null, false, "Erwin", "Smith", false, null, null, null, null, null, false, null, false, null },
                    { new Guid("fc4ce336-fac9-49dc-88f6-f60ff4231985"), 0, "95ff2135-39e5-4de2-afe2-39f73854fd2f", new DateTime(1997, 1, 19, 0, 0, 0, 0, DateTimeKind.Local), null, false, "Levi", null, false, null, null, null, null, null, false, null, false, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1708e2f4-40e9-4cb2-bd7f-b5014228b20a"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("348726da-395c-47de-96d1-d448be7c168d"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("38590fcb-f8d0-40d6-a7fd-52b0f0c37860"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8feb1e02-7031-44fa-be32-c72f8d7a9093"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3ca625e3-0648-4d1b-a456-c1c6ee0e0da8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("71a7ed13-227f-4a94-aa9a-c0813c60f602"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9b0795d2-46f0-493f-b37a-f80cc4700976"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a6a707c8-9d67-4b36-8036-86e085670b36"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fc4ce336-fac9-49dc-88f6-f60ff4231985"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedAt", "LastUpdatedAt", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("785fb371-e93a-40fd-b1b6-b6c4723c2d71"), "466e996a-fa65-4e38-9b28-35ad560ed129", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "ADMIN" },
                    { new Guid("9d82a50c-d0ea-4408-a0fd-bd68eb3a3897"), "31267b11-b1a5-458a-a0a6-463faa8613ef", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Contributor", "CONTRIBUTOR" },
                    { new Guid("da901306-4172-4a38-a619-f26c574a6bf0"), "49547210-e5c8-4730-80d0-3328fbc9dd2e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Member", "MEMBER" },
                    { new Guid("ed1237cc-1a4c-40c4-9f9a-622b9b127e7f"), "6402d309-1217-4eee-a76e-22af2eb1ca72", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Moderator", "MODERATOR" }
                });
        }
    }
}
