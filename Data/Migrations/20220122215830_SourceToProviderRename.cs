using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KixPlay_Backend.Data.Migrations
{
    public partial class SourceToProviderRename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MediaSources_Sources_SourceId",
                table: "MediaSources");

            migrationBuilder.DropTable(
                name: "Sources");

            migrationBuilder.DeleteData(
                table: "ReviewOpinions",
                keyColumn: "Id",
                keyValue: new Guid("01946419-c8d5-48e7-b0f9-6a0152e100dc"));

            migrationBuilder.DeleteData(
                table: "ReviewOpinions",
                keyColumn: "Id",
                keyValue: new Guid("1782add3-68b2-4ea1-966c-7b315846d59b"));

            migrationBuilder.DeleteData(
                table: "ReviewOpinions",
                keyColumn: "Id",
                keyValue: new Guid("5743484a-1092-4e71-8d86-76b909e65d50"));

            migrationBuilder.DeleteData(
                table: "ReviewOpinions",
                keyColumn: "Id",
                keyValue: new Guid("73146899-48ce-4bf7-98d2-d0162877a6cc"));

            migrationBuilder.DeleteData(
                table: "ReviewOpinions",
                keyColumn: "Id",
                keyValue: new Guid("9f34ad2f-0e8f-45c4-acd0-0ec1e05785e8"));

            migrationBuilder.DeleteData(
                table: "ReviewOpinions",
                keyColumn: "Id",
                keyValue: new Guid("a33d027b-1cfb-4462-86e1-e737ab9a8b86"));

            migrationBuilder.DeleteData(
                table: "ReviewOpinions",
                keyColumn: "Id",
                keyValue: new Guid("c773b79e-429b-40a4-a2c1-e2060737c025"));

            migrationBuilder.DeleteData(
                table: "ReviewOpinions",
                keyColumn: "Id",
                keyValue: new Guid("ea9ca8d6-6eb3-43a9-a958-a55238a7c918"));

            migrationBuilder.RenameColumn(
                name: "CurrentStatus",
                table: "Medias",
                newName: "AiringStatus");

            migrationBuilder.CreateTable(
                name: "Providers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThumbnailUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reliable = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Providers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Providers",
                columns: new[] { "Id", "Description", "Reliable", "ThumbnailUrl", "Title", "Url" },
                values: new object[,]
                {
                    { new Guid("4a022ad0-e6e6-4df3-9b95-bf1aa05db9df"), "FSGratis este un site complet gratuit care contine link-uri catre site-uri de video sharing, mai exact site-uri ce gazduiesc fisiere video, filme, seriale si asa mai departe.", "Trustworthy", "https://filmeserialegratis.org/wp-content/uploads/2019/09/logofsgratis-2.png", "FSGratis", "https://filmeserialegratis.org/" },
                    { new Guid("a573321a-5c27-4ba9-9903-ee00ca56b4c0"), "Animepahe is a popular website for anime lovers. You can watch thousands of free anime from Drama, History, Action, Romance and more. Animepahe is confident ...", "Sussy", "http://wasabi-files.lbstatic.nu/files/users/large/9666248_logo-animepahe.jpg?1629794131", "AnimePahe", "https://animepahe.com/" },
                    { new Guid("eee0f7d1-9080-452e-97e6-7773190a59a8"), "Watch Anime for free in HD quality with English subbed or dubbed.", "Trustworthy", "https://i.imgur.com/RO2x9O5.png", "AnimixPlay", "https://animixplay.to/" }
                });

            migrationBuilder.InsertData(
                table: "ReviewOpinions",
                columns: new[] { "Id", "IsInteresting", "ReviewId", "UserId" },
                values: new object[] { new Guid("4067c853-a885-416f-ac64-b4aebcf579a6"), true, new Guid("a2862e81-a1ff-4084-90dd-ce8827ce27e2"), new Guid("a6a707c8-9d67-4b36-8036-86e085670b36") });

            migrationBuilder.InsertData(
                table: "ReviewOpinions",
                columns: new[] { "Id", "IsFunny", "IsHelpful", "ReviewId", "UserId" },
                values: new object[] { new Guid("45ec2e0f-1aca-4acc-840d-4f839c5b8946"), true, true, new Guid("80d6a3a4-2209-41c5-a826-c2cd87dca72c"), new Guid("9b0795d2-46f0-493f-b37a-f80cc4700976") });

            migrationBuilder.InsertData(
                table: "ReviewOpinions",
                columns: new[] { "Id", "IsFunny", "ReviewId", "UserId" },
                values: new object[] { new Guid("4fc91403-a22b-49d6-b5a5-85d7c72bd043"), true, new Guid("80d6a3a4-2209-41c5-a826-c2cd87dca72c"), new Guid("3ca625e3-0648-4d1b-a456-c1c6ee0e0da8") });

            migrationBuilder.InsertData(
                table: "ReviewOpinions",
                columns: new[] { "Id", "IsHelpful", "IsInteresting", "ReviewId", "UserId" },
                values: new object[] { new Guid("58571ca2-55f3-45bf-bda6-49279241df6b"), true, true, new Guid("b2ed2f69-e6c7-482d-b146-ec7d14cde0fb"), new Guid("fc4ce336-fac9-49dc-88f6-f60ff4231985") });

            migrationBuilder.InsertData(
                table: "ReviewOpinions",
                columns: new[] { "Id", "ReviewId", "UserId" },
                values: new object[] { new Guid("a59f2261-d727-47cf-8db1-4fe5a0b53fb5"), new Guid("ab6f6d95-695d-41a2-9fc5-648bc83b16cb"), new Guid("71a7ed13-227f-4a94-aa9a-c0813c60f602") });

            migrationBuilder.InsertData(
                table: "ReviewOpinions",
                columns: new[] { "Id", "IsHelpful", "ReviewId", "UserId" },
                values: new object[] { new Guid("d541f4cf-7a4a-4d9d-902d-ed00c97051cc"), true, new Guid("ab6f6d95-695d-41a2-9fc5-648bc83b16cb"), new Guid("9b0795d2-46f0-493f-b37a-f80cc4700976") });

            migrationBuilder.InsertData(
                table: "ReviewOpinions",
                columns: new[] { "Id", "IsInteresting", "ReviewId", "UserId" },
                values: new object[] { new Guid("e15576a5-158f-445e-a00e-09e5d765383b"), true, new Guid("80d6a3a4-2209-41c5-a826-c2cd87dca72c"), new Guid("a6a707c8-9d67-4b36-8036-86e085670b36") });

            migrationBuilder.InsertData(
                table: "ReviewOpinions",
                columns: new[] { "Id", "IsHelpful", "ReviewId", "UserId" },
                values: new object[] { new Guid("fcffec49-06f9-48f8-a658-88b965fac617"), true, new Guid("2fe24bcb-afa2-42df-bf28-5ea04172e783"), new Guid("a6a707c8-9d67-4b36-8036-86e085670b36") });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8c6d9a31-3e47-45b5-b940-9225fa539f15"),
                column: "ConcurrencyStamp",
                value: "ab644c5d-20b4-46b4-bedd-548b82644153");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8e7640e4-8701-46e5-85b9-596e03db2944"),
                column: "ConcurrencyStamp",
                value: "16626d6d-419e-43c8-afda-7deeebf9114c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("92215649-862e-4c2f-a4c6-1c61cb245ad5"),
                column: "ConcurrencyStamp",
                value: "03294196-73a3-4344-adac-a36db38d8097");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e98fc490-4589-4beb-a316-add18c8f3ddf"),
                column: "ConcurrencyStamp",
                value: "af70a5a3-9c69-4ef6-89e7-ad2209c53cb3");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3ca625e3-0648-4d1b-a456-c1c6ee0e0da8"),
                columns: new[] { "ConcurrencyStamp", "DateOfBirth" },
                values: new object[] { "4cc75c9b-7a95-48a2-ba7f-0c5a3abdd9eb", new DateTime(1995, 1, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("71a7ed13-227f-4a94-aa9a-c0813c60f602"),
                columns: new[] { "ConcurrencyStamp", "DateOfBirth" },
                values: new object[] { "704db063-294b-4dfe-a018-e9a39a55512b", new DateTime(1998, 1, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9b0795d2-46f0-493f-b37a-f80cc4700976"),
                columns: new[] { "ConcurrencyStamp", "DateOfBirth" },
                values: new object[] { "9ebda168-0603-45f9-8bbf-0f2a782d21ef", new DateTime(2004, 1, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a6a707c8-9d67-4b36-8036-86e085670b36"),
                columns: new[] { "ConcurrencyStamp", "DateOfBirth" },
                values: new object[] { "fbe77512-cd9f-41af-9ea5-30a8dab82d13", new DateTime(2000, 1, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fc4ce336-fac9-49dc-88f6-f60ff4231985"),
                columns: new[] { "ConcurrencyStamp", "DateOfBirth" },
                values: new object[] { "0a561242-1bae-43d4-8405-3a69021d729e", new DateTime(1997, 1, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.AddForeignKey(
                name: "FK_MediaSources_Providers_SourceId",
                table: "MediaSources",
                column: "SourceId",
                principalTable: "Providers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MediaSources_Providers_SourceId",
                table: "MediaSources");

            migrationBuilder.DropTable(
                name: "Providers");

            migrationBuilder.DeleteData(
                table: "ReviewOpinions",
                keyColumn: "Id",
                keyValue: new Guid("4067c853-a885-416f-ac64-b4aebcf579a6"));

            migrationBuilder.DeleteData(
                table: "ReviewOpinions",
                keyColumn: "Id",
                keyValue: new Guid("45ec2e0f-1aca-4acc-840d-4f839c5b8946"));

            migrationBuilder.DeleteData(
                table: "ReviewOpinions",
                keyColumn: "Id",
                keyValue: new Guid("4fc91403-a22b-49d6-b5a5-85d7c72bd043"));

            migrationBuilder.DeleteData(
                table: "ReviewOpinions",
                keyColumn: "Id",
                keyValue: new Guid("58571ca2-55f3-45bf-bda6-49279241df6b"));

            migrationBuilder.DeleteData(
                table: "ReviewOpinions",
                keyColumn: "Id",
                keyValue: new Guid("a59f2261-d727-47cf-8db1-4fe5a0b53fb5"));

            migrationBuilder.DeleteData(
                table: "ReviewOpinions",
                keyColumn: "Id",
                keyValue: new Guid("d541f4cf-7a4a-4d9d-902d-ed00c97051cc"));

            migrationBuilder.DeleteData(
                table: "ReviewOpinions",
                keyColumn: "Id",
                keyValue: new Guid("e15576a5-158f-445e-a00e-09e5d765383b"));

            migrationBuilder.DeleteData(
                table: "ReviewOpinions",
                keyColumn: "Id",
                keyValue: new Guid("fcffec49-06f9-48f8-a658-88b965fac617"));

            migrationBuilder.RenameColumn(
                name: "AiringStatus",
                table: "Medias",
                newName: "CurrentStatus");

            migrationBuilder.CreateTable(
                name: "Sources",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    Reliable = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThumbnailUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sources", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ReviewOpinions",
                columns: new[] { "Id", "CreatedAt", "IsFunny", "IsHelpful", "IsInteresting", "LastUpdatedAt", "ReviewId", "UserId" },
                values: new object[,]
                {
                    { new Guid("01946419-c8d5-48e7-b0f9-6a0152e100dc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("80d6a3a4-2209-41c5-a826-c2cd87dca72c"), new Guid("9b0795d2-46f0-493f-b37a-f80cc4700976") },
                    { new Guid("1782add3-68b2-4ea1-966c-7b315846d59b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("80d6a3a4-2209-41c5-a826-c2cd87dca72c"), new Guid("a6a707c8-9d67-4b36-8036-86e085670b36") },
                    { new Guid("5743484a-1092-4e71-8d86-76b909e65d50"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2fe24bcb-afa2-42df-bf28-5ea04172e783"), new Guid("a6a707c8-9d67-4b36-8036-86e085670b36") },
                    { new Guid("73146899-48ce-4bf7-98d2-d0162877a6cc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a2862e81-a1ff-4084-90dd-ce8827ce27e2"), new Guid("a6a707c8-9d67-4b36-8036-86e085670b36") },
                    { new Guid("9f34ad2f-0e8f-45c4-acd0-0ec1e05785e8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("80d6a3a4-2209-41c5-a826-c2cd87dca72c"), new Guid("3ca625e3-0648-4d1b-a456-c1c6ee0e0da8") },
                    { new Guid("a33d027b-1cfb-4462-86e1-e737ab9a8b86"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ab6f6d95-695d-41a2-9fc5-648bc83b16cb"), new Guid("9b0795d2-46f0-493f-b37a-f80cc4700976") },
                    { new Guid("c773b79e-429b-40a4-a2c1-e2060737c025"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ab6f6d95-695d-41a2-9fc5-648bc83b16cb"), new Guid("71a7ed13-227f-4a94-aa9a-c0813c60f602") },
                    { new Guid("ea9ca8d6-6eb3-43a9-a958-a55238a7c918"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b2ed2f69-e6c7-482d-b146-ec7d14cde0fb"), new Guid("fc4ce336-fac9-49dc-88f6-f60ff4231985") }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8c6d9a31-3e47-45b5-b940-9225fa539f15"),
                column: "ConcurrencyStamp",
                value: "f1cff2e2-1eda-4763-9455-a1faca335094");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8e7640e4-8701-46e5-85b9-596e03db2944"),
                column: "ConcurrencyStamp",
                value: "75fca8e4-51ca-4e00-8afd-5aa4c3e4ebec");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("92215649-862e-4c2f-a4c6-1c61cb245ad5"),
                column: "ConcurrencyStamp",
                value: "2420c572-ad3f-4293-8344-bad2a93d2ff6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e98fc490-4589-4beb-a316-add18c8f3ddf"),
                column: "ConcurrencyStamp",
                value: "a523830f-014a-4206-8a93-dcaed3a0abb8");

            migrationBuilder.InsertData(
                table: "Sources",
                columns: new[] { "Id", "CreatedAt", "Description", "LastUpdatedAt", "Reliable", "ThumbnailUrl", "Title", "Url" },
                values: new object[,]
                {
                    { new Guid("4a022ad0-e6e6-4df3-9b95-bf1aa05db9df"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "FSGratis este un site complet gratuit care contine link-uri catre site-uri de video sharing, mai exact site-uri ce gazduiesc fisiere video, filme, seriale si asa mai departe.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trustworthy", "https://filmeserialegratis.org/wp-content/uploads/2019/09/logofsgratis-2.png", "FSGratis", "https://filmeserialegratis.org/" },
                    { new Guid("a573321a-5c27-4ba9-9903-ee00ca56b4c0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Animepahe is a popular website for anime lovers. You can watch thousands of free anime from Drama, History, Action, Romance and more. Animepahe is confident ...", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sussy", "http://wasabi-files.lbstatic.nu/files/users/large/9666248_logo-animepahe.jpg?1629794131", "AnimePahe", "https://animepahe.com/" },
                    { new Guid("eee0f7d1-9080-452e-97e6-7773190a59a8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Watch Anime for free in HD quality with English subbed or dubbed.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trustworthy", "https://i.imgur.com/RO2x9O5.png", "AnimixPlay", "https://animixplay.to/" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3ca625e3-0648-4d1b-a456-c1c6ee0e0da8"),
                columns: new[] { "ConcurrencyStamp", "DateOfBirth" },
                values: new object[] { "fdf9238e-5f16-4eb6-8c07-5c279cee74a2", new DateTime(1995, 1, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("71a7ed13-227f-4a94-aa9a-c0813c60f602"),
                columns: new[] { "ConcurrencyStamp", "DateOfBirth" },
                values: new object[] { "4d77f479-1118-49cf-9d72-3525c1d92f66", new DateTime(1998, 1, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9b0795d2-46f0-493f-b37a-f80cc4700976"),
                columns: new[] { "ConcurrencyStamp", "DateOfBirth" },
                values: new object[] { "8ed56bea-b55d-4bda-ac1d-8d84ee4f5dec", new DateTime(2004, 1, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a6a707c8-9d67-4b36-8036-86e085670b36"),
                columns: new[] { "ConcurrencyStamp", "DateOfBirth" },
                values: new object[] { "09028145-8dca-41dc-88bf-cc2d607fad05", new DateTime(2000, 1, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fc4ce336-fac9-49dc-88f6-f60ff4231985"),
                columns: new[] { "ConcurrencyStamp", "DateOfBirth" },
                values: new object[] { "040c3f1b-c4b5-4301-aa70-194b44c4a33f", new DateTime(1997, 1, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.AddForeignKey(
                name: "FK_MediaSources_Sources_SourceId",
                table: "MediaSources",
                column: "SourceId",
                principalTable: "Sources",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
