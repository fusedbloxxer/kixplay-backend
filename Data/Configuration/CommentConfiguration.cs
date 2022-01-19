using KixPlay_Backend.Data.Abstractions;
using KixPlay_Backend.Data.Entities;
using Microsoft.EntityFrameworkCore;
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
                .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction)
                .IsRequired();

            builder
                .HasOne(comment => comment.Review)
                .WithMany(review => review.Comments)
                .HasForeignKey(comment => comment.ReviewId)
                .HasPrincipalKey(review => review.Id)
                .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction)
                .IsRequired();

            builder
                .HasMany(comment => comment.Children)
                .WithOne()
                .HasForeignKey(comment => comment.ParentId)
                .HasPrincipalKey(comment => comment.Id)
                .IsRequired(false);
        }

        protected override void ConfigureTable(EntityTypeBuilder<Comment> builder)
        {
            builder
                .ToTable($"{nameof(Comment)}s");
        }

        protected override void ConfigureSeed(EntityTypeBuilder<Comment> builder)
        {
            builder
                .HasData(new List<Comment>()
                {
                    new Comment()
                    {
                        Id = Guid.Parse("d4b6ab4b-fdce-4790-96f2-074ac0061c69"),
                        ParentId = null,
                        OriginalPosterId = Guid.Parse("71a7ed13-227f-4a94-aa9a-c0813c60f602"),
                        ReviewId = Guid.Parse("80d6a3a4-2209-41c5-a826-c2cd87dca72c"),
                        Content = "Root 1 Comment",
                    },
                    new Comment()
                    {
                        Id = Guid.Parse("b2737562-1423-4a90-812f-9730bef8a656"),
                        ParentId = Guid.Parse("d4b6ab4b-fdce-4790-96f2-074ac0061c69"),
                        OriginalPosterId = Guid.Parse("3ca625e3-0648-4d1b-a456-c1c6ee0e0da8"),
                        ReviewId = Guid.Parse("80d6a3a4-2209-41c5-a826-c2cd87dca72c"),
                        Content = "Child 1 Comment",
                    },
                    new Comment()
                    {
                        Id = Guid.Parse("af5ebe4e-0c36-4e3c-8375-39efe513c760"),
                        ParentId = Guid.Parse("d4b6ab4b-fdce-4790-96f2-074ac0061c69"),
                        OriginalPosterId = Guid.Parse("fc4ce336-fac9-49dc-88f6-f60ff4231985"),
                        ReviewId = Guid.Parse("80d6a3a4-2209-41c5-a826-c2cd87dca72c"),
                        Content = "Child 1 Sibling Comment",
                    },
                    new Comment()
                    {
                        Id = Guid.Parse("b42f6170-aedb-4046-8627-4c418d072124"),
                        ParentId = Guid.Parse("b2737562-1423-4a90-812f-9730bef8a656"),
                        OriginalPosterId = Guid.Parse("71a7ed13-227f-4a94-aa9a-c0813c60f602"),
                        ReviewId = Guid.Parse("80d6a3a4-2209-41c5-a826-c2cd87dca72c"),
                        Content = "Child 2 Comment",
                    },      
                    new Comment()
                    {
                        Id = Guid.Parse("1b2748c6-0b46-4437-b785-93351eba229a"),
                        ParentId = null,
                        OriginalPosterId = Guid.Parse("71a7ed13-227f-4a94-aa9a-c0813c60f602"),
                        ReviewId = Guid.Parse("a2862e81-a1ff-4084-90dd-ce8827ce27e2"),
                        Content = "Root 2 Comment",
                    },
                    new Comment()
                    {
                        Id = Guid.Parse("f798ed71-46c2-47f0-9dda-fc97efdb0c49"),
                        ParentId = Guid.Parse("1b2748c6-0b46-4437-b785-93351eba229a"),
                        OriginalPosterId = Guid.Parse("9b0795d2-46f0-493f-b37a-f80cc4700976"),
                        ReviewId = Guid.Parse("a2862e81-a1ff-4084-90dd-ce8827ce27e2"),
                        Content = "Child 1' Comment",
                    },
                    new Comment()
                    {
                        Id = Guid.Parse("a023367a-8d82-4b5e-ac4d-8f305f14d647"),
                        ParentId = Guid.Parse("f798ed71-46c2-47f0-9dda-fc97efdb0c49"),
                        OriginalPosterId = Guid.Parse("9b0795d2-46f0-493f-b37a-f80cc4700976"),
                        ReviewId = Guid.Parse("a2862e81-a1ff-4084-90dd-ce8827ce27e2"),
                        Content = "Child 2' Comment",
                    },
                });
        }
    }
}
