using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KixPlay_Backend.Data.Migrations
{
    public partial class SeedUsersWithPassHash : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("a5e3ec25-c31d-4362-8e69-0e4d1a8b486a"), "f8abbc53-373c-4135-b2e5-55f4c9f56a78", "Contributor", "CONTRIBUTOR" },
                    { new Guid("e50caf86-d3af-47ce-a09e-2b0bb5d565eb"), "3624e941-8905-4742-8795-e289f1142d2b", "Moderator", "MODERATOR" },
                    { new Guid("e798d498-29b9-4672-a2a2-4c45ba028788"), "1eb4fe79-6929-4271-a899-1c931caa2a7a", "Member", "MEMBER" },
                    { new Guid("f607b058-01e6-409c-be9b-990606f487c5"), "4ad22e1b-eea0-4d57-93e8-360e45d96530", "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3ca625e3-0648-4d1b-a456-c1c6ee0e0da8"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash" },
                values: new object[] { "bde69f3e-5cac-4aef-a404-e924c85487f0", "eren.yeager@gmail.com", "EREN.YEAGER@GMAIL.COM", "AQAAAAEAACcQAAAAEEbyCLf0/2GiiFd4R5D9mAIjPW2Coeg095H59UongM3Osns/UWXnDJ2Rub5PFO9+JQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("71a7ed13-227f-4a94-aa9a-c0813c60f602"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash" },
                values: new object[] { "0ec18281-41d8-44f9-b106-9e7f7fcbcd07", "mikasa.ackerman@gmail.com", "MIKASA.ACKERMAN@GMAIL.COM", "AQAAAAEAACcQAAAAEEbyCLf0/2GiiFd4R5D9mAIjPW2Coeg095H59UongM3Osns/UWXnDJ2Rub5PFO9+JQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9b0795d2-46f0-493f-b37a-f80cc4700976"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash" },
                values: new object[] { "0bcc75cb-032a-49ae-9010-8be2c8b6a881", "armin.arlert@gmail.com", "ARMIN.ARLERT@GMAIL.COM", "AQAAAAEAACcQAAAAEEbyCLf0/2GiiFd4R5D9mAIjPW2Coeg095H59UongM3Osns/UWXnDJ2Rub5PFO9+JQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a6a707c8-9d67-4b36-8036-86e085670b36"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash" },
                values: new object[] { "98dedf5c-c006-4489-b283-e431fd541ac8", "eren.smith@gmail.com", "EREN.SMITH@GMAIL.COM", "AQAAAAEAACcQAAAAEEbyCLf0/2GiiFd4R5D9mAIjPW2Coeg095H59UongM3Osns/UWXnDJ2Rub5PFO9+JQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fc4ce336-fac9-49dc-88f6-f60ff4231985"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash" },
                values: new object[] { "dfae3e13-d5f4-47bc-b309-2dfbc1b96ab8", "levi.ivel@gmail.com", "LEVI.IVEL@GMAIL.COM", "AQAAAAEAACcQAAAAEEbyCLf0/2GiiFd4R5D9mAIjPW2Coeg095H59UongM3Osns/UWXnDJ2Rub5PFO9+JQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedAt", "LastUpdatedAt", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("1708e2f4-40e9-4cb2-bd7f-b5014228b20a"), "4fedafb0-a8ab-4d84-8828-7f46a073806e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "ADMIN" },
                    { new Guid("348726da-395c-47de-96d1-d448be7c168d"), "f5374193-7fc8-41a0-a7e4-0e72d4d8ce8f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Member", "MEMBER" },
                    { new Guid("38590fcb-f8d0-40d6-a7fd-52b0f0c37860"), "41070366-9de1-43b6-ab13-470948c596f7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Moderator", "MODERATOR" },
                    { new Guid("8feb1e02-7031-44fa-be32-c72f8d7a9093"), "9b1350c9-1380-466b-8653-5b49f93029c0", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Contributor", "CONTRIBUTOR" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3ca625e3-0648-4d1b-a456-c1c6ee0e0da8"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash" },
                values: new object[] { "928a6e28-dfbf-4212-bb8b-d026aa656024", null, null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("71a7ed13-227f-4a94-aa9a-c0813c60f602"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash" },
                values: new object[] { "96700734-afbf-4121-895c-693038bd5e33", null, null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9b0795d2-46f0-493f-b37a-f80cc4700976"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash" },
                values: new object[] { "3190038d-b638-4f66-8459-31c79a81eab2", null, null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a6a707c8-9d67-4b36-8036-86e085670b36"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash" },
                values: new object[] { "e5b0c7f9-e4d4-4942-8a08-bfb08351e4e8", null, null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fc4ce336-fac9-49dc-88f6-f60ff4231985"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash" },
                values: new object[] { "95ff2135-39e5-4de2-afe2-39f73854fd2f", null, null, null });
        }
    }
}
