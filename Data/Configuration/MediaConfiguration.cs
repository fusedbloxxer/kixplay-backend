using KixPlay_Backend.Data.Abstractions;
using KixPlay_Backend.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.Text.Json;

namespace KixPlay_Backend.Data.Configuration
{
    public class MediaConfiguration : BaseEntityConfiguration<Guid, Media>
    {
        protected override void ConfigureProperties(EntityTypeBuilder<Media> builder)
        {
            builder
                .Property(media => media.Title)
                .HasMaxLength(256)
                .IsRequired();

            builder
                .Property(media => media.Synopsis)
                .HasMaxLength(4096)
                .IsRequired();

            builder
                .Property(media => media.ThumbnailUrl)
                .IsRequired();

            builder
                .Property(media => media.CurrentStatus)
                .HasConversion<string>()
                .IsRequired();

            var listToJsonConverter = new ValueConverter<ICollection<string>, string>(
                list => JsonSerializer.Serialize(list, _jsonSerializerOptions),
                json => JsonSerializer.Deserialize<ICollection<string>>(json, _jsonSerializerOptions)
            );

            builder
                .Property(media => media.PreviewImageUrls)
                .HasConversion(listToJsonConverter);

            builder
                .Property(media => media.PreviewVideoUrls)
                .HasConversion(listToJsonConverter);
        }

        protected override void ConfigureRelations(EntityTypeBuilder<Media> builder)
        {
            builder
                .HasMany(media => media.InGenres)
                .WithOne(mediaInGenre => mediaInGenre.Media)
                .HasForeignKey(mediaInGenre => mediaInGenre.MediaId)
                .HasPrincipalKey(media => media.Id);

            builder
                .HasMany(media => media.MediaSources)
                .WithOne(mediaSources => mediaSources.Media);

            builder
                .HasMany(media => media.RelatedTo)
                .WithOne(mediaTo => mediaTo.MediaTo)
                .HasForeignKey(mediaTo => mediaTo.MediaToId)
                .HasPrincipalKey(media => media.Id)
                .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction);

            builder
                .HasMany(media => media.RelatedFrom)
                .WithOne(mediaFrom => mediaFrom.MediaFrom)
                .HasForeignKey(mediaTo => mediaTo.MediaFromId)
                .HasPrincipalKey(media => media.Id)
                .OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.NoAction);

            builder
                .HasOne(media => media.Next)
                .WithOne()
                .HasPrincipalKey<Media>(media => media.Id);

            builder
                .HasOne(media => media.Previous)
                .WithOne()
                .HasPrincipalKey<Media>(media => media.Id);
        }

        protected override void ConfigureSeed(EntityTypeBuilder<Media> builder)
        {
        }

        protected override void ConfigureTable(EntityTypeBuilder<Media> builder)
        {

        }
    }
}
