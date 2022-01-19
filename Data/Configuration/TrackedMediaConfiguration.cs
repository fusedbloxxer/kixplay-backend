using KixPlay_Backend.Data.Abstractions;
using KixPlay_Backend.Data.Entities;
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

        protected override void ConfigureSeed(EntityTypeBuilder<TrackedMedia> builder)
        {
        }

        protected override void ConfigureTable(EntityTypeBuilder<TrackedMedia> builder)
        {
        }
    }
}
