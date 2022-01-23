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

            builder
                .HasIndex(genre => genre.Name)
                .IsUnique();
        }

        protected override void ConfigureTable(EntityTypeBuilder<Genre> builder)
        {
        }

        protected override void ConfigureSeed(EntityTypeBuilder<Genre> builder)
        {
            builder
                .HasData(new List<Genre>()
                {
                    new Genre()
                    {
                        Id = Guid.Parse("0faa2716-763a-46bd-aeb5-b731070edf23"),
                        Name = "horror",
                    },
                    new Genre()
                    {
                        Id = Guid.Parse("63f38ef9-382c-4cca-b0fc-000a3aaa2e1e"),
                        Name = "action",
                    },
                    new Genre()
                    {
                        Id = Guid.Parse("bb85ef16-0dfc-4cf8-a248-929920f775e3"),
                        Name = "thriller",
                    },
                    new Genre()
                    {
                        Id = Guid.Parse("5d90f656-95b7-41e9-afbc-7f03564a2b16"),
                        Name = "slowburn",
                    },
                    new Genre()
                    {
                        Id = Guid.Parse("3cf709a3-a95c-4d56-a8d6-2ee490ca7161"),
                        Name = "drama",
                    },
                });
        }
    }
}
