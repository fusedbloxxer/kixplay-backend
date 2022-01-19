using KixPlay_Backend.Data.Abstractions;
using KixPlay_Backend.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KixPlay_Backend.Data.Configuration
{
    public class CommentConfiguration : BaseEntityConfiguration<Guid, Comment>
    {
        protected override void ConfigureProperties(EntityTypeBuilder<Comment> builder)
        {
            builder
                .Property(comment => comment.Content)
                .IsRequired();
        }

        protected override void ConfigureRelations(EntityTypeBuilder<Comment> builder)
        {
            builder
                .HasOne(comment => comment.OriginalPoster)
                .WithMany(originalPoster => originalPoster.Comments)
                .HasForeignKey(comment => comment.OriginalPosterId)
                .HasPrincipalKey(originalPoster => originalPoster.Id)
                .IsRequired();

            builder
                .HasOne(comment => comment.Parent)
                .WithOne();
        }

        protected override void ConfigureSeed(EntityTypeBuilder<Comment> builder)
        {
        }

        protected override void ConfigureTable(EntityTypeBuilder<Comment> builder)
        {
        }
    }
}
