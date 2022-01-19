using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KixPlay_Backend.Data.Migrations
{
    public partial class SeedTwoMoreMovies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "BannerUrl", "CurrentStatus", "Description", "Duration", "NextId", "PreviewImageUrls", "PreviewVideoUrls", "PreviousId", "ReleaseDate", "Synopsis", "ThumbnailUrl", "Title" },
                values: new object[,]
                {
                    { new Guid("732e75d1-baa5-43bd-8636-8f91262545b2"), "https://i.ytimg.com/vi/oMSdFM12hOw/maxresdefault.jpg", "Unreleased", "From acclaimed director Robert Eggers, The Northman is an epic revenge thriller that explores how far a Viking prince will go to seek justice for his murdered father.", new TimeSpan(0, 2, 20, 0, 0), null, "[\r\n  \"https://decider.com/wp-content/uploads/2021/12/The-Northman.jpg?quality=80\\u0026strip=all\",\r\n  \"https://static1.colliderimages.com/wordpress/wp-content/uploads/2021/12/Alexander-Skarsgard-and-Anya-Taylor-Joy-The-Northman-social.jpg\",\r\n  \"https://m.media-amazon.com/images/M/MV5BYjA3NjkyZjYtN2UwZC00MWM5LTk4MDUtMzcxNDU4ZDE3OWZkXkEyXkFqcGdeQWpnYW1i._V1_QL75_UX500_CR0,0,500,281_.jpg\"\r\n]", "[\r\n  \"https://www.youtube.com/watch?v=oMSdFM12hOw\"\r\n]", null, new DateTime(2022, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Written by Eggers and Icelandic poet and novelist Sjón Sigurdsson, Northman is described as a grounded story set in Iceland at the turn of the 10th century that centres on a Nordic prince who seeks revenge for the death of his father.", "https://pics.filmaffinity.com/The_Northman-208868927-large.jpg", "The Northman" },
                    { new Guid("e33f7813-258e-4c6c-bf4a-06bfdcdd1095"), "https://s3.amazonaws.com/static.rogerebert.com/uploads/review/primary_image/reviews/the-invitation-2016/The-Invitation-2016.jpg", "Aired", "A man accepts an invitation to a dinner party hosted by his ex-wife, an unsettling affair that reopens old wounds and creates new tensions. A man accepts an invitation to a dinner party hosted by his ex-wife, an unsettling affair that reopens old wounds and creates new tensions.", new TimeSpan(0, 1, 40, 0, 0), null, "[\r\n  \"https://static01.nyt.com/images/2016/04/08/arts/08INVITE/08INVITE-superJumbo.jpg\",\r\n  \"https://m.media-amazon.com/images/M/MV5BMTgzMTU1NjE4N15BMl5BanBnXkFtZTgwOTU3ODM1ODE@._V1_.jpg\",\r\n  \"http://www.moriareviews.com/rongulator/wp-content/uploads/Invitation-2015-8.jpg\"\r\n]", "[\r\n  \"https://www.youtube.com/watch?v=0-mp77SZ_0M\"\r\n]", null, new DateTime(2015, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "A man accepts an invitation to a dinner party hosted by his ex-wife, an unsettling affair that reopens old wounds and creates new tensions.", "https://m.media-amazon.com/images/M/MV5BMTkzODMwNDkzOF5BMl5BanBnXkFtZTgwNDA4NzA1ODE@._V1_.jpg", "The Invitation" }
                });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("0c36c9b3-d576-4213-8318-49e1882daa38"),
                column: "WonAwards",
                value: 15);

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

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "MetreageType", "WonAwards" },
                values: new object[] { new Guid("732e75d1-baa5-43bd-8636-8f91262545b2"), "Long", 0 });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "MetreageType", "WonAwards" },
                values: new object[] { new Guid("e33f7813-258e-4c6c-bf4a-06bfdcdd1095"), "Long", 10 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("732e75d1-baa5-43bd-8636-8f91262545b2"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("e33f7813-258e-4c6c-bf4a-06bfdcdd1095"));

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: new Guid("732e75d1-baa5-43bd-8636-8f91262545b2"));

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: new Guid("e33f7813-258e-4c6c-bf4a-06bfdcdd1095"));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("0c36c9b3-d576-4213-8318-49e1882daa38"),
                column: "WonAwards",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8c6d9a31-3e47-45b5-b940-9225fa539f15"),
                column: "ConcurrencyStamp",
                value: "991782e7-d147-4ca4-9398-7c9cb57a72d9");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8e7640e4-8701-46e5-85b9-596e03db2944"),
                column: "ConcurrencyStamp",
                value: "6bdd655e-cf43-4518-ba0e-8de4828ca9c8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("92215649-862e-4c2f-a4c6-1c61cb245ad5"),
                column: "ConcurrencyStamp",
                value: "6f415d5c-8077-4221-996f-6c359caf169c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e98fc490-4589-4beb-a316-add18c8f3ddf"),
                column: "ConcurrencyStamp",
                value: "f60e5d0d-4110-48c9-b504-f238dd507b44");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3ca625e3-0648-4d1b-a456-c1c6ee0e0da8"),
                column: "ConcurrencyStamp",
                value: "98091f28-4f99-407c-9960-150c65998abc");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("71a7ed13-227f-4a94-aa9a-c0813c60f602"),
                column: "ConcurrencyStamp",
                value: "f2654f99-f329-43ec-81ef-0e03d16e3a9f");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9b0795d2-46f0-493f-b37a-f80cc4700976"),
                column: "ConcurrencyStamp",
                value: "1dc517ad-6c6b-4272-b664-ab26e08a78e1");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a6a707c8-9d67-4b36-8036-86e085670b36"),
                column: "ConcurrencyStamp",
                value: "d97d22e9-94cd-4157-9abf-0e2760190ac0");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fc4ce336-fac9-49dc-88f6-f60ff4231985"),
                column: "ConcurrencyStamp",
                value: "ce2ae256-0aa4-4356-a0bc-5509ce5418b7");
        }
    }
}
