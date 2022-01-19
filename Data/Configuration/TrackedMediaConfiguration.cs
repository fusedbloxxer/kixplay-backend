using KixPlay_Backend.Data.Abstractions;
using KixPlay_Backend.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KixPlay_Backend.Data.Configuration
{
    public class TrackedMediaConfiguration : BaseEntityConfiguration<Guid, TrackedMedia>
    {
        protected override void ConfigureProperties(EntityTypeBuilder<TrackedMedia> builder)
        {
            builder
                .Property(trackedMedia => trackedMedia.Status)
                .HasConversion<string>()
                .IsRequired();
        }

        protected override void ConfigureRelations(EntityTypeBuilder<TrackedMedia> builder)
        {
            builder
                .HasOne(trackedMedia => trackedMedia.User)
                .WithMany(user => user.TrackedMedias)
                .HasForeignKey(trackedMedia => trackedMedia.UserId)
                .HasPrincipalKey(user => user.Id)
                .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction)
                .IsRequired();

            builder
                .HasOne(trackedMedia => trackedMedia.Media)
                .WithMany(media => media.TrackedMedias)
                .HasForeignKey(trackedMedia => trackedMedia.MediaId)
                .HasPrincipalKey(media => media.Id)
                .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction)
                .IsRequired();

            builder
                .HasIndex(trackedMedia => new { trackedMedia.UserId, trackedMedia.MediaId })
                .IsUnique();
        }

        protected override void ConfigureTable(EntityTypeBuilder<TrackedMedia> builder)
        {
            builder
                .ToTable($"{nameof(TrackedMedia)}s");
        }

        protected override void ConfigureSeed(EntityTypeBuilder<TrackedMedia> builder)
        {
            builder
                .HasData(new List<TrackedMedia>()
                {
                    new TrackedMedia()
                    {
                        Id = Guid.Parse("a62a6a8e-0211-4eff-a4a6-a0dc6a7a64c8"),
                        UserId = Guid.Parse("71a7ed13-227f-4a94-aa9a-c0813c60f602"),
                        MediaId = Guid.Parse("0c36c9b3-d576-4213-8318-49e1882daa38"),
                        Status = TrackedMedia.WatchStatus.Watched,
                    },
                    new TrackedMedia()
                    {
                        Id = Guid.Parse("1a9ab45f-3b57-48b6-8829-7c9e14271aca"),
                        UserId = Guid.Parse("71a7ed13-227f-4a94-aa9a-c0813c60f602"),
                        MediaId = Guid.Parse("732e75d1-baa5-43bd-8636-8f91262545b2"),
                        Status = TrackedMedia.WatchStatus.ToWatch,
                    },
                    new TrackedMedia()
                    {
                        Id = Guid.Parse("e9fceb36-89a3-46c2-9888-0198471c2029"),
                        UserId = Guid.Parse("71a7ed13-227f-4a94-aa9a-c0813c60f602"),
                        MediaId = Guid.Parse("e33f7813-258e-4c6c-bf4a-06bfdcdd1095"),
                        Status = TrackedMedia.WatchStatus.Watched,
                    },
                    new TrackedMedia()
                    {
                        Id = Guid.Parse("f0de9466-968a-4e9f-b3c3-3fe09eaeb383"),
                        UserId = Guid.Parse("3ca625e3-0648-4d1b-a456-c1c6ee0e0da8"),
                        MediaId = Guid.Parse("732e75d1-baa5-43bd-8636-8f91262545b2"),
                        Status = TrackedMedia.WatchStatus.ToWatch,
                    },
                    new TrackedMedia()
                    {
                        Id = Guid.Parse("e35e01fa-d822-4d44-a528-d230c1df43e9"),
                        UserId = Guid.Parse("3ca625e3-0648-4d1b-a456-c1c6ee0e0da8"),
                        MediaId = Guid.Parse("e33f7813-258e-4c6c-bf4a-06bfdcdd1095"),
                        Status = TrackedMedia.WatchStatus.Watched,
                    },
                    new TrackedMedia()
                    {
                        Id = Guid.Parse("87b92312-864b-4bd2-a52d-a5e641c8d8f7"),
                        UserId = Guid.Parse("fc4ce336-fac9-49dc-88f6-f60ff4231985"),
                        MediaId = Guid.Parse("0c36c9b3-d576-4213-8318-49e1882daa38"),
                        Status = TrackedMedia.WatchStatus.Watching,
                    },
                    new TrackedMedia()
                    {
                        Id = Guid.Parse("9c7128df-7b0e-49fa-b25f-c53d218b3d3e"),
                        UserId = Guid.Parse("9b0795d2-46f0-493f-b37a-f80cc4700976"),
                        MediaId = Guid.Parse("0c36c9b3-d576-4213-8318-49e1882daa38"),
                        Status = TrackedMedia.WatchStatus.OnPause,
                    },
                    new TrackedMedia()
                    {
                        Id = Guid.Parse("36389164-992e-4a82-9283-4b3af2389cd6"),
                        UserId = Guid.Parse("a6a707c8-9d67-4b36-8036-86e085670b36"),
                        MediaId = Guid.Parse("e33f7813-258e-4c6c-bf4a-06bfdcdd1095"),
                        Status = TrackedMedia.WatchStatus.Dropped,
                    },
                });
        }
    }
}
