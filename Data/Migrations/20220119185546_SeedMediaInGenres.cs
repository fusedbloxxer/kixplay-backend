using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KixPlay_Backend.Data.Migrations
{
    public partial class SeedMediaInGenres : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MediaInGenres",
                columns: new[] { "Id", "GenreId", "MediaId" },
                values: new object[,]
                {
                    { new Guid("29c2ab05-d741-4030-8578-2ee548251784"), new Guid("5d90f656-95b7-41e9-afbc-7f03564a2b16"), new Guid("0c36c9b3-d576-4213-8318-49e1882daa38") },
                    { new Guid("414873c1-82d0-4cb0-bd13-e4a76e3feed5"), new Guid("bb85ef16-0dfc-4cf8-a248-929920f775e3"), new Guid("e33f7813-258e-4c6c-bf4a-06bfdcdd1095") },
                    { new Guid("62591aee-1b47-499f-93b0-78977272adea"), new Guid("bb85ef16-0dfc-4cf8-a248-929920f775e3"), new Guid("0c36c9b3-d576-4213-8318-49e1882daa38") },
                    { new Guid("8caf43d0-0eed-4e7a-8b1a-02c7a7df0890"), new Guid("63f38ef9-382c-4cca-b0fc-000a3aaa2e1e"), new Guid("732e75d1-baa5-43bd-8636-8f91262545b2") },
                    { new Guid("bb56200e-f47e-4bed-97ab-dfc9fb7f90d8"), new Guid("0faa2716-763a-46bd-aeb5-b731070edf23"), new Guid("e33f7813-258e-4c6c-bf4a-06bfdcdd1095") },
                    { new Guid("ccae8e17-8759-405f-8d48-a59324956f92"), new Guid("3cf709a3-a95c-4d56-a8d6-2ee490ca7161"), new Guid("e33f7813-258e-4c6c-bf4a-06bfdcdd1095") },
                    { new Guid("f6ffc53e-1ea7-4e29-b2fc-665f68fef9ff"), new Guid("5d90f656-95b7-41e9-afbc-7f03564a2b16"), new Guid("e33f7813-258e-4c6c-bf4a-06bfdcdd1095") },
                    { new Guid("fcda9b37-4d4e-42f6-93ff-297b7bd6d69e"), new Guid("0faa2716-763a-46bd-aeb5-b731070edf23"), new Guid("0c36c9b3-d576-4213-8318-49e1882daa38") }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MediaInGenres",
                keyColumn: "Id",
                keyValue: new Guid("29c2ab05-d741-4030-8578-2ee548251784"));

            migrationBuilder.DeleteData(
                table: "MediaInGenres",
                keyColumn: "Id",
                keyValue: new Guid("414873c1-82d0-4cb0-bd13-e4a76e3feed5"));

            migrationBuilder.DeleteData(
                table: "MediaInGenres",
                keyColumn: "Id",
                keyValue: new Guid("62591aee-1b47-499f-93b0-78977272adea"));

            migrationBuilder.DeleteData(
                table: "MediaInGenres",
                keyColumn: "Id",
                keyValue: new Guid("8caf43d0-0eed-4e7a-8b1a-02c7a7df0890"));

            migrationBuilder.DeleteData(
                table: "MediaInGenres",
                keyColumn: "Id",
                keyValue: new Guid("bb56200e-f47e-4bed-97ab-dfc9fb7f90d8"));

            migrationBuilder.DeleteData(
                table: "MediaInGenres",
                keyColumn: "Id",
                keyValue: new Guid("ccae8e17-8759-405f-8d48-a59324956f92"));

            migrationBuilder.DeleteData(
                table: "MediaInGenres",
                keyColumn: "Id",
                keyValue: new Guid("f6ffc53e-1ea7-4e29-b2fc-665f68fef9ff"));

            migrationBuilder.DeleteData(
                table: "MediaInGenres",
                keyColumn: "Id",
                keyValue: new Guid("fcda9b37-4d4e-42f6-93ff-297b7bd6d69e"));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8c6d9a31-3e47-45b5-b940-9225fa539f15"),
                column: "ConcurrencyStamp",
                value: "793c576c-cda2-4c29-80ee-949399111d03");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8e7640e4-8701-46e5-85b9-596e03db2944"),
                column: "ConcurrencyStamp",
                value: "1b6fef6a-c734-40e3-a04c-a92f5191e810");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("92215649-862e-4c2f-a4c6-1c61cb245ad5"),
                column: "ConcurrencyStamp",
                value: "0dff0ae3-e43f-417a-9890-b773f4ee8702");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e98fc490-4589-4beb-a316-add18c8f3ddf"),
                column: "ConcurrencyStamp",
                value: "728968c3-9384-4f7e-aa53-2a3f0f6be132");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3ca625e3-0648-4d1b-a456-c1c6ee0e0da8"),
                column: "ConcurrencyStamp",
                value: "91432f9f-bb32-4bea-aef9-89e27cf66f45");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("71a7ed13-227f-4a94-aa9a-c0813c60f602"),
                column: "ConcurrencyStamp",
                value: "1be99bc1-70fe-41c9-a171-2014d029a12f");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9b0795d2-46f0-493f-b37a-f80cc4700976"),
                column: "ConcurrencyStamp",
                value: "57cb90c4-23f2-4900-ad72-f3d8d3aad82b");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a6a707c8-9d67-4b36-8036-86e085670b36"),
                column: "ConcurrencyStamp",
                value: "afb0b659-29bd-425b-8e1a-56600dde9ac1");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fc4ce336-fac9-49dc-88f6-f60ff4231985"),
                column: "ConcurrencyStamp",
                value: "87394ff2-697e-4aa8-b929-b2a5ced52e91");
        }
    }
}
