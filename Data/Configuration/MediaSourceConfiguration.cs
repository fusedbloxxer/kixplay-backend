using KixPlay_Backend.Data.Abstractions;
using KixPlay_Backend.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KixPlay_Backend.Data.Configuration
{
    public class MediaSourceConfiguration : BaseEntityConfiguration<Guid, MediaSource>
    {
        protected override void ConfigureProperties(EntityTypeBuilder<MediaSource> builder)
        {
            builder
                .Property(mediaSource => mediaSource.Url)
                .IsRequired();
        }

        protected override void ConfigureRelations(EntityTypeBuilder<MediaSource> builder)
        {
            builder
                .HasOne(mediaSource => mediaSource.Media)
                .WithMany(media => media.MediaSources)
                .HasForeignKey(mediaSource => mediaSource.MediaId)
                .HasPrincipalKey(media => media.Id)
                .IsRequired();

            builder
                .HasOne(mediaSource => mediaSource.Source)
                .WithMany(source => source.MediaSources)
                .HasForeignKey(mediaSource => mediaSource.SourceId)
                .HasPrincipalKey(source => source.Id)
                .IsRequired();
        }

        protected override void ConfigureTable(EntityTypeBuilder<MediaSource> builder)
        {
        }

        protected override void ConfigureSeed(EntityTypeBuilder<MediaSource> builder)
        {
            builder
                .HasData(new List<MediaSource>()
                {
                    new MediaSource()
                    {
                        Id = Guid.Parse("2f5ba7de-9a8f-434b-a61e-764dfe656bfb"),
                        MediaId = Guid.Parse("0c36c9b3-d576-4213-8318-49e1882daa38"),
                        SourceId = Guid.Parse("4a022ad0-e6e6-4df3-9b95-bf1aa05db9df"),
                        Url = "https://filmeserialegratis.org/fractured/",
                    },
                    new MediaSource()
                    {
                        Id = Guid.Parse("f0c5a927-2ac3-4fd9-b31b-88b4d377325d"),
                        MediaId = Guid.Parse("e33f7813-258e-4c6c-bf4a-06bfdcdd1095"),
                        SourceId = Guid.Parse("4a022ad0-e6e6-4df3-9b95-bf1aa05db9df"),
                        Url = "https://filmeserialegratis.org/the-invitation-invitatia/",
                    },
                });
        }
    }
}
