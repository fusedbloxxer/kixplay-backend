using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KixPlay_Backend.Data.Migrations
{
    public partial class SeedMediaSources : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MediaSources",
                columns: new[] { "Id", "MediaId", "SourceId", "Url" },
                values: new object[,]
                {
                    { new Guid("2f5ba7de-9a8f-434b-a61e-764dfe656bfb"), new Guid("0c36c9b3-d576-4213-8318-49e1882daa38"), new Guid("4a022ad0-e6e6-4df3-9b95-bf1aa05db9df"), "https://filmeserialegratis.org/fractured/" },
                    { new Guid("f0c5a927-2ac3-4fd9-b31b-88b4d377325d"), new Guid("e33f7813-258e-4c6c-bf4a-06bfdcdd1095"), new Guid("4a022ad0-e6e6-4df3-9b95-bf1aa05db9df"), "https://filmeserialegratis.org/the-invitation-invitatia/" }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8c6d9a31-3e47-45b5-b940-9225fa539f15"),
                column: "ConcurrencyStamp",
                value: "07185fe7-4b15-49dc-b209-84398c90d5b7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8e7640e4-8701-46e5-85b9-596e03db2944"),
                column: "ConcurrencyStamp",
                value: "5100986f-740d-4950-8dba-8d279d49c122");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("92215649-862e-4c2f-a4c6-1c61cb245ad5"),
                column: "ConcurrencyStamp",
                value: "ef1a2f67-3abb-4205-8bcb-f35bfc929936");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e98fc490-4589-4beb-a316-add18c8f3ddf"),
                column: "ConcurrencyStamp",
                value: "e1aedf32-6b50-46ef-b803-566adb78658a");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3ca625e3-0648-4d1b-a456-c1c6ee0e0da8"),
                column: "ConcurrencyStamp",
                value: "8f2f7297-514b-4e88-a12f-d1801be8c3c5");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("71a7ed13-227f-4a94-aa9a-c0813c60f602"),
                column: "ConcurrencyStamp",
                value: "c5b96a11-e30e-406c-8409-0020c6b4d8ac");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9b0795d2-46f0-493f-b37a-f80cc4700976"),
                column: "ConcurrencyStamp",
                value: "f22c7556-24fe-407a-ad94-91eed1a4c44f");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a6a707c8-9d67-4b36-8036-86e085670b36"),
                column: "ConcurrencyStamp",
                value: "4e4c42cf-0287-4464-8712-9d725d717d55");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fc4ce336-fac9-49dc-88f6-f60ff4231985"),
                column: "ConcurrencyStamp",
                value: "0f416b8f-26e7-4725-a7ab-51ddaf25e8fc");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MediaSources",
                keyColumn: "Id",
                keyValue: new Guid("2f5ba7de-9a8f-434b-a61e-764dfe656bfb"));

            migrationBuilder.DeleteData(
                table: "MediaSources",
                keyColumn: "Id",
                keyValue: new Guid("f0c5a927-2ac3-4fd9-b31b-88b4d377325d"));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8c6d9a31-3e47-45b5-b940-9225fa539f15"),
                column: "ConcurrencyStamp",
                value: "f48ac4fe-ff22-4c95-9f24-a971d2d62ae8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8e7640e4-8701-46e5-85b9-596e03db2944"),
                column: "ConcurrencyStamp",
                value: "24b1f082-676c-4b30-be16-b9afcda227c7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("92215649-862e-4c2f-a4c6-1c61cb245ad5"),
                column: "ConcurrencyStamp",
                value: "d76f3421-f0d2-41d9-97f6-803ceb5c2492");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e98fc490-4589-4beb-a316-add18c8f3ddf"),
                column: "ConcurrencyStamp",
                value: "50cd1aae-bacf-4b0f-94ec-60af05907a78");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3ca625e3-0648-4d1b-a456-c1c6ee0e0da8"),
                column: "ConcurrencyStamp",
                value: "e801b19e-fbde-430f-8af4-469ba673f6b5");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("71a7ed13-227f-4a94-aa9a-c0813c60f602"),
                column: "ConcurrencyStamp",
                value: "00891ca4-b132-4656-a6ec-638faf1a5c9c");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9b0795d2-46f0-493f-b37a-f80cc4700976"),
                column: "ConcurrencyStamp",
                value: "7f60e0e4-ba9a-4398-ba12-4c302ffb4cf3");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a6a707c8-9d67-4b36-8036-86e085670b36"),
                column: "ConcurrencyStamp",
                value: "ca612520-9df0-4685-9ad4-41876d27e7a9");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fc4ce336-fac9-49dc-88f6-f60ff4231985"),
                column: "ConcurrencyStamp",
                value: "c45b9e3e-b005-4c73-a26c-5b87bf65b98c");
        }
    }
}
