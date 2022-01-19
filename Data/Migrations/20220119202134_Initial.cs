using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KixPlay_Backend.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Medias",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Synopsis = table.Column<string>(type: "nvarchar(max)", maxLength: 4096, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BannerUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThumbnailUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<TimeSpan>(type: "time", nullable: true),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CurrentStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PreviewImageUrls = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreviewVideoUrls = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreviousId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    NextId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Medias_Medias_NextId",
                        column: x => x.NextId,
                        principalTable: "Medias",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Medias_Medias_PreviousId",
                        column: x => x.PreviousId,
                        principalTable: "Medias",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sources",
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
                    table.PrimaryKey("PK_Sources", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MediaInGenres",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GenreId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MediaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MediaInGenres", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MediaInGenres_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MediaInGenres_Medias_MediaId",
                        column: x => x.MediaId,
                        principalTable: "Medias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WonAwards = table.Column<int>(type: "int", nullable: false),
                    MetreageType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movies_Medias_Id",
                        column: x => x.Id,
                        principalTable: "Medias",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RelatedMedias",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Relationship = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MediaFromId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MediaToId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelatedMedias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RelatedMedias_Medias_MediaFromId",
                        column: x => x.MediaFromId,
                        principalTable: "Medias",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RelatedMedias_Medias_MediaToId",
                        column: x => x.MediaToId,
                        principalTable: "Medias",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleClaims_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MediaSources",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MediaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MediaSources", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MediaSources_Medias_MediaId",
                        column: x => x.MediaId,
                        principalTable: "Medias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MediaSources_Sources_SourceId",
                        column: x => x.SourceId,
                        principalTable: "Sources",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OriginalPosterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MediaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<float>(type: "real", nullable: false),
                    HasSpoilers = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    Recommended = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.CheckConstraint("CK_Reviews_CK_VALID_RATING", "[Rating] BETWEEN 0 and 10");
                    table.ForeignKey(
                        name: "FK_Reviews_Medias_MediaId",
                        column: x => x.MediaId,
                        principalTable: "Medias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_Users_OriginalPosterId",
                        column: x => x.OriginalPosterId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrackedMedias",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MediaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrackedMedias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrackedMedias_Medias_MediaId",
                        column: x => x.MediaId,
                        principalTable: "Medias",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TrackedMedias_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaims_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_UserLogins_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_UserTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OriginalPosterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReviewId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Comments_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Comments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Comments_Reviews_ReviewId",
                        column: x => x.ReviewId,
                        principalTable: "Reviews",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Comments_Users_OriginalPosterId",
                        column: x => x.OriginalPosterId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ReviewOpinions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReviewId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsFunny = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    IsHelpful = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    IsInteresting = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReviewOpinions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReviewOpinions_Reviews_ReviewId",
                        column: x => x.ReviewId,
                        principalTable: "Reviews",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ReviewOpinions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

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

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "BannerUrl", "CurrentStatus", "Description", "Duration", "NextId", "PreviewImageUrls", "PreviewVideoUrls", "PreviousId", "ReleaseDate", "Synopsis", "ThumbnailUrl", "Title" },
                values: new object[,]
                {
                    { new Guid("0c36c9b3-d576-4213-8318-49e1882daa38"), "https://i2-prod.mirror.co.uk/incoming/article20584611.ece/ALTERNATES/s1200b/1_Fractured_00_10_38_22_R.jpg", "Aired", "Driving cross-country, Ray and his wife and daughter stop at a highway rest area where his daughter falls and breaks her arm. After a frantic rush to the hospital and a clash with the check-in nurse, Ray is finally able to get her to a doctor. While the wife and daughter go downstairs for an MRI, Ray, exhausted, passes out in a chair in the lobby. Upon waking up, they have no record or knowledge of Ray's family ever being checked in.—Alan B. McElroy", new TimeSpan(0, 1, 40, 0, 0), null, "[\r\n  \"https://occ-0-2794-2219.1.nflxso.net/dnm/api/v6/E8vDc_W8CLv7-yMQu8KMEC7Rrr8/AAAABSrkPHFHFt3JHfZOtaq2Naho-W8R0qxyTgNmDuM5etrbqvn_8hBS34qp5co6gh9EeW9I61LmTGx_yGG3ytieoDgjuHdF.jpg?r=054\",\r\n  \"https://www.refinery29.com/images/8556165.jpg?crop=2000%2C1051%2Cx0%2Cy133\",\r\n  \"https://d2e111jq13me73.cloudfront.net/sites/default/files/styles/share_link_image_large/public/screenshots/csm-movie/fractured-screenshot-1.jpg?itok=eLiXNoOY\"\r\n]", "[\r\n  \"https://www.youtube.com/watch?v=S8obCz5NSog\"\r\n]", null, new DateTime(2019, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "A couple stops at a gas station, where their 6 y.o. daughter's arm is fractured. They hurry to a hospital. Something strange is going on there. The wife and daughter go missing.", "https://m.media-amazon.com/images/M/MV5BZTE0MWE4NzMtMzc4Ny00NWE4LTg2OTQtZmIyNDdhZjdiZmJhXkEyXkFqcGdeQXVyMzY0MTE3NzU@._V1_.jpg", "Fractured" },
                    { new Guid("732e75d1-baa5-43bd-8636-8f91262545b2"), "https://i.ytimg.com/vi/oMSdFM12hOw/maxresdefault.jpg", "Unreleased", "From acclaimed director Robert Eggers, The Northman is an epic revenge thriller that explores how far a Viking prince will go to seek justice for his murdered father.", new TimeSpan(0, 2, 20, 0, 0), null, "[\r\n  \"https://decider.com/wp-content/uploads/2021/12/The-Northman.jpg?quality=80\\u0026strip=all\",\r\n  \"https://static1.colliderimages.com/wordpress/wp-content/uploads/2021/12/Alexander-Skarsgard-and-Anya-Taylor-Joy-The-Northman-social.jpg\",\r\n  \"https://m.media-amazon.com/images/M/MV5BYjA3NjkyZjYtN2UwZC00MWM5LTk4MDUtMzcxNDU4ZDE3OWZkXkEyXkFqcGdeQWpnYW1i._V1_QL75_UX500_CR0,0,500,281_.jpg\"\r\n]", "[\r\n  \"https://www.youtube.com/watch?v=oMSdFM12hOw\"\r\n]", null, new DateTime(2022, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Written by Eggers and Icelandic poet and novelist Sjón Sigurdsson, Northman is described as a grounded story set in Iceland at the turn of the 10th century that centres on a Nordic prince who seeks revenge for the death of his father.", "https://pics.filmaffinity.com/The_Northman-208868927-large.jpg", "The Northman" },
                    { new Guid("e33f7813-258e-4c6c-bf4a-06bfdcdd1095"), "https://s3.amazonaws.com/static.rogerebert.com/uploads/review/primary_image/reviews/the-invitation-2016/The-Invitation-2016.jpg", "Aired", "A man accepts an invitation to a dinner party hosted by his ex-wife, an unsettling affair that reopens old wounds and creates new tensions. A man accepts an invitation to a dinner party hosted by his ex-wife, an unsettling affair that reopens old wounds and creates new tensions.", new TimeSpan(0, 1, 40, 0, 0), null, "[\r\n  \"https://static01.nyt.com/images/2016/04/08/arts/08INVITE/08INVITE-superJumbo.jpg\",\r\n  \"https://m.media-amazon.com/images/M/MV5BMTgzMTU1NjE4N15BMl5BanBnXkFtZTgwOTU3ODM1ODE@._V1_.jpg\",\r\n  \"http://www.moriareviews.com/rongulator/wp-content/uploads/Invitation-2015-8.jpg\"\r\n]", "[\r\n  \"https://www.youtube.com/watch?v=0-mp77SZ_0M\"\r\n]", null, new DateTime(2015, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "A man accepts an invitation to a dinner party hosted by his ex-wife, an unsettling affair that reopens old wounds and creates new tensions.", "https://m.media-amazon.com/images/M/MV5BMTkzODMwNDkzOF5BMl5BanBnXkFtZTgwNDA4NzA1ODE@._V1_.jpg", "The Invitation" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("8c6d9a31-3e47-45b5-b940-9225fa539f15"), "45f08f4a-44a1-4f24-a19d-2e5bd666db0f", "Admin", "ADMIN" },
                    { new Guid("8e7640e4-8701-46e5-85b9-596e03db2944"), "ba801f00-cc7b-48be-93dc-5e5bd063784a", "Contributor", "CONTRIBUTOR" },
                    { new Guid("92215649-862e-4c2f-a4c6-1c61cb245ad5"), "5ca0a30b-ec61-4933-ad0a-34c81555e913", "Member", "MEMBER" },
                    { new Guid("e98fc490-4589-4beb-a316-add18c8f3ddf"), "296c14ab-1f86-48a5-b6ab-cfd89142ddc8", "Moderator", "MODERATOR" }
                });

            migrationBuilder.InsertData(
                table: "Sources",
                columns: new[] { "Id", "Description", "Reliable", "ThumbnailUrl", "Title", "Url" },
                values: new object[,]
                {
                    { new Guid("4a022ad0-e6e6-4df3-9b95-bf1aa05db9df"), "FSGratis este un site complet gratuit care contine link-uri catre site-uri de video sharing, mai exact site-uri ce gazduiesc fisiere video, filme, seriale si asa mai departe.", "Trustworthy", "https://filmeserialegratis.org/wp-content/uploads/2019/09/logofsgratis-2.png", "FSGratis", "https://filmeserialegratis.org/" },
                    { new Guid("a573321a-5c27-4ba9-9903-ee00ca56b4c0"), "Animepahe is a popular website for anime lovers. You can watch thousands of free anime from Drama, History, Action, Romance and more. Animepahe is confident ...", "Sussy", "http://wasabi-files.lbstatic.nu/files/users/large/9666248_logo-animepahe.jpg?1629794131", "AnimePahe", "https://animepahe.com/" },
                    { new Guid("eee0f7d1-9080-452e-97e6-7773190a59a8"), "Watch Anime for free in HD quality with English subbed or dubbed.", "Trustworthy", "https://i.imgur.com/RO2x9O5.png", "AnimixPlay", "https://animixplay.to/" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("3ca625e3-0648-4d1b-a456-c1c6ee0e0da8"), 0, "ca436a3f-8207-4be0-8553-0abea9214a8d", new DateTime(1995, 1, 19, 0, 0, 0, 0, DateTimeKind.Local), "eren.yeager@gmail.com", false, "Eren", "Yeager", false, null, "EREN.YEAGER@GMAIL.COM", "ERENYEAGER", "AQAAAAEAACcQAAAAEEbyCLf0/2GiiFd4R5D9mAIjPW2Coeg095H59UongM3Osns/UWXnDJ2Rub5PFO9+JQ==", null, false, null, false, "ErenYeager" },
                    { new Guid("71a7ed13-227f-4a94-aa9a-c0813c60f602"), 0, "f4f807ff-63ca-4893-bf3f-4c70cf9e988f", new DateTime(1998, 1, 19, 0, 0, 0, 0, DateTimeKind.Local), "mikasa.ackerman@gmail.com", false, "Mikasa", "Ackerman", false, null, "MIKASA.ACKERMAN@GMAIL.COM", "MIKASAACKERMAN", "AQAAAAEAACcQAAAAEEbyCLf0/2GiiFd4R5D9mAIjPW2Coeg095H59UongM3Osns/UWXnDJ2Rub5PFO9+JQ==", null, false, null, false, "MikasaAckerman" },
                    { new Guid("9b0795d2-46f0-493f-b37a-f80cc4700976"), 0, "71107a72-50c9-4f45-9b4d-d31a38a84e21", new DateTime(2004, 1, 19, 0, 0, 0, 0, DateTimeKind.Local), "armin.arlert@gmail.com", false, "Armin", "Arlert", false, null, "ARMIN.ARLERT@GMAIL.COM", "ARMINARLERT", "AQAAAAEAACcQAAAAEEbyCLf0/2GiiFd4R5D9mAIjPW2Coeg095H59UongM3Osns/UWXnDJ2Rub5PFO9+JQ==", null, false, null, false, "ArminArlert" },
                    { new Guid("a6a707c8-9d67-4b36-8036-86e085670b36"), 0, "f38e2100-4be3-42e1-a296-84fab0cf52c6", new DateTime(2000, 1, 19, 0, 0, 0, 0, DateTimeKind.Local), "erwin.smith@gmail.com", false, "Erwin", "Smith", false, null, "ERWIN.SMITH@GMAIL.COM", "ERWINSMITH", "AQAAAAEAACcQAAAAEEbyCLf0/2GiiFd4R5D9mAIjPW2Coeg095H59UongM3Osns/UWXnDJ2Rub5PFO9+JQ==", null, false, null, false, "ErwinSmith" },
                    { new Guid("fc4ce336-fac9-49dc-88f6-f60ff4231985"), 0, "a28d974f-a0c1-461b-a911-9479a7922432", new DateTime(1997, 1, 19, 0, 0, 0, 0, DateTimeKind.Local), "levi.ivel@gmail.com", false, "Levi", null, false, null, "LEVI.IVEL@GMAIL.COM", "LEVILEVI", "AQAAAAEAACcQAAAAEEbyCLf0/2GiiFd4R5D9mAIjPW2Coeg095H59UongM3Osns/UWXnDJ2Rub5PFO9+JQ==", null, false, null, false, "LeviLevi" }
                });

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

            migrationBuilder.InsertData(
                table: "MediaSources",
                columns: new[] { "Id", "MediaId", "SourceId", "Url" },
                values: new object[,]
                {
                    { new Guid("2f5ba7de-9a8f-434b-a61e-764dfe656bfb"), new Guid("0c36c9b3-d576-4213-8318-49e1882daa38"), new Guid("4a022ad0-e6e6-4df3-9b95-bf1aa05db9df"), "https://filmeserialegratis.org/fractured/" },
                    { new Guid("f0c5a927-2ac3-4fd9-b31b-88b4d377325d"), new Guid("e33f7813-258e-4c6c-bf4a-06bfdcdd1095"), new Guid("4a022ad0-e6e6-4df3-9b95-bf1aa05db9df"), "https://filmeserialegratis.org/the-invitation-invitatia/" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "MetreageType", "WonAwards" },
                values: new object[,]
                {
                    { new Guid("0c36c9b3-d576-4213-8318-49e1882daa38"), "Long", 15 },
                    { new Guid("732e75d1-baa5-43bd-8636-8f91262545b2"), "Long", 0 },
                    { new Guid("e33f7813-258e-4c6c-bf4a-06bfdcdd1095"), "Long", 10 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "HasSpoilers", "MediaId", "OriginalPosterId", "Rating", "Recommended", "Title" },
                values: new object[] { new Guid("2fe24bcb-afa2-42df-bf28-5ea04172e783"), "Will (Logan Marshall-Green) and Kira (Emayatzy Corinealdi) have accepted a fancy dinner invitation (the invitation was fancy not the dinner) to the \r\n                                    house that he formally lived in. His ex-wife Eden (Tammy Blanchard) and her new husband David (Michiel Huisman) are hosting. Many couples show up, \r\n                                    all friends of Eden. Eden and Dave have spent the last two years in Mexico. \r\n                                    About 30 minutes into the film two more plot details fill in. Will and Eden had a son that died. Eden was in Mexico being part of a cult that helped her get over \r\n                                    her grief knowing she will be with her loves ones in the afterlife. Will suffers from the loss of his child and has bad memories.\r\n                                    Will suspects something is going on, but everyone else doesn't see it. As the audience we find the explanations acceptable, and Will maybe has issues...or not. We don't know \r\n                                    but soon the pieces come together when in end...when we finally decide we were actually entertained, but didn't know it as the film moves slow.\r\n                                    Michelle Krusiec is the token hot Asian chick.\r\n                                    Guide: F - word.No sex or nudity.", true, new Guid("e33f7813-258e-4c6c-bf4a-06bfdcdd1095"), new Guid("71a7ed13-227f-4a94-aa9a-c0813c60f602"), 8f, true, "It's weird, but it's L.A." });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "MediaId", "OriginalPosterId", "Rating", "Recommended", "Title" },
                values: new object[,]
                {
                    { new Guid("80d6a3a4-2209-41c5-a826-c2cd87dca72c"), "Fractured is a mystery thriller, I'd agree with that, but the one tag that's missing, is surreal. It's a very odd film, so odd it's almost bonkers,\r\n                                    it's like being in a nightmare, you can't wake up, all events are out of your control, and every aspect of life is spiraling out of control. \r\n                                    I won't give a single spoiler away, because it would give the game away, all I could say is expect the unexpected. \r\n                                    I predicted events and outcomes, I got every single sequence of events wrong, loaded with twists and crammed full of intrigue. Sam Worthington is terrific.\r\n                                    It's trippy, it's slow to start, but great as it gets going, think The Lady vanishes. 7/10", new Guid("0c36c9b3-d576-4213-8318-49e1882daa38"), new Guid("71a7ed13-227f-4a94-aa9a-c0813c60f602"), 7f, true, "Expect the unexpected" },
                    { new Guid("a2862e81-a1ff-4084-90dd-ce8827ce27e2"), "I have to admit I am disappointed by this movie. I saw it had a high rating and I read some reviews about how good it was supposed to be. But in fact it's not that great. \r\n                                    It could have been so much better if they would not have dragged that whole story. By that I mean the only last half hour could be qualified as good. The rest of the movie is a battle to not fall asleep, with unstoppable irritating \r\n                                    conversations between a bunch of weirdo's. If it was not for the end, that you see coming from miles away by the way, then I would have scored the movie even lesser. The actors are not bad, they are just average. Anyways, \r\n                                    if other people like The Invitation, good for them, but it was not my cup of tea.", new Guid("e33f7813-258e-4c6c-bf4a-06bfdcdd1095"), new Guid("9b0795d2-46f0-493f-b37a-f80cc4700976"), 5f, false, "Only the end is okay, the rest is below average" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "HasSpoilers", "MediaId", "OriginalPosterId", "Rating", "Recommended", "Title" },
                values: new object[] { new Guid("ab6f6d95-695d-41a2-9fc5-648bc83b16cb"), "When a movie decides to go places, as a viewer you have the choice to ride with it or abandon it.\r\n                                    I do hope you are taking option A and ride with it. It really is quite engaging and you will be quite\r\n                                    'mindblown' as another reviewer already rightfully stated. If you were wondering where Sam Worthington was (is) - wonder no more.\r\n                                    This is really a nice acting piece he got to grab and make something of it.\r\n                                    There are 2 obvious paths or choices or options, on how to view this or what it probably is telling us. So no Bonus points for guessing right.\r\n                                    This is about the journey and it is quite an exhausting one! But very good too", true, new Guid("0c36c9b3-d576-4213-8318-49e1882daa38"), new Guid("3ca625e3-0648-4d1b-a456-c1c6ee0e0da8"), 8f, true, "A mind of its own" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "MediaId", "OriginalPosterId", "Rating", "Recommended", "Title" },
                values: new object[] { new Guid("b2ed2f69-e6c7-482d-b146-ec7d14cde0fb"), "For a surprise worhington isnt stoic in this film but film potential could be used in better way and ending isnt very good", new Guid("0c36c9b3-d576-4213-8318-49e1882daa38"), new Guid("fc4ce336-fac9-49dc-88f6-f60ff4231985"), 4f, false, "Fracture" });

            migrationBuilder.InsertData(
                table: "TrackedMedias",
                columns: new[] { "Id", "MediaId", "Status", "UserId" },
                values: new object[,]
                {
                    { new Guid("1a9ab45f-3b57-48b6-8829-7c9e14271aca"), new Guid("732e75d1-baa5-43bd-8636-8f91262545b2"), "ToWatch", new Guid("71a7ed13-227f-4a94-aa9a-c0813c60f602") },
                    { new Guid("36389164-992e-4a82-9283-4b3af2389cd6"), new Guid("e33f7813-258e-4c6c-bf4a-06bfdcdd1095"), "Dropped", new Guid("a6a707c8-9d67-4b36-8036-86e085670b36") },
                    { new Guid("87b92312-864b-4bd2-a52d-a5e641c8d8f7"), new Guid("0c36c9b3-d576-4213-8318-49e1882daa38"), "Watching", new Guid("fc4ce336-fac9-49dc-88f6-f60ff4231985") },
                    { new Guid("9c7128df-7b0e-49fa-b25f-c53d218b3d3e"), new Guid("0c36c9b3-d576-4213-8318-49e1882daa38"), "OnPause", new Guid("9b0795d2-46f0-493f-b37a-f80cc4700976") },
                    { new Guid("a62a6a8e-0211-4eff-a4a6-a0dc6a7a64c8"), new Guid("0c36c9b3-d576-4213-8318-49e1882daa38"), "Watched", new Guid("71a7ed13-227f-4a94-aa9a-c0813c60f602") },
                    { new Guid("e35e01fa-d822-4d44-a528-d230c1df43e9"), new Guid("e33f7813-258e-4c6c-bf4a-06bfdcdd1095"), "Watched", new Guid("3ca625e3-0648-4d1b-a456-c1c6ee0e0da8") },
                    { new Guid("e9fceb36-89a3-46c2-9888-0198471c2029"), new Guid("e33f7813-258e-4c6c-bf4a-06bfdcdd1095"), "Watched", new Guid("71a7ed13-227f-4a94-aa9a-c0813c60f602") },
                    { new Guid("f0de9466-968a-4e9f-b3c3-3fe09eaeb383"), new Guid("732e75d1-baa5-43bd-8636-8f91262545b2"), "ToWatch", new Guid("3ca625e3-0648-4d1b-a456-c1c6ee0e0da8") }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId", "CreatedAt", "LastUpdatedAt" },
                values: new object[,]
                {
                    { new Guid("92215649-862e-4c2f-a4c6-1c61cb245ad5"), new Guid("3ca625e3-0648-4d1b-a456-c1c6ee0e0da8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("92215649-862e-4c2f-a4c6-1c61cb245ad5"), new Guid("71a7ed13-227f-4a94-aa9a-c0813c60f602"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e98fc490-4589-4beb-a316-add18c8f3ddf"), new Guid("71a7ed13-227f-4a94-aa9a-c0813c60f602"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8e7640e4-8701-46e5-85b9-596e03db2944"), new Guid("9b0795d2-46f0-493f-b37a-f80cc4700976"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("92215649-862e-4c2f-a4c6-1c61cb245ad5"), new Guid("9b0795d2-46f0-493f-b37a-f80cc4700976"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8c6d9a31-3e47-45b5-b940-9225fa539f15"), new Guid("a6a707c8-9d67-4b36-8036-86e085670b36"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("92215649-862e-4c2f-a4c6-1c61cb245ad5"), new Guid("a6a707c8-9d67-4b36-8036-86e085670b36"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("92215649-862e-4c2f-a4c6-1c61cb245ad5"), new Guid("fc4ce336-fac9-49dc-88f6-f60ff4231985"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "ReviewOpinions",
                columns: new[] { "Id", "IsFunny", "ReviewId", "UserId" },
                values: new object[] { new Guid("11931d93-a732-4bd0-b54f-72e2ebf5eee1"), true, new Guid("80d6a3a4-2209-41c5-a826-c2cd87dca72c"), new Guid("3ca625e3-0648-4d1b-a456-c1c6ee0e0da8") });

            migrationBuilder.InsertData(
                table: "ReviewOpinions",
                columns: new[] { "Id", "IsFunny", "IsHelpful", "ReviewId", "UserId" },
                values: new object[] { new Guid("18935269-031d-4e7b-ac5a-f04171752e74"), true, true, new Guid("80d6a3a4-2209-41c5-a826-c2cd87dca72c"), new Guid("9b0795d2-46f0-493f-b37a-f80cc4700976") });

            migrationBuilder.InsertData(
                table: "ReviewOpinions",
                columns: new[] { "Id", "IsHelpful", "IsInteresting", "ReviewId", "UserId" },
                values: new object[] { new Guid("6be51be4-cf10-43b9-861c-e58026125ef3"), true, true, new Guid("b2ed2f69-e6c7-482d-b146-ec7d14cde0fb"), new Guid("fc4ce336-fac9-49dc-88f6-f60ff4231985") });

            migrationBuilder.InsertData(
                table: "ReviewOpinions",
                columns: new[] { "Id", "ReviewId", "UserId" },
                values: new object[] { new Guid("b59e0186-2979-4542-8b69-e6436ec34d9c"), new Guid("ab6f6d95-695d-41a2-9fc5-648bc83b16cb"), new Guid("71a7ed13-227f-4a94-aa9a-c0813c60f602") });

            migrationBuilder.InsertData(
                table: "ReviewOpinions",
                columns: new[] { "Id", "IsHelpful", "ReviewId", "UserId" },
                values: new object[] { new Guid("c5255c73-c90c-4bf7-83d7-b8aad55bbde0"), true, new Guid("ab6f6d95-695d-41a2-9fc5-648bc83b16cb"), new Guid("9b0795d2-46f0-493f-b37a-f80cc4700976") });

            migrationBuilder.InsertData(
                table: "ReviewOpinions",
                columns: new[] { "Id", "IsInteresting", "ReviewId", "UserId" },
                values: new object[,]
                {
                    { new Guid("e60f9fc3-1c62-46fc-8307-584d2c9eec1c"), true, new Guid("a2862e81-a1ff-4084-90dd-ce8827ce27e2"), new Guid("a6a707c8-9d67-4b36-8036-86e085670b36") },
                    { new Guid("f25cac52-c01e-4699-bb77-3babe2174b43"), true, new Guid("80d6a3a4-2209-41c5-a826-c2cd87dca72c"), new Guid("a6a707c8-9d67-4b36-8036-86e085670b36") }
                });

            migrationBuilder.InsertData(
                table: "ReviewOpinions",
                columns: new[] { "Id", "IsHelpful", "ReviewId", "UserId" },
                values: new object[] { new Guid("f385b814-ef3b-47e6-be49-f5b77059b4b9"), true, new Guid("2fe24bcb-afa2-42df-bf28-5ea04172e783"), new Guid("a6a707c8-9d67-4b36-8036-86e085670b36") });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_OriginalPosterId",
                table: "Comments",
                column: "OriginalPosterId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ParentId",
                table: "Comments",
                column: "ParentId",
                unique: true,
                filter: "[ParentId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ReviewId",
                table: "Comments",
                column: "ReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_MediaInGenres_GenreId_MediaId",
                table: "MediaInGenres",
                columns: new[] { "GenreId", "MediaId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MediaInGenres_MediaId",
                table: "MediaInGenres",
                column: "MediaId");

            migrationBuilder.CreateIndex(
                name: "IX_Medias_NextId",
                table: "Medias",
                column: "NextId",
                unique: true,
                filter: "[NextId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Medias_PreviousId",
                table: "Medias",
                column: "PreviousId",
                unique: true,
                filter: "[PreviousId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_MediaSources_MediaId",
                table: "MediaSources",
                column: "MediaId");

            migrationBuilder.CreateIndex(
                name: "IX_MediaSources_SourceId",
                table: "MediaSources",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_RelatedMedias_MediaFromId_MediaToId",
                table: "RelatedMedias",
                columns: new[] { "MediaFromId", "MediaToId" },
                unique: true,
                filter: "[MediaFromId] IS NOT NULL AND [MediaToId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_RelatedMedias_MediaToId",
                table: "RelatedMedias",
                column: "MediaToId");

            migrationBuilder.CreateIndex(
                name: "IX_ReviewOpinions_ReviewId",
                table: "ReviewOpinions",
                column: "ReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_ReviewOpinions_UserId_ReviewId",
                table: "ReviewOpinions",
                columns: new[] { "UserId", "ReviewId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_MediaId_OriginalPosterId",
                table: "Reviews",
                columns: new[] { "MediaId", "OriginalPosterId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_OriginalPosterId",
                table: "Reviews",
                column: "OriginalPosterId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaims_RoleId",
                table: "RoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Roles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_TrackedMedias_MediaId",
                table: "TrackedMedias",
                column: "MediaId");

            migrationBuilder.CreateIndex(
                name: "IX_TrackedMedias_UserId_MediaId",
                table: "TrackedMedias",
                columns: new[] { "UserId", "MediaId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                table: "UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogins_UserId",
                table: "UserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "Users",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Users",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "MediaInGenres");

            migrationBuilder.DropTable(
                name: "MediaSources");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "RelatedMedias");

            migrationBuilder.DropTable(
                name: "ReviewOpinions");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "TrackedMedias");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Sources");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Medias");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
