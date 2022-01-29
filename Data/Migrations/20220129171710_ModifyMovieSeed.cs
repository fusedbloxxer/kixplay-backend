using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KixPlay_Backend.Data.Migrations
{
    public partial class ModifyMovieSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: new Guid("732e75d1-baa5-43bd-8636-8f91262545b2"),
                column: "ThumbnailUrl",
                value: "https://images.justwatch.com/poster/257876484/s718c");

            migrationBuilder.InsertData(
                table: "ReviewOpinions",
                columns: new[] { "Id", "IsFunny", "IsHelpful", "ReviewId", "UserId" },
                values: new object[] { new Guid("3bd6aed4-a7f4-4382-9de3-9670ad222472"), true, true, new Guid("80d6a3a4-2209-41c5-a826-c2cd87dca72c"), new Guid("9b0795d2-46f0-493f-b37a-f80cc4700976") });

            migrationBuilder.InsertData(
                table: "ReviewOpinions",
                columns: new[] { "Id", "ReviewId", "UserId" },
                values: new object[] { new Guid("5d2a4c82-a7f0-48c7-8de7-180322cf43e7"), new Guid("ab6f6d95-695d-41a2-9fc5-648bc83b16cb"), new Guid("71a7ed13-227f-4a94-aa9a-c0813c60f602") });

            migrationBuilder.InsertData(
                table: "ReviewOpinions",
                columns: new[] { "Id", "IsHelpful", "IsInteresting", "ReviewId", "UserId" },
                values: new object[] { new Guid("5ddcada1-42fe-40fe-949d-0ef7f96c9351"), true, true, new Guid("b2ed2f69-e6c7-482d-b146-ec7d14cde0fb"), new Guid("fc4ce336-fac9-49dc-88f6-f60ff4231985") });

            migrationBuilder.InsertData(
                table: "ReviewOpinions",
                columns: new[] { "Id", "IsFunny", "ReviewId", "UserId" },
                values: new object[] { new Guid("797c3368-e96b-4338-9f35-73008368d2ee"), true, new Guid("80d6a3a4-2209-41c5-a826-c2cd87dca72c"), new Guid("3ca625e3-0648-4d1b-a456-c1c6ee0e0da8") });

            migrationBuilder.InsertData(
                table: "ReviewOpinions",
                columns: new[] { "Id", "IsHelpful", "ReviewId", "UserId" },
                values: new object[,]
                {
                    { new Guid("87dfa4d3-1214-40fa-a262-ad80312ee950"), true, new Guid("2fe24bcb-afa2-42df-bf28-5ea04172e783"), new Guid("a6a707c8-9d67-4b36-8036-86e085670b36") },
                    { new Guid("8c6b730c-07d7-4591-8e95-683f985b4761"), true, new Guid("ab6f6d95-695d-41a2-9fc5-648bc83b16cb"), new Guid("9b0795d2-46f0-493f-b37a-f80cc4700976") }
                });

            migrationBuilder.InsertData(
                table: "ReviewOpinions",
                columns: new[] { "Id", "IsInteresting", "ReviewId", "UserId" },
                values: new object[,]
                {
                    { new Guid("a410da6f-8b92-4c00-83d7-957dbe0a5137"), true, new Guid("80d6a3a4-2209-41c5-a826-c2cd87dca72c"), new Guid("a6a707c8-9d67-4b36-8036-86e085670b36") },
                    { new Guid("b820e5c0-fff6-447f-a3c3-3beaa22d6a41"), true, new Guid("a2862e81-a1ff-4084-90dd-ce8827ce27e2"), new Guid("a6a707c8-9d67-4b36-8036-86e085670b36") }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8c6d9a31-3e47-45b5-b940-9225fa539f15"),
                column: "ConcurrencyStamp",
                value: "2e876782-f20a-448a-948d-574fb41314df");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8e7640e4-8701-46e5-85b9-596e03db2944"),
                column: "ConcurrencyStamp",
                value: "6614cce7-921b-4185-8841-23f195266cf0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("92215649-862e-4c2f-a4c6-1c61cb245ad5"),
                column: "ConcurrencyStamp",
                value: "f5eb9185-345a-41c3-a3b7-2f1fdff38f19");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e98fc490-4589-4beb-a316-add18c8f3ddf"),
                column: "ConcurrencyStamp",
                value: "cf2f3452-951e-4427-b65d-68f40c39861f");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3ca625e3-0648-4d1b-a456-c1c6ee0e0da8"),
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "SecurityStamp" },
                values: new object[] { "0c8178d7-7b4a-49c1-8c86-91919d0eae14", new DateTime(1995, 1, 29, 0, 0, 0, 0, DateTimeKind.Local), "b77b8332-c349-448a-a5e9-1e122c1be451" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("71a7ed13-227f-4a94-aa9a-c0813c60f602"),
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "SecurityStamp" },
                values: new object[] { "6b6632a1-8e3a-4bda-a253-f9626455de6a", new DateTime(1998, 1, 29, 0, 0, 0, 0, DateTimeKind.Local), "9444d048-2853-4735-a55c-94896b3d2c18" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9b0795d2-46f0-493f-b37a-f80cc4700976"),
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "SecurityStamp" },
                values: new object[] { "a40735e7-c473-48ce-be4d-e8b86a1312e8", new DateTime(2004, 1, 29, 0, 0, 0, 0, DateTimeKind.Local), "b9f941b4-2052-4473-930b-3553a8d4afa4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a6a707c8-9d67-4b36-8036-86e085670b36"),
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "SecurityStamp" },
                values: new object[] { "88a7961a-e481-47f1-83e0-8d4e7a2f77cb", new DateTime(2000, 1, 29, 0, 0, 0, 0, DateTimeKind.Local), "6d32361d-0d92-4036-b477-9d93e014de87" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fc4ce336-fac9-49dc-88f6-f60ff4231985"),
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "SecurityStamp" },
                values: new object[] { "9539f0dd-4d07-4739-a96b-0a7ee4f2158c", new DateTime(1997, 1, 29, 0, 0, 0, 0, DateTimeKind.Local), "a6c58e3d-91b8-46ee-afc7-0653138cae82" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ReviewOpinions",
                keyColumn: "Id",
                keyValue: new Guid("3bd6aed4-a7f4-4382-9de3-9670ad222472"));

            migrationBuilder.DeleteData(
                table: "ReviewOpinions",
                keyColumn: "Id",
                keyValue: new Guid("5d2a4c82-a7f0-48c7-8de7-180322cf43e7"));

            migrationBuilder.DeleteData(
                table: "ReviewOpinions",
                keyColumn: "Id",
                keyValue: new Guid("5ddcada1-42fe-40fe-949d-0ef7f96c9351"));

            migrationBuilder.DeleteData(
                table: "ReviewOpinions",
                keyColumn: "Id",
                keyValue: new Guid("797c3368-e96b-4338-9f35-73008368d2ee"));

            migrationBuilder.DeleteData(
                table: "ReviewOpinions",
                keyColumn: "Id",
                keyValue: new Guid("87dfa4d3-1214-40fa-a262-ad80312ee950"));

            migrationBuilder.DeleteData(
                table: "ReviewOpinions",
                keyColumn: "Id",
                keyValue: new Guid("8c6b730c-07d7-4591-8e95-683f985b4761"));

            migrationBuilder.DeleteData(
                table: "ReviewOpinions",
                keyColumn: "Id",
                keyValue: new Guid("a410da6f-8b92-4c00-83d7-957dbe0a5137"));

            migrationBuilder.DeleteData(
                table: "ReviewOpinions",
                keyColumn: "Id",
                keyValue: new Guid("b820e5c0-fff6-447f-a3c3-3beaa22d6a41"));

            migrationBuilder.UpdateData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: new Guid("732e75d1-baa5-43bd-8636-8f91262545b2"),
                column: "ThumbnailUrl",
                value: "https://pics.filmaffinity.com/The_Northman-208868927-large.jpg");

            migrationBuilder.InsertData(
                table: "ReviewOpinions",
                columns: new[] { "Id", "CreatedAt", "IsFunny", "IsHelpful", "IsInteresting", "LastUpdatedAt", "ReviewId", "UserId" },
                values: new object[,]
                {
                    { new Guid("32ac2847-3356-4521-8209-8ff909fc79b9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2fe24bcb-afa2-42df-bf28-5ea04172e783"), new Guid("a6a707c8-9d67-4b36-8036-86e085670b36") },
                    { new Guid("3e329c08-881b-4325-b66f-82a9ab126902"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b2ed2f69-e6c7-482d-b146-ec7d14cde0fb"), new Guid("fc4ce336-fac9-49dc-88f6-f60ff4231985") },
                    { new Guid("4f858175-50d2-4abe-9a58-d93cfe8c91bf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("80d6a3a4-2209-41c5-a826-c2cd87dca72c"), new Guid("9b0795d2-46f0-493f-b37a-f80cc4700976") },
                    { new Guid("a66cc684-5818-4b79-ab6c-09ec08abd452"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a2862e81-a1ff-4084-90dd-ce8827ce27e2"), new Guid("a6a707c8-9d67-4b36-8036-86e085670b36") },
                    { new Guid("cc5a4675-dfc1-4f65-8b3c-b641a61b7316"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ab6f6d95-695d-41a2-9fc5-648bc83b16cb"), new Guid("9b0795d2-46f0-493f-b37a-f80cc4700976") },
                    { new Guid("d9e431e4-3591-4cf2-9578-3e93115819fb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("80d6a3a4-2209-41c5-a826-c2cd87dca72c"), new Guid("a6a707c8-9d67-4b36-8036-86e085670b36") },
                    { new Guid("e7f78433-5e75-4abc-8b4c-412a9826abed"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("80d6a3a4-2209-41c5-a826-c2cd87dca72c"), new Guid("3ca625e3-0648-4d1b-a456-c1c6ee0e0da8") },
                    { new Guid("fcfcbe5b-b8fd-4872-b1bf-6c5f51154ff8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ab6f6d95-695d-41a2-9fc5-648bc83b16cb"), new Guid("71a7ed13-227f-4a94-aa9a-c0813c60f602") }
                });

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
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "SecurityStamp" },
                values: new object[] { "154b2b9a-61ee-4172-aa90-a16525719536", new DateTime(1995, 1, 23, 0, 0, 0, 0, DateTimeKind.Local), "a8656057-9c03-414f-85c4-a99cc8cb2364" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("71a7ed13-227f-4a94-aa9a-c0813c60f602"),
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "SecurityStamp" },
                values: new object[] { "a59a38b0-124f-4756-96d6-5513fe83f617", new DateTime(1998, 1, 23, 0, 0, 0, 0, DateTimeKind.Local), "7952cc67-e910-4eae-84f2-8ded134d2022" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9b0795d2-46f0-493f-b37a-f80cc4700976"),
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "SecurityStamp" },
                values: new object[] { "703173a0-2ced-4b63-b4b0-76844eb8afe5", new DateTime(2004, 1, 23, 0, 0, 0, 0, DateTimeKind.Local), "8e7e1db0-a60e-4e62-a752-54152d844d6e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a6a707c8-9d67-4b36-8036-86e085670b36"),
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "SecurityStamp" },
                values: new object[] { "2de06afb-2fa6-4c54-9438-8380ed36d894", new DateTime(2000, 1, 23, 0, 0, 0, 0, DateTimeKind.Local), "1696980c-95df-4e53-bbd8-410cb31af7f8" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fc4ce336-fac9-49dc-88f6-f60ff4231985"),
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "SecurityStamp" },
                values: new object[] { "43079ae6-c8b3-4829-81ee-c60d50e3d22d", new DateTime(1997, 1, 23, 0, 0, 0, 0, DateTimeKind.Local), "172bc89f-5e36-49eb-8406-7a014e19ab49" });
        }
    }
}
