using KixPlay_Backend.Data.Abstractions;
using KixPlay_Backend.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KixPlay_Backend.Data.Configuration
{
    public class ReviewConfiguration : BaseEntityConfiguration<Guid, Review>
    {
        protected override void ConfigureProperties(EntityTypeBuilder<Review> builder)
        {
            builder
                .Property(review => review.Title)
                .HasMaxLength(256)
                .IsRequired();

            builder
                .Property(review => review.Content)
                .IsRequired();

            builder
                .Property(review => review.Rating)
                .IsRequired();

            builder
                .HasCheckConstraint("CK_VALID_RATING", $"[{nameof(Review.Rating)}] BETWEEN 0 and 10");

            builder
                .Property(review => review.HasSpoilers)
                .HasDefaultValue(false);

            builder
                .Property(review => review.Recommended)
                .ValueGeneratedNever()
                .HasDefaultValue(true);
        }

        protected override void ConfigureRelations(EntityTypeBuilder<Review> builder)
        {
            builder
                .HasMany(review => review.Comments)
                .WithOne(comment => comment.Review)
                .HasForeignKey(comment => comment.ReviewId)
                .HasPrincipalKey(review => review.Id)
                .IsRequired();

            builder
                .HasOne(review => review.Media)
                .WithMany(media => media.Reviews)
                .HasForeignKey(review => review.MediaId)
                .HasPrincipalKey(media => media.Id)
                .IsRequired();

            builder
                .HasOne(review => review.OriginalPoster)
                .WithMany(user => user.Reviews)
                .HasForeignKey(review => review.OriginalPosterId)
                .HasPrincipalKey(user => user.Id)
                .IsRequired();

            builder
                .HasIndex(review => new { review.MediaId, review.OriginalPosterId })
                .IsUnique();

            builder
                .HasMany(review => review.ReviewOpinions)
                .WithOne(reviewOpinion => reviewOpinion.Review)
                .HasForeignKey(reviewOpinion => reviewOpinion.ReviewId)
                .HasPrincipalKey(review => review.Id)
                .IsRequired();
        }

        protected override void ConfigureSeed(EntityTypeBuilder<Review> builder)
        {
        }

        protected override void ConfigureTable(EntityTypeBuilder<Review> builder)
        {
            builder
                .ToTable($"{nameof(Review)}s");
        }
    }
}
