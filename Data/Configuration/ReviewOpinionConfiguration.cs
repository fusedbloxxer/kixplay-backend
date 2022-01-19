using KixPlay_Backend.Data.Abstractions;
using KixPlay_Backend.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KixPlay_Backend.Data.Configuration
{
    public class ReviewOpinionConfiguration : BaseEntityConfiguration<Guid, ReviewOpinion>
    {
        protected override void ConfigureProperties(EntityTypeBuilder<ReviewOpinion> builder)
        {
            builder
                .Property(reviewOpinion => reviewOpinion.IsFunny)
                .HasDefaultValue(false);

            builder
                .Property(reviewOpinion => reviewOpinion.IsHelpful)
                .HasDefaultValue(false);

            builder
                .Property(reviewOpinion => reviewOpinion.IsInteresting)
                .HasDefaultValue(false);
        }

        protected override void ConfigureRelations(EntityTypeBuilder<ReviewOpinion> builder)
        {
            builder
                .HasOne(reviewOpinion => reviewOpinion.User)
                .WithMany(user => user.ReviewOpinions)
                .HasForeignKey(reviewOpinion => reviewOpinion.UserId)
                .HasPrincipalKey(user => user.Id)
                .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction)
                .IsRequired();

            builder
                .HasOne(reviewOpinion => reviewOpinion.Review)
                .WithMany(review => review.ReviewOpinions)
                .HasForeignKey(reviewOpinion => reviewOpinion.ReviewId)
                .HasPrincipalKey(review => review.Id)
                .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction)
                .IsRequired();

            builder
                .HasIndex(reviewOpinion => new { reviewOpinion.UserId, reviewOpinion.ReviewId })
                .IsUnique();
        }

        protected override void ConfigureSeed(EntityTypeBuilder<ReviewOpinion> builder)
        {
        }

        protected override void ConfigureTable(EntityTypeBuilder<ReviewOpinion> builder)
        {
            builder
                .ToTable($"{nameof(ReviewOpinion)}s");
        }
    }
}
