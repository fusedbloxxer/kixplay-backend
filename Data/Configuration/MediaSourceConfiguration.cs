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
                .IsRequired();

            builder
                .HasOne(mediaSource => mediaSource.Source)
                .WithMany(source => source.MediaSources)
                .IsRequired();
        }

        protected override void ConfigureTable(EntityTypeBuilder<MediaSource> builder)
        {
        }

        protected override void ConfigureSeed(EntityTypeBuilder<MediaSource> builder)
        {
        }
    }
}
