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
                .WithOne(mediaSource => mediaSource.Source);
        }

        protected override void ConfigureTable(EntityTypeBuilder<Source> builder)
        {
        }
    }
}
