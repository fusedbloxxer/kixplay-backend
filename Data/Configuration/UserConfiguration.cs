using KixPlay_Backend.Data.Abstractions;
using KixPlay_Backend.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KixPlay_Backend.Data.Configuration
{
    public class UserConfiguration : BaseEntityConfiguration<Guid, User>
    {
        protected override void ConfigureProperties(EntityTypeBuilder<User> builder)
        {
        }

        protected override void ConfigureRelations(EntityTypeBuilder<User> builder)
        {
            builder
                .HasMany(user => user.UserRoles)
                .WithOne(userRole => userRole.User)
                .HasForeignKey(userRole => userRole.UserId)
                .IsRequired();

            builder
                .HasMany(user => user.Comments)
                .WithOne(comment => comment.OriginalPoster)
                .HasForeignKey(comment => comment.OriginalPosterId)
                .HasPrincipalKey(user => user.Id)
                .IsRequired();

            builder
                .HasMany(user => user.ReviewOpinions)
                .WithOne(reviewOpinion => reviewOpinion.User)
                .HasForeignKey(reviewOpinion => reviewOpinion.UserId)
                .HasPrincipalKey(user => user.Id)
                .IsRequired();

            builder
                .HasMany(user => user.Reviews)
                .WithOne(review => review.OriginalPoster)
                .HasForeignKey(review => review.OriginalPosterId)
                .HasPrincipalKey(user => user.Id)
                .IsRequired();
        }

        protected override void ConfigureTable(EntityTypeBuilder<User> builder)
        {
            builder
                .ToTable("Users");
        }

        protected override void ConfigureSeed(EntityTypeBuilder<User> builder)
        {
        }
    }
}
