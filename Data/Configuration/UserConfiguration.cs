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

            builder
                .HasMany(user => user.TrackedMedias)
                .WithOne(trackedMedia => trackedMedia.User)
                .HasForeignKey(trackedMedia => trackedMedia.UserId)
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
            builder
                .HasData(new List<User>()
                {
                    new User()
                    {
                        Id = Guid.Parse("71a7ed13-227f-4a94-aa9a-c0813c60f602"),
                        UserName = "MikasaAckerman",
                        NormalizedUserName = "MIKASAACKERMAN",
                        FirstName = "Mikasa",
                        LastName = "Ackerman",
                        Email = "mikasa.ackerman@gmail.com",
                        NormalizedEmail = "MIKASA.ACKERMAN@GMAIL.COM",
                        DateOfBirth = DateTime.Today.AddYears(-24),
                        PasswordHash = "AQAAAAEAACcQAAAAEEbyCLf0/2GiiFd4R5D9mAIjPW2Coeg095H59UongM3Osns/UWXnDJ2Rub5PFO9+JQ==",
                        SecurityStamp = Guid.NewGuid().ToString(),
                    },
                    new User()
                    {
                        Id = Guid.Parse("3ca625e3-0648-4d1b-a456-c1c6ee0e0da8"),
                        UserName = "ErenYeager",
                        NormalizedUserName = "ERENYEAGER",
                        FirstName = "Eren",
                        LastName = "Yeager",
                        Email = "eren.yeager@gmail.com",
                        NormalizedEmail = "EREN.YEAGER@GMAIL.COM",
                        DateOfBirth = DateTime.Today.AddYears(-27),
                        PasswordHash = "AQAAAAEAACcQAAAAEEbyCLf0/2GiiFd4R5D9mAIjPW2Coeg095H59UongM3Osns/UWXnDJ2Rub5PFO9+JQ==",
                        SecurityStamp = Guid.NewGuid().ToString(),
                    },
                    new User()
                    {
                        Id = Guid.Parse("fc4ce336-fac9-49dc-88f6-f60ff4231985"),
                        UserName = "LeviLevi",
                        NormalizedUserName = "LEVILEVI",
                        FirstName = "Levi",
                        Email = "levi.ivel@gmail.com",
                        NormalizedEmail = "LEVI.IVEL@GMAIL.COM",
                        DateOfBirth = DateTime.Today.AddYears(-25),
                        PasswordHash = "AQAAAAEAACcQAAAAEEbyCLf0/2GiiFd4R5D9mAIjPW2Coeg095H59UongM3Osns/UWXnDJ2Rub5PFO9+JQ==",
                        SecurityStamp = Guid.NewGuid().ToString(),
                    },
                    new User()
                    {
                        Id = Guid.Parse("9b0795d2-46f0-493f-b37a-f80cc4700976"),
                        UserName = "ArminArlert",
                        NormalizedUserName = "ARMINARLERT",
                        FirstName = "Armin",
                        LastName = "Arlert",
                        Email = "armin.arlert@gmail.com",
                        NormalizedEmail = "ARMIN.ARLERT@GMAIL.COM",
                        DateOfBirth = DateTime.Today.AddYears(-18),
                        PasswordHash = "AQAAAAEAACcQAAAAEEbyCLf0/2GiiFd4R5D9mAIjPW2Coeg095H59UongM3Osns/UWXnDJ2Rub5PFO9+JQ==",
                        SecurityStamp = Guid.NewGuid().ToString(),
                    },
                    new User()
                    {
                        Id = Guid.Parse("a6a707c8-9d67-4b36-8036-86e085670b36"),
                        UserName = "ErwinSmith",
                        NormalizedUserName = "ERWINSMITH",
                        FirstName = "Erwin",
                        LastName = "Smith",
                        Email = "erwin.smith@gmail.com",
                        NormalizedEmail = "ERWIN.SMITH@GMAIL.COM",
                        DateOfBirth = DateTime.Today.AddYears(-22),
                        PasswordHash = "AQAAAAEAACcQAAAAEEbyCLf0/2GiiFd4R5D9mAIjPW2Coeg095H59UongM3Osns/UWXnDJ2Rub5PFO9+JQ==",
                        SecurityStamp = Guid.NewGuid().ToString(),
                    }
                });
        }
    }
}
