using KixPlay_Backend.Data.Abstractions;
using KixPlay_Backend.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KixPlay_Backend.Data.Configuration
{
    public class GenreConfiguration : BaseEntityConfiguration<Guid, Genre>
    {
        protected override void ConfigureProperties(EntityTypeBuilder<Genre> builder)
        {
            builder
                .Property(genre => genre.Name)
                .IsRequired();
        }

        protected override void ConfigureRelations(EntityTypeBuilder<Genre> builder)
        {
            // Add One-To-Many: Genre -< MediaInGenre
            builder
                .HasMany(genre => genre.HasMedias)
                .WithOne(mediaInGenre => mediaInGenre.Genre)
                .HasForeignKey(mediaInGenre => mediaInGenre.GenreId)
                .HasPrincipalKey(genre => genre.Id);
        }

        protected override void ConfigureTable(EntityTypeBuilder<Genre> builder)
        {
        }

        protected override void ConfigureSeed(EntityTypeBuilder<Genre> builder)
        {
        }
    }
}
