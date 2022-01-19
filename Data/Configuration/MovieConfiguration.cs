using KixPlay_Backend.Data.Abstractions;
using KixPlay_Backend.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KixPlay_Backend.Data.Configuration
{
    public class MovieConfiguration : BaseEntityConfiguration<Guid, Movie>
    {
        protected override void ConfigureProperties(EntityTypeBuilder<Movie> builder)
        {
            builder
                .Property(movie => movie.MetreageType)
                .HasConversion<string>()
                .IsRequired();
        }

        protected override void ConfigureRelations(EntityTypeBuilder<Movie> builder)
        {
        }

        protected override void ConfigureSeed(EntityTypeBuilder<Movie> builder)
        {
        }

        protected override void ConfigureTable(EntityTypeBuilder<Movie> builder)
        {
            builder
                .ToTable($"{nameof(Movie)}s");
        }
    }
}
