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

        protected override void ConfigureTable(EntityTypeBuilder<ReviewOpinion> builder)
        {
            builder
                .ToTable($"{nameof(ReviewOpinion)}s");
        }

        protected override void ConfigureSeed(EntityTypeBuilder<ReviewOpinion> builder)
        {
            builder
                .HasData(new List<ReviewOpinion>()
                {
                    new ReviewOpinion()
                    {
                        Id = Guid.NewGuid(),
                        UserId = Guid.Parse("3ca625e3-0648-4d1b-a456-c1c6ee0e0da8"),
                        ReviewId = Guid.Parse("80d6a3a4-2209-41c5-a826-c2cd87dca72c"),
                        IsFunny = true,
                    },
                    new ReviewOpinion()
                    {
                        Id = Guid.NewGuid(),
                        UserId = Guid.Parse("9b0795d2-46f0-493f-b37a-f80cc4700976"),
                        ReviewId = Guid.Parse("80d6a3a4-2209-41c5-a826-c2cd87dca72c"),
                        IsHelpful = true,
                        IsFunny = true,
                    },
                    new ReviewOpinion()
                    {
                        Id = Guid.NewGuid(),
                        UserId = Guid.Parse("a6a707c8-9d67-4b36-8036-86e085670b36"),
                        ReviewId = Guid.Parse("80d6a3a4-2209-41c5-a826-c2cd87dca72c"),
                        IsInteresting = true,
                    },
                    new ReviewOpinion()
                    {
                        Id = Guid.NewGuid(),
                        UserId = Guid.Parse("9b0795d2-46f0-493f-b37a-f80cc4700976"),
                        ReviewId = Guid.Parse("ab6f6d95-695d-41a2-9fc5-648bc83b16cb"),
                        IsHelpful = true,
                    },
                    new ReviewOpinion()
                    {
                        Id = Guid.NewGuid(),
                        UserId = Guid.Parse("71a7ed13-227f-4a94-aa9a-c0813c60f602"),
                        ReviewId = Guid.Parse("ab6f6d95-695d-41a2-9fc5-648bc83b16cb"),
                    },
                    new ReviewOpinion()
                    {
                        Id = Guid.NewGuid(),
                        UserId = Guid.Parse("fc4ce336-fac9-49dc-88f6-f60ff4231985"),
                        ReviewId = Guid.Parse("b2ed2f69-e6c7-482d-b146-ec7d14cde0fb"),
                        IsInteresting = true,
                        IsHelpful= true,
                    },
                    new ReviewOpinion()
                    {
                        Id = Guid.NewGuid(),
                        UserId = Guid.Parse("a6a707c8-9d67-4b36-8036-86e085670b36"),
                        ReviewId = Guid.Parse("a2862e81-a1ff-4084-90dd-ce8827ce27e2"),
                        IsInteresting = true,
                    },
                    new ReviewOpinion()
                    {
                        Id = Guid.NewGuid(),
                        UserId = Guid.Parse("a6a707c8-9d67-4b36-8036-86e085670b36"),
                        ReviewId = Guid.Parse("2fe24bcb-afa2-42df-bf28-5ea04172e783"),
                        IsHelpful= true,
                    },
                });
        }
    }
}
