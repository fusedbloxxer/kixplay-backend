using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KixPlay_Backend.Data.Migrations
{
    public partial class ChangeProviderFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MediaSources_Providers_SourceId",
                table: "MediaSources");

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
                name: "SourceId",
                table: "MediaSources",
                newName: "ProviderId");

            migrationBuilder.RenameIndex(
                name: "IX_MediaSources_SourceId",
                table: "MediaSources",
                newName: "IX_MediaSources_ProviderId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Genres",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "ReviewOpinions",
                columns: new[] { "Id", "ReviewId", "UserId" },
                values: new object[] { new Guid("08816ede-301a-4807-848e-2105c92f644f"), new Guid("ab6f6d95-695d-41a2-9fc5-648bc83b16cb"), new Guid("71a7ed13-227f-4a94-aa9a-c0813c60f602") });

            migrationBuilder.InsertData(
                table: "ReviewOpinions",
                columns: new[] { "Id", "IsInteresting", "ReviewId", "UserId" },
                values: new object[] { new Guid("0cbb5550-8019-4fed-9881-ba0fd74a94dd"), true, new Guid("a2862e81-a1ff-4084-90dd-ce8827ce27e2"), new Guid("a6a707c8-9d67-4b36-8036-86e085670b36") });

            migrationBuilder.InsertData(
                table: "ReviewOpinions",
                columns: new[] { "Id", "IsFunny", "ReviewId", "UserId" },
                values: new object[] { new Guid("55ce5290-19c9-4439-8967-51fc5f881a59"), true, new Guid("80d6a3a4-2209-41c5-a826-c2cd87dca72c"), new Guid("3ca625e3-0648-4d1b-a456-c1c6ee0e0da8") });

            migrationBuilder.InsertData(
                table: "ReviewOpinions",
                columns: new[] { "Id", "IsHelpful", "IsInteresting", "ReviewId", "UserId" },
                values: new object[] { new Guid("5f6979e9-f0e3-4c42-836d-3b95b17bf716"), true, true, new Guid("b2ed2f69-e6c7-482d-b146-ec7d14cde0fb"), new Guid("fc4ce336-fac9-49dc-88f6-f60ff4231985") });

            migrationBuilder.InsertData(
                table: "ReviewOpinions",
                columns: new[] { "Id", "IsHelpful", "ReviewId", "UserId" },
                values: new object[,]
                {
                    { new Guid("60039355-ed34-41a1-bed9-8d1389de3ec7"), true, new Guid("ab6f6d95-695d-41a2-9fc5-648bc83b16cb"), new Guid("9b0795d2-46f0-493f-b37a-f80cc4700976") },
                    { new Guid("74604679-c092-4d31-a440-8dc6062ad846"), true, new Guid("2fe24bcb-afa2-42df-bf28-5ea04172e783"), new Guid("a6a707c8-9d67-4b36-8036-86e085670b36") }
                });

            migrationBuilder.InsertData(
                table: "ReviewOpinions",
                columns: new[] { "Id", "IsInteresting", "ReviewId", "UserId" },
                values: new object[] { new Guid("b6ebb5ef-4a2d-4f92-bf5a-51393d7d980b"), true, new Guid("80d6a3a4-2209-41c5-a826-c2cd87dca72c"), new Guid("a6a707c8-9d67-4b36-8036-86e085670b36") });

            migrationBuilder.InsertData(
                table: "ReviewOpinions",
                columns: new[] { "Id", "IsFunny", "IsHelpful", "ReviewId", "UserId" },
                values: new object[] { new Guid("e9b34f92-657e-4c03-b775-a72af36aab2b"), true, true, new Guid("80d6a3a4-2209-41c5-a826-c2cd87dca72c"), new Guid("9b0795d2-46f0-493f-b37a-f80cc4700976") });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8c6d9a31-3e47-45b5-b940-9225fa539f15"),
                column: "ConcurrencyStamp",
                value: "5abe2c3f-ac4a-4707-bf19-aebec95959b7");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8e7640e4-8701-46e5-85b9-596e03db2944"),
                column: "ConcurrencyStamp",
                value: "b4c303c4-2584-4a67-a048-0c348fafaf7f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("92215649-862e-4c2f-a4c6-1c61cb245ad5"),
                column: "ConcurrencyStamp",
                value: "1baa6b63-b35e-4580-9605-18a573a61d87");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e98fc490-4589-4beb-a316-add18c8f3ddf"),
                column: "ConcurrencyStamp",
                value: "01be6d02-d853-45dc-9bf4-c8023d8cc953");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3ca625e3-0648-4d1b-a456-c1c6ee0e0da8"),
                columns: new[] { "ConcurrencyStamp", "DateOfBirth" },
                values: new object[] { "a9914e8d-4537-426a-97e8-21a2e9bd4e80", new DateTime(1995, 1, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("71a7ed13-227f-4a94-aa9a-c0813c60f602"),
                columns: new[] { "ConcurrencyStamp", "DateOfBirth" },
                values: new object[] { "493f5086-7696-4f34-8a44-ed6403514bbe", new DateTime(1998, 1, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9b0795d2-46f0-493f-b37a-f80cc4700976"),
                columns: new[] { "ConcurrencyStamp", "DateOfBirth" },
                values: new object[] { "46cac57e-a557-450d-9346-cad783c5efe5", new DateTime(2004, 1, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a6a707c8-9d67-4b36-8036-86e085670b36"),
                columns: new[] { "ConcurrencyStamp", "DateOfBirth" },
                values: new object[] { "995da9fb-d001-4373-86ef-c23e061911cc", new DateTime(2000, 1, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fc4ce336-fac9-49dc-88f6-f60ff4231985"),
                columns: new[] { "ConcurrencyStamp", "DateOfBirth" },
                values: new object[] { "fa2da103-6c19-4cbe-ac6a-3005924e0bd1", new DateTime(1997, 1, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.CreateIndex(
                name: "IX_Genres_Name",
                table: "Genres",
                column: "Name",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MediaSources_Providers_ProviderId",
                table: "MediaSources",
                column: "ProviderId",
                principalTable: "Providers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MediaSources_Providers_ProviderId",
                table: "MediaSources");

            migrationBuilder.DropIndex(
                name: "IX_Genres_Name",
                table: "Genres");

            migrationBuilder.DeleteData(
                table: "ReviewOpinions",
                keyColumn: "Id",
                keyValue: new Guid("08816ede-301a-4807-848e-2105c92f644f"));

            migrationBuilder.DeleteData(
                table: "ReviewOpinions",
                keyColumn: "Id",
                keyValue: new Guid("0cbb5550-8019-4fed-9881-ba0fd74a94dd"));

            migrationBuilder.DeleteData(
                table: "ReviewOpinions",
                keyColumn: "Id",
                keyValue: new Guid("55ce5290-19c9-4439-8967-51fc5f881a59"));

            migrationBuilder.DeleteData(
                table: "ReviewOpinions",
                keyColumn: "Id",
                keyValue: new Guid("5f6979e9-f0e3-4c42-836d-3b95b17bf716"));

            migrationBuilder.DeleteData(
                table: "ReviewOpinions",
                keyColumn: "Id",
                keyValue: new Guid("60039355-ed34-41a1-bed9-8d1389de3ec7"));

            migrationBuilder.DeleteData(
                table: "ReviewOpinions",
                keyColumn: "Id",
                keyValue: new Guid("74604679-c092-4d31-a440-8dc6062ad846"));

            migrationBuilder.DeleteData(
                table: "ReviewOpinions",
                keyColumn: "Id",
                keyValue: new Guid("b6ebb5ef-4a2d-4f92-bf5a-51393d7d980b"));

            migrationBuilder.DeleteData(
                table: "ReviewOpinions",
                keyColumn: "Id",
                keyValue: new Guid("e9b34f92-657e-4c03-b775-a72af36aab2b"));

            migrationBuilder.RenameColumn(
                name: "ProviderId",
                table: "MediaSources",
                newName: "SourceId");

            migrationBuilder.RenameIndex(
                name: "IX_MediaSources_ProviderId",
                table: "MediaSources",
                newName: "IX_MediaSources_SourceId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Genres",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.InsertData(
                table: "ReviewOpinions",
                columns: new[] { "Id", "CreatedAt", "IsFunny", "IsHelpful", "IsInteresting", "LastUpdatedAt", "ReviewId", "UserId" },
                values: new object[,]
                {
                    { new Guid("4067c853-a885-416f-ac64-b4aebcf579a6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a2862e81-a1ff-4084-90dd-ce8827ce27e2"), new Guid("a6a707c8-9d67-4b36-8036-86e085670b36") },
                    { new Guid("45ec2e0f-1aca-4acc-840d-4f839c5b8946"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("80d6a3a4-2209-41c5-a826-c2cd87dca72c"), new Guid("9b0795d2-46f0-493f-b37a-f80cc4700976") },
                    { new Guid("4fc91403-a22b-49d6-b5a5-85d7c72bd043"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("80d6a3a4-2209-41c5-a826-c2cd87dca72c"), new Guid("3ca625e3-0648-4d1b-a456-c1c6ee0e0da8") },
                    { new Guid("58571ca2-55f3-45bf-bda6-49279241df6b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b2ed2f69-e6c7-482d-b146-ec7d14cde0fb"), new Guid("fc4ce336-fac9-49dc-88f6-f60ff4231985") },
                    { new Guid("a59f2261-d727-47cf-8db1-4fe5a0b53fb5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ab6f6d95-695d-41a2-9fc5-648bc83b16cb"), new Guid("71a7ed13-227f-4a94-aa9a-c0813c60f602") },
                    { new Guid("d541f4cf-7a4a-4d9d-902d-ed00c97051cc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ab6f6d95-695d-41a2-9fc5-648bc83b16cb"), new Guid("9b0795d2-46f0-493f-b37a-f80cc4700976") },
                    { new Guid("e15576a5-158f-445e-a00e-09e5d765383b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("80d6a3a4-2209-41c5-a826-c2cd87dca72c"), new Guid("a6a707c8-9d67-4b36-8036-86e085670b36") },
                    { new Guid("fcffec49-06f9-48f8-a658-88b965fac617"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2fe24bcb-afa2-42df-bf28-5ea04172e783"), new Guid("a6a707c8-9d67-4b36-8036-86e085670b36") }
                });

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
    }
}
