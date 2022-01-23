using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KixPlay_Backend.Data.Migrations
{
    public partial class AddSecurityStampSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "ReviewOpinions",
                columns: new[] { "Id", "IsHelpful", "ReviewId", "UserId" },
                values: new object[] { new Guid("32ac2847-3356-4521-8209-8ff909fc79b9"), true, new Guid("2fe24bcb-afa2-42df-bf28-5ea04172e783"), new Guid("a6a707c8-9d67-4b36-8036-86e085670b36") });

            migrationBuilder.InsertData(
                table: "ReviewOpinions",
                columns: new[] { "Id", "IsHelpful", "IsInteresting", "ReviewId", "UserId" },
                values: new object[] { new Guid("3e329c08-881b-4325-b66f-82a9ab126902"), true, true, new Guid("b2ed2f69-e6c7-482d-b146-ec7d14cde0fb"), new Guid("fc4ce336-fac9-49dc-88f6-f60ff4231985") });

            migrationBuilder.InsertData(
                table: "ReviewOpinions",
                columns: new[] { "Id", "IsFunny", "IsHelpful", "ReviewId", "UserId" },
                values: new object[] { new Guid("4f858175-50d2-4abe-9a58-d93cfe8c91bf"), true, true, new Guid("80d6a3a4-2209-41c5-a826-c2cd87dca72c"), new Guid("9b0795d2-46f0-493f-b37a-f80cc4700976") });

            migrationBuilder.InsertData(
                table: "ReviewOpinions",
                columns: new[] { "Id", "IsInteresting", "ReviewId", "UserId" },
                values: new object[] { new Guid("a66cc684-5818-4b79-ab6c-09ec08abd452"), true, new Guid("a2862e81-a1ff-4084-90dd-ce8827ce27e2"), new Guid("a6a707c8-9d67-4b36-8036-86e085670b36") });

            migrationBuilder.InsertData(
                table: "ReviewOpinions",
                columns: new[] { "Id", "IsHelpful", "ReviewId", "UserId" },
                values: new object[] { new Guid("cc5a4675-dfc1-4f65-8b3c-b641a61b7316"), true, new Guid("ab6f6d95-695d-41a2-9fc5-648bc83b16cb"), new Guid("9b0795d2-46f0-493f-b37a-f80cc4700976") });

            migrationBuilder.InsertData(
                table: "ReviewOpinions",
                columns: new[] { "Id", "IsInteresting", "ReviewId", "UserId" },
                values: new object[] { new Guid("d9e431e4-3591-4cf2-9578-3e93115819fb"), true, new Guid("80d6a3a4-2209-41c5-a826-c2cd87dca72c"), new Guid("a6a707c8-9d67-4b36-8036-86e085670b36") });

            migrationBuilder.InsertData(
                table: "ReviewOpinions",
                columns: new[] { "Id", "IsFunny", "ReviewId", "UserId" },
                values: new object[] { new Guid("e7f78433-5e75-4abc-8b4c-412a9826abed"), true, new Guid("80d6a3a4-2209-41c5-a826-c2cd87dca72c"), new Guid("3ca625e3-0648-4d1b-a456-c1c6ee0e0da8") });

            migrationBuilder.InsertData(
                table: "ReviewOpinions",
                columns: new[] { "Id", "ReviewId", "UserId" },
                values: new object[] { new Guid("fcfcbe5b-b8fd-4872-b1bf-6c5f51154ff8"), new Guid("ab6f6d95-695d-41a2-9fc5-648bc83b16cb"), new Guid("71a7ed13-227f-4a94-aa9a-c0813c60f602") });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8c6d9a31-3e47-45b5-b940-9225fa539f15"),
                column: "ConcurrencyStamp",
                value: "740040c8-91cd-430c-8502-5b2d354b6d6f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8e7640e4-8701-46e5-85b9-596e03db2944"),
                column: "ConcurrencyStamp",
                value: "50df0f5c-4c09-48db-bea3-32fd6fd92e22");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("92215649-862e-4c2f-a4c6-1c61cb245ad5"),
                column: "ConcurrencyStamp",
                value: "e0327518-8a8e-417f-9055-420eab1bc71b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e98fc490-4589-4beb-a316-add18c8f3ddf"),
                column: "ConcurrencyStamp",
                value: "cea90193-7a43-4c6a-8c03-133b75e1f08a");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3ca625e3-0648-4d1b-a456-c1c6ee0e0da8"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "154b2b9a-61ee-4172-aa90-a16525719536", "a8656057-9c03-414f-85c4-a99cc8cb2364" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("71a7ed13-227f-4a94-aa9a-c0813c60f602"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a59a38b0-124f-4756-96d6-5513fe83f617", "7952cc67-e910-4eae-84f2-8ded134d2022" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9b0795d2-46f0-493f-b37a-f80cc4700976"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "703173a0-2ced-4b63-b4b0-76844eb8afe5", "8e7e1db0-a60e-4e62-a752-54152d844d6e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a6a707c8-9d67-4b36-8036-86e085670b36"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2de06afb-2fa6-4c54-9438-8380ed36d894", "1696980c-95df-4e53-bbd8-410cb31af7f8" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fc4ce336-fac9-49dc-88f6-f60ff4231985"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "43079ae6-c8b3-4829-81ee-c60d50e3d22d", "172bc89f-5e36-49eb-8406-7a014e19ab49" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ReviewOpinions",
                keyColumn: "Id",
                keyValue: new Guid("32ac2847-3356-4521-8209-8ff909fc79b9"));

            migrationBuilder.DeleteData(
                table: "ReviewOpinions",
                keyColumn: "Id",
                keyValue: new Guid("3e329c08-881b-4325-b66f-82a9ab126902"));

            migrationBuilder.DeleteData(
                table: "ReviewOpinions",
                keyColumn: "Id",
                keyValue: new Guid("4f858175-50d2-4abe-9a58-d93cfe8c91bf"));

            migrationBuilder.DeleteData(
                table: "ReviewOpinions",
                keyColumn: "Id",
                keyValue: new Guid("a66cc684-5818-4b79-ab6c-09ec08abd452"));

            migrationBuilder.DeleteData(
                table: "ReviewOpinions",
                keyColumn: "Id",
                keyValue: new Guid("cc5a4675-dfc1-4f65-8b3c-b641a61b7316"));

            migrationBuilder.DeleteData(
                table: "ReviewOpinions",
                keyColumn: "Id",
                keyValue: new Guid("d9e431e4-3591-4cf2-9578-3e93115819fb"));

            migrationBuilder.DeleteData(
                table: "ReviewOpinions",
                keyColumn: "Id",
                keyValue: new Guid("e7f78433-5e75-4abc-8b4c-412a9826abed"));

            migrationBuilder.DeleteData(
                table: "ReviewOpinions",
                keyColumn: "Id",
                keyValue: new Guid("fcfcbe5b-b8fd-4872-b1bf-6c5f51154ff8"));

            migrationBuilder.InsertData(
                table: "ReviewOpinions",
                columns: new[] { "Id", "CreatedAt", "IsFunny", "IsHelpful", "IsInteresting", "LastUpdatedAt", "ReviewId", "UserId" },
                values: new object[,]
                {
                    { new Guid("08816ede-301a-4807-848e-2105c92f644f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ab6f6d95-695d-41a2-9fc5-648bc83b16cb"), new Guid("71a7ed13-227f-4a94-aa9a-c0813c60f602") },
                    { new Guid("0cbb5550-8019-4fed-9881-ba0fd74a94dd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a2862e81-a1ff-4084-90dd-ce8827ce27e2"), new Guid("a6a707c8-9d67-4b36-8036-86e085670b36") },
                    { new Guid("55ce5290-19c9-4439-8967-51fc5f881a59"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("80d6a3a4-2209-41c5-a826-c2cd87dca72c"), new Guid("3ca625e3-0648-4d1b-a456-c1c6ee0e0da8") },
                    { new Guid("5f6979e9-f0e3-4c42-836d-3b95b17bf716"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b2ed2f69-e6c7-482d-b146-ec7d14cde0fb"), new Guid("fc4ce336-fac9-49dc-88f6-f60ff4231985") },
                    { new Guid("60039355-ed34-41a1-bed9-8d1389de3ec7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ab6f6d95-695d-41a2-9fc5-648bc83b16cb"), new Guid("9b0795d2-46f0-493f-b37a-f80cc4700976") },
                    { new Guid("74604679-c092-4d31-a440-8dc6062ad846"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2fe24bcb-afa2-42df-bf28-5ea04172e783"), new Guid("a6a707c8-9d67-4b36-8036-86e085670b36") },
                    { new Guid("b6ebb5ef-4a2d-4f92-bf5a-51393d7d980b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("80d6a3a4-2209-41c5-a826-c2cd87dca72c"), new Guid("a6a707c8-9d67-4b36-8036-86e085670b36") },
                    { new Guid("e9b34f92-657e-4c03-b775-a72af36aab2b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("80d6a3a4-2209-41c5-a826-c2cd87dca72c"), new Guid("9b0795d2-46f0-493f-b37a-f80cc4700976") }
                });

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
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a9914e8d-4537-426a-97e8-21a2e9bd4e80", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("71a7ed13-227f-4a94-aa9a-c0813c60f602"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "493f5086-7696-4f34-8a44-ed6403514bbe", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9b0795d2-46f0-493f-b37a-f80cc4700976"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "46cac57e-a557-450d-9346-cad783c5efe5", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a6a707c8-9d67-4b36-8036-86e085670b36"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "995da9fb-d001-4373-86ef-c23e061911cc", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fc4ce336-fac9-49dc-88f6-f60ff4231985"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fa2da103-6c19-4cbe-ac6a-3005924e0bd1", null });
        }
    }
}
