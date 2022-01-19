using KixPlay_Backend.Data.Abstractions;
using KixPlay_Backend.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KixPlay_Backend.Data.Configuration
{
    public class SourceConfiguration : BaseEntityConfiguration<Guid, Source>
    {
        protected override void ConfigureProperties(EntityTypeBuilder<Source> builder)
        {
            builder
                .Property(source => source.Url)
                .IsRequired();

            builder
                .Property(source => source.Title)
                .HasMaxLength(256)
                .IsRequired();

            builder
                .Property(source => source.Reliable)
                .HasConversion<string>()
                .IsRequired();
        }

        protected override void ConfigureRelations(EntityTypeBuilder<Source> builder)
        {
            builder
                .HasMany(source => source.MediaSources)
                .WithOne(mediaSource => mediaSource.Source)
                .HasForeignKey(mediaSource => mediaSource.SourceId)
                .HasPrincipalKey(source => source.Id)
                .IsRequired();
        }

        protected override void ConfigureTable(EntityTypeBuilder<Source> builder)
        {
        }

        protected override void ConfigureSeed(EntityTypeBuilder<Source> builder)
        {
            builder
                .HasData(new List<Source>()
                {
                    new Source()
                    {
                        Id = Guid.Parse("4a022ad0-e6e6-4df3-9b95-bf1aa05db9df"),
                        Url = "https://filmeserialegratis.org/",
                        Title = "FSGratis",
                        Description = "FSGratis este un site complet gratuit care contine link-uri catre site-uri de video sharing, mai exact site-uri ce gazduiesc fisiere video, filme, seriale si asa mai departe.",
                        ThumbnailUrl = "https://filmeserialegratis.org/wp-content/uploads/2019/09/logofsgratis-2.png",
                        Reliable = Source.Reliability.Trustworthy,
                    },
                    new Source()
                    {
                        Id = Guid.Parse("a573321a-5c27-4ba9-9903-ee00ca56b4c0"),
                        Url = "https://animepahe.com/",
                        Title = "AnimePahe",
                        Description = "Animepahe is a popular website for anime lovers. You can watch thousands of free anime from Drama, History, Action, Romance and more. Animepahe is confident ...",
                        ThumbnailUrl = "http://wasabi-files.lbstatic.nu/files/users/large/9666248_logo-animepahe.jpg?1629794131",
                        Reliable = Source.Reliability.Sussy,
                    },
                    new Source()
                    {
                        Id = Guid.Parse("eee0f7d1-9080-452e-97e6-7773190a59a8"),
                        Url = "https://animixplay.to/",
                        Title = "AnimixPlay",
                        Description = "Watch Anime for free in HD quality with English subbed or dubbed.",
                        ThumbnailUrl = "https://i.imgur.com/RO2x9O5.png",
                        Reliable = Source.Reliability.Trustworthy,
                    },
                });
        }
    }
}
