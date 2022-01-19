using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KixPlay_Backend.Data.Migrations
{
    public partial class SeedSources : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8c6d9a31-3e47-45b5-b940-9225fa539f15"),
                column: "ConcurrencyStamp",
                value: "d2ad14d1-c41b-47f0-917f-b4f5932b8c6b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8e7640e4-8701-46e5-85b9-596e03db2944"),
                column: "ConcurrencyStamp",
                value: "ac834aee-7acc-4d8f-aebb-d21350eb74a2");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("92215649-862e-4c2f-a4c6-1c61cb245ad5"),
                column: "ConcurrencyStamp",
                value: "ab0f3f93-411b-4cd8-a07e-0979861ea331");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e98fc490-4589-4beb-a316-add18c8f3ddf"),
                column: "ConcurrencyStamp",
                value: "b8d85e07-f294-4d3f-bc6b-e094e1a59a7b");

            migrationBuilder.InsertData(
                table: "Sources",
                columns: new[] { "Id", "Description", "Reliable", "ThumbnailUrl", "Title", "Url" },
                values: new object[,]
                {
                    { new Guid("4a022ad0-e6e6-4df3-9b95-bf1aa05db9df"), "FSGratis este un site complet gratuit care contine link-uri catre site-uri de video sharing, mai exact site-uri ce gazduiesc fisiere video, filme, seriale si asa mai departe.", "Trustworthy", "https://filmeserialegratis.org/wp-content/uploads/2019/09/logofsgratis-2.png", "FSGratis", "https://filmeserialegratis.org/" },
                    { new Guid("a573321a-5c27-4ba9-9903-ee00ca56b4c0"), "Animepahe is a popular website for anime lovers. You can watch thousands of free anime from Drama, History, Action, Romance and more. Animepahe is confident ...", "Sussy", "http://wasabi-files.lbstatic.nu/files/users/large/9666248_logo-animepahe.jpg?1629794131", "AnimePahe", "https://animepahe.com/" },
                    { new Guid("eee0f7d1-9080-452e-97e6-7773190a59a8"), "Watch Anime for free in HD quality with English subbed or dubbed.", "Trustworthy", "https://i.imgur.com/RO2x9O5.png", "AnimixPlay", "https://animixplay.to/" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3ca625e3-0648-4d1b-a456-c1c6ee0e0da8"),
                column: "ConcurrencyStamp",
                value: "a2cc8b09-46fb-4209-846d-569043319b89");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("71a7ed13-227f-4a94-aa9a-c0813c60f602"),
                column: "ConcurrencyStamp",
                value: "47bba5aa-3262-41bb-ab03-53b9918516fa");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9b0795d2-46f0-493f-b37a-f80cc4700976"),
                column: "ConcurrencyStamp",
                value: "6dfc70c1-ba35-49b5-ac56-79eff8d12e16");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a6a707c8-9d67-4b36-8036-86e085670b36"),
                column: "ConcurrencyStamp",
                value: "f19e122f-35db-4dd2-a42f-a7dc751af646");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fc4ce336-fac9-49dc-88f6-f60ff4231985"),
                column: "ConcurrencyStamp",
                value: "b7f6d0cc-fe1a-4bce-a9dc-c724b57468ca");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("4a022ad0-e6e6-4df3-9b95-bf1aa05db9df"));

            migrationBuilder.DeleteData(
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("a573321a-5c27-4ba9-9903-ee00ca56b4c0"));

            migrationBuilder.DeleteData(
                table: "Sources",
                keyColumn: "Id",
                keyValue: new Guid("eee0f7d1-9080-452e-97e6-7773190a59a8"));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8c6d9a31-3e47-45b5-b940-9225fa539f15"),
                column: "ConcurrencyStamp",
                value: "70995688-b60c-4222-bced-c09d3ae35e4a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8e7640e4-8701-46e5-85b9-596e03db2944"),
                column: "ConcurrencyStamp",
                value: "a65f5064-3265-4ca4-a39a-c69beb708d5c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("92215649-862e-4c2f-a4c6-1c61cb245ad5"),
                column: "ConcurrencyStamp",
                value: "d9b03a5d-c2c2-45b8-a4ae-ec2c86d5f154");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e98fc490-4589-4beb-a316-add18c8f3ddf"),
                column: "ConcurrencyStamp",
                value: "0f60d52c-2293-4823-81a6-4537c29a2d35");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3ca625e3-0648-4d1b-a456-c1c6ee0e0da8"),
                column: "ConcurrencyStamp",
                value: "b57e9819-c48b-48c9-8cfa-67f8626ae70d");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("71a7ed13-227f-4a94-aa9a-c0813c60f602"),
                column: "ConcurrencyStamp",
                value: "efd3be73-c38a-41a4-ae53-909300b7f573");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9b0795d2-46f0-493f-b37a-f80cc4700976"),
                column: "ConcurrencyStamp",
                value: "52def015-3572-4877-bca6-971b0750b1d1");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a6a707c8-9d67-4b36-8036-86e085670b36"),
                column: "ConcurrencyStamp",
                value: "44dfa717-5bc1-408d-9ccb-b88d372175fd");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fc4ce336-fac9-49dc-88f6-f60ff4231985"),
                column: "ConcurrencyStamp",
                value: "4f8b8b1a-e3fe-4d29-b7c5-88085fb28278");
        }
    }
}
