using KixPlay_Backend.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KixPlay_Backend.Data.Configuration
{
    public class RelatedMediaConfiguration : BaseEntityConfiguration<Guid, RelatedMedia>
    {
        protected override void ConfigureProperties(EntityTypeBuilder<RelatedMedia> builder)
        {
            builder
                .Property(relatedMedia => relatedMedia.Relationship)
                .HasConversion<string>()
                .IsRequired();
        }

        protected override void ConfigureRelations(EntityTypeBuilder<RelatedMedia> builder)
        {
            builder
                .HasOne(relatedMedia => relatedMedia.Previous)
                .WithMany(media => media.RelatedMedias);

            builder
                .HasOne(relatedMedia => relatedMedia.Next)
                .WithMany(media => media.RelatedMedias);
        }

        protected override void ConfigureTable(EntityTypeBuilder<RelatedMedia> builder)
        {
        }
    }
}
