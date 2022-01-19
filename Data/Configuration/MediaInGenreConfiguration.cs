using KixPlay_Backend.Data.Abstractions;
using KixPlay_Backend.Data.Entities;
using Microsoft.EntityFrameworkCore;
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
            builder
                .ToTable($"{nameof(MediaInGenre)}s");
        }

        protected override void ConfigureSeed(EntityTypeBuilder<MediaInGenre> builder)
        {
            builder
                .HasData(new List<MediaInGenre>()
                {
                    new MediaInGenre()
                    {
                        Id = Guid.Parse("fcda9b37-4d4e-42f6-93ff-297b7bd6d69e"),
                        MediaId = Guid.Parse("0c36c9b3-d576-4213-8318-49e1882daa38"),
                        GenreId = Guid.Parse("0faa2716-763a-46bd-aeb5-b731070edf23"),
                    },
                    new MediaInGenre()
                    {
                        Id = Guid.Parse("62591aee-1b47-499f-93b0-78977272adea"),
                        MediaId = Guid.Parse("0c36c9b3-d576-4213-8318-49e1882daa38"),
                        GenreId = Guid.Parse("bb85ef16-0dfc-4cf8-a248-929920f775e3"),
                    },
                    new MediaInGenre()
                    {
                        Id = Guid.Parse("29c2ab05-d741-4030-8578-2ee548251784"),
                        MediaId = Guid.Parse("0c36c9b3-d576-4213-8318-49e1882daa38"),
                        GenreId = Guid.Parse("5d90f656-95b7-41e9-afbc-7f03564a2b16"),
                    },
                    new MediaInGenre()
                    {
                        Id = Guid.Parse("8caf43d0-0eed-4e7a-8b1a-02c7a7df0890"),
                        MediaId = Guid.Parse("732e75d1-baa5-43bd-8636-8f91262545b2"),
                        GenreId = Guid.Parse("63f38ef9-382c-4cca-b0fc-000a3aaa2e1e"),
                    },
                    new MediaInGenre()
                    {
                        Id = Guid.Parse("bb56200e-f47e-4bed-97ab-dfc9fb7f90d8"),
                        MediaId = Guid.Parse("e33f7813-258e-4c6c-bf4a-06bfdcdd1095"),
                        GenreId = Guid.Parse("0faa2716-763a-46bd-aeb5-b731070edf23"),
                    },
                    new MediaInGenre()
                    {
                        Id = Guid.Parse("414873c1-82d0-4cb0-bd13-e4a76e3feed5"),
                        MediaId = Guid.Parse("e33f7813-258e-4c6c-bf4a-06bfdcdd1095"),
                        GenreId = Guid.Parse("bb85ef16-0dfc-4cf8-a248-929920f775e3"),
                    },
                    new MediaInGenre()
                    {
                        Id = Guid.Parse("f6ffc53e-1ea7-4e29-b2fc-665f68fef9ff"),
                        MediaId = Guid.Parse("e33f7813-258e-4c6c-bf4a-06bfdcdd1095"),
                        GenreId = Guid.Parse("5d90f656-95b7-41e9-afbc-7f03564a2b16"),
                    },
                    new MediaInGenre()
                    {
                        Id = Guid.Parse("ccae8e17-8759-405f-8d48-a59324956f92"),
                        MediaId = Guid.Parse("e33f7813-258e-4c6c-bf4a-06bfdcdd1095"),
                        GenreId = Guid.Parse("3cf709a3-a95c-4d56-a8d6-2ee490ca7161"),
                    },
                });
        }
    }
}
