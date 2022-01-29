using KixPlay_Backend.Data.Abstractions;
using KixPlay_Backend.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KixPlay_Backend.Data.Configuration
{
    public class MovieConfiguration : BaseEntityConfiguration<Guid, Movie>
    {
        protected override void ConfigureProperties(EntityTypeBuilder<Movie> builder)
        {
            builder
                .Property(movie => movie.MetreageType)
                .HasConversion<string>()
                .IsRequired();
        }

        protected override void ConfigureRelations(EntityTypeBuilder<Movie> builder)
        {
        }

        protected override void ConfigureTable(EntityTypeBuilder<Movie> builder)
        {
            builder
                .ToTable($"{nameof(Movie)}s");
        }

        protected override void ConfigureSeed(EntityTypeBuilder<Movie> builder)
        {
            builder
                .HasData(new List<Movie>()
                {
                    new Movie()
                    {
                        Id = Guid.Parse("0c36c9b3-d576-4213-8318-49e1882daa38"),
                        Title = "Fractured",
                        Synopsis = "A couple stops at a gas station, where their 6 y.o. daughter's arm is fractured. They hurry to a hospital. Something strange is going on there. The wife and daughter go missing.",
                        Description = "Driving cross-country, Ray and his wife and daughter stop at a highway rest area where his daughter falls and breaks her arm. After a frantic rush to the hospital and a clash with the check-in nurse, Ray is finally able to get her to a doctor. While the wife and daughter go downstairs for an MRI, Ray, exhausted, passes out in a chair in the lobby. Upon waking up, they have no record or knowledge of Ray's family ever being checked in.—Alan B. McElroy",
                        BannerUrl = "https://i2-prod.mirror.co.uk/incoming/article20584611.ece/ALTERNATES/s1200b/1_Fractured_00_10_38_22_R.jpg",
                        ThumbnailUrl = "https://m.media-amazon.com/images/M/MV5BZTE0MWE4NzMtMzc4Ny00NWE4LTg2OTQtZmIyNDdhZjdiZmJhXkEyXkFqcGdeQXVyMzY0MTE3NzU@._V1_.jpg",
                        Duration = TimeSpan.FromHours(1).Add(TimeSpan.FromMinutes(40)),
                        ReleaseDate = DateTime.Parse("2019-09-22"),
                        AiringStatus = Media.AirStatus.Aired,
                        MetreageType = Movie.Metreage.Long,
                        PreviewImageUrls = new List<string>()
                        {
                            "https://occ-0-2794-2219.1.nflxso.net/dnm/api/v6/E8vDc_W8CLv7-yMQu8KMEC7Rrr8/AAAABSrkPHFHFt3JHfZOtaq2Naho-W8R0qxyTgNmDuM5etrbqvn_8hBS34qp5co6gh9EeW9I61LmTGx_yGG3ytieoDgjuHdF.jpg?r=054",
                            "https://www.refinery29.com/images/8556165.jpg?crop=2000%2C1051%2Cx0%2Cy133",
                            "https://d2e111jq13me73.cloudfront.net/sites/default/files/styles/share_link_image_large/public/screenshots/csm-movie/fractured-screenshot-1.jpg?itok=eLiXNoOY"
                        },
                        PreviewVideoUrls = new List<string>()
                        {
                            "https://www.youtube.com/watch?v=S8obCz5NSog",
                        },
                        WonAwards = 15,
                    },
                    new Movie()
                    {
                        Id = Guid.Parse("732e75d1-baa5-43bd-8636-8f91262545b2"),
                        Title = "The Northman",
                        Synopsis = "Written by Eggers and Icelandic poet and novelist Sjón Sigurdsson, Northman is described as a grounded story set in Iceland at the turn of the 10th century that centres on a Nordic prince who seeks revenge for the death of his father.",
                        Description = "From acclaimed director Robert Eggers, The Northman is an epic revenge thriller that explores how far a Viking prince will go to seek justice for his murdered father.",
                        BannerUrl = "https://i.ytimg.com/vi/oMSdFM12hOw/maxresdefault.jpg",
                        ThumbnailUrl = "https://images.justwatch.com/poster/257876484/s718c",
                        Duration = TimeSpan.FromHours(2).Add(TimeSpan.FromMinutes(20)),
                        ReleaseDate = DateTime.Parse("2022-04-22"),
                        AiringStatus = Media.AirStatus.Unreleased,
                        MetreageType = Movie.Metreage.Long,
                        PreviewImageUrls = new List<string>()
                        {
                            "https://decider.com/wp-content/uploads/2021/12/The-Northman.jpg?quality=80&strip=all",
                            "https://static1.colliderimages.com/wordpress/wp-content/uploads/2021/12/Alexander-Skarsgard-and-Anya-Taylor-Joy-The-Northman-social.jpg",
                            "https://m.media-amazon.com/images/M/MV5BYjA3NjkyZjYtN2UwZC00MWM5LTk4MDUtMzcxNDU4ZDE3OWZkXkEyXkFqcGdeQWpnYW1i._V1_QL75_UX500_CR0,0,500,281_.jpg"
                        },
                        PreviewVideoUrls = new List<string>()
                        {
                            "https://www.youtube.com/watch?v=oMSdFM12hOw",
                        },
                        WonAwards = 0,
                    },
                    new Movie()
                    {
                        Id = Guid.Parse("e33f7813-258e-4c6c-bf4a-06bfdcdd1095"),
                        Title = "The Invitation",
                        Synopsis = "A man accepts an invitation to a dinner party hosted by his ex-wife, an unsettling affair that reopens old wounds and creates new tensions.",
                        Description = "A man accepts an invitation to a dinner party hosted by his ex-wife, an unsettling affair that reopens old wounds and creates new tensions. A man accepts an invitation to a dinner party hosted by his ex-wife, an unsettling affair that reopens old wounds and creates new tensions.",
                        BannerUrl = "https://s3.amazonaws.com/static.rogerebert.com/uploads/review/primary_image/reviews/the-invitation-2016/The-Invitation-2016.jpg",
                        ThumbnailUrl = "https://m.media-amazon.com/images/M/MV5BMTkzODMwNDkzOF5BMl5BanBnXkFtZTgwNDA4NzA1ODE@._V1_.jpg",
                        Duration = TimeSpan.FromHours(1).Add(TimeSpan.FromMinutes(40)),
                        ReleaseDate = DateTime.Parse("2015-03-13"),
                        AiringStatus = Media.AirStatus.Aired,
                        MetreageType = Movie.Metreage.Long,
                        PreviewImageUrls = new List<string>()
                        {
                            "https://static01.nyt.com/images/2016/04/08/arts/08INVITE/08INVITE-superJumbo.jpg",
                            "https://m.media-amazon.com/images/M/MV5BMTgzMTU1NjE4N15BMl5BanBnXkFtZTgwOTU3ODM1ODE@._V1_.jpg",
                            "http://www.moriareviews.com/rongulator/wp-content/uploads/Invitation-2015-8.jpg"
                        },
                        PreviewVideoUrls = new List<string>()
                        {
                            "https://www.youtube.com/watch?v=0-mp77SZ_0M",
                        },
                        WonAwards = 10,
                    },
                });
        }
    }
}
