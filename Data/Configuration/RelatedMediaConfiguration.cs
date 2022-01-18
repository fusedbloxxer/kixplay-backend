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
                .HasOne(relatedMedia => relatedMedia.MediaFrom)
                .WithMany(media => media.RelatedFrom)
                .HasForeignKey(relatedMedia => relatedMedia.MediaFromId)
                .HasPrincipalKey(media => media.Id)
                .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction);

            builder
                .HasOne(relatedMedia => relatedMedia.MediaTo)
                .WithMany(media => media.RelatedTo)
                .HasForeignKey(relatedMedia => relatedMedia.MediaToId)
                .HasPrincipalKey(media => media.Id)
                .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction);

            builder
                .HasIndex(relatedMedia => new { relatedMedia.MediaFromId, relatedMedia.MediaToId })
                .IsUnique();
        }

        protected override void ConfigureTable(EntityTypeBuilder<RelatedMedia> builder)
        {
        }
    }
}
