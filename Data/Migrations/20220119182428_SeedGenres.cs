using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KixPlay_Backend.Data.Migrations
{
    public partial class SeedGenres : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0faa2716-763a-46bd-aeb5-b731070edf23"), "horror" },
                    { new Guid("3cf709a3-a95c-4d56-a8d6-2ee490ca7161"), "drama" },
                    { new Guid("5d90f656-95b7-41e9-afbc-7f03564a2b16"), "slowburn" },
                    { new Guid("63f38ef9-382c-4cca-b0fc-000a3aaa2e1e"), "action" },
                    { new Guid("bb85ef16-0dfc-4cf8-a248-929920f775e3"), "thriller" }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8c6d9a31-3e47-45b5-b940-9225fa539f15"),
                column: "ConcurrencyStamp",
                value: "cd743ea7-a389-4911-8365-ce4bed300697");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8e7640e4-8701-46e5-85b9-596e03db2944"),
                column: "ConcurrencyStamp",
                value: "baf56909-8eb4-4458-b7a4-ff1e027473db");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("92215649-862e-4c2f-a4c6-1c61cb245ad5"),
                column: "ConcurrencyStamp",
                value: "e78648db-2635-47ce-9203-0c097f96c94d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e98fc490-4589-4beb-a316-add18c8f3ddf"),
                column: "ConcurrencyStamp",
                value: "75479b7c-e84b-4778-9e73-cf2a6d90acd8");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3ca625e3-0648-4d1b-a456-c1c6ee0e0da8"),
                column: "ConcurrencyStamp",
                value: "a5b83422-92ff-4fb7-946c-075af7b6ab46");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("71a7ed13-227f-4a94-aa9a-c0813c60f602"),
                column: "ConcurrencyStamp",
                value: "fb28b210-bcb4-47e0-a165-163f43860a91");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9b0795d2-46f0-493f-b37a-f80cc4700976"),
                column: "ConcurrencyStamp",
                value: "2305fbbd-d8bf-473e-8c97-9781f9e6b598");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a6a707c8-9d67-4b36-8036-86e085670b36"),
                column: "ConcurrencyStamp",
                value: "5f5e8c7e-13da-40f6-a0f9-55e32bae9cdb");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fc4ce336-fac9-49dc-88f6-f60ff4231985"),
                column: "ConcurrencyStamp",
                value: "afc78c88-878e-4263-b345-41f40201a95c");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("0faa2716-763a-46bd-aeb5-b731070edf23"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("3cf709a3-a95c-4d56-a8d6-2ee490ca7161"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("5d90f656-95b7-41e9-afbc-7f03564a2b16"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("63f38ef9-382c-4cca-b0fc-000a3aaa2e1e"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("bb85ef16-0dfc-4cf8-a248-929920f775e3"));

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
    }
}
