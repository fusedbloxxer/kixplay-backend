using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KixPlay_Backend.Data.Migrations
{
    public partial class SeedOneMovie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "BannerUrl", "CurrentStatus", "Description", "Duration", "NextId", "PreviewImageUrls", "PreviewVideoUrls", "PreviousId", "ReleaseDate", "Synopsis", "ThumbnailUrl", "Title" },
                values: new object[] { new Guid("0c36c9b3-d576-4213-8318-49e1882daa38"), "https://i2-prod.mirror.co.uk/incoming/article20584611.ece/ALTERNATES/s1200b/1_Fractured_00_10_38_22_R.jpg", "Aired", "Driving cross-country, Ray and his wife and daughter stop at a highway rest area where his daughter falls and breaks her arm. After a frantic rush to the hospital and a clash with the check-in nurse, Ray is finally able to get her to a doctor. While the wife and daughter go downstairs for an MRI, Ray, exhausted, passes out in a chair in the lobby. Upon waking up, they have no record or knowledge of Ray's family ever being checked in.—Alan B. McElroy", new TimeSpan(0, 1, 40, 0, 0), null, "[\r\n  \"https://occ-0-2794-2219.1.nflxso.net/dnm/api/v6/E8vDc_W8CLv7-yMQu8KMEC7Rrr8/AAAABSrkPHFHFt3JHfZOtaq2Naho-W8R0qxyTgNmDuM5etrbqvn_8hBS34qp5co6gh9EeW9I61LmTGx_yGG3ytieoDgjuHdF.jpg?r=054\",\r\n  \"https://www.refinery29.com/images/8556165.jpg?crop=2000%2C1051%2Cx0%2Cy133\",\r\n  \"https://d2e111jq13me73.cloudfront.net/sites/default/files/styles/share_link_image_large/public/screenshots/csm-movie/fractured-screenshot-1.jpg?itok=eLiXNoOY\"\r\n]", "[\r\n  \"https://www.youtube.com/watch?v=S8obCz5NSog\"\r\n]", null, new DateTime(2019, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "A couple stops at a gas station, where their 6 y.o. daughter's arm is fractured. They hurry to a hospital. Something strange is going on there. The wife and daughter go missing.", "https://m.media-amazon.com/images/M/MV5BZTE0MWE4NzMtMzc4Ny00NWE4LTg2OTQtZmIyNDdhZjdiZmJhXkEyXkFqcGdeQXVyMzY0MTE3NzU@._V1_.jpg", "Fractured" });

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

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "MetreageType", "WonAwards" },
                values: new object[] { new Guid("0c36c9b3-d576-4213-8318-49e1882daa38"), "Long", 5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("0c36c9b3-d576-4213-8318-49e1882daa38"));

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: new Guid("0c36c9b3-d576-4213-8318-49e1882daa38"));

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
    }
}
