using KixPlay_Backend.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KixPlay_Backend.Data.Configuration
{
    public class MediaInGenreConfiguration : BaseEntityConfiguration<Guid, MediaInGenre>
    {
        protected override void ConfigureProperties(EntityTypeBuilder<MediaInGenre> builder)
        {
        }

        protected override void ConfigureRelations(EntityTypeBuilder<MediaInGenre> builder)
        {
            builder
                .HasOne(mediaInGenre => mediaInGenre.Genre)
                .WithMany(genre => genre.HasMedias)
                .HasForeignKey(mediaInGenre => mediaInGenre.GenreId)
                .HasPrincipalKey(genre => genre.Id)
                .IsRequired();

            builder
                .HasOne(mediaInGenre => mediaInGenre.Media)
                .WithMany(media => media.InGenres)
                .HasForeignKey(mediaInGenre => mediaInGenre.MediaId)
                .HasPrincipalKey(media => media.Id)
                .IsRequired();

            builder
                .HasIndex(mediaInGenre => new { mediaInGenre.GenreId, mediaInGenre.MediaId })
                .IsUnique();
        }

        protected override void ConfigureTable(EntityTypeBuilder<MediaInGenre> builder)
        {
        }
    }
}
