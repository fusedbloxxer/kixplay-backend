using KixPlay_Backend.Data.Abstractions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Text.Json;

namespace KixPlay_Backend.Data.Configuration
{
    public abstract class BaseEntityConfiguration<TKey, TBaseEntity> : IEntityTypeConfiguration<TBaseEntity>
        where TBaseEntity : class, IEntity<TKey>
        where TKey : IEquatable<TKey>
    {
        protected  readonly JsonSerializerOptions _jsonSerializerOptions;

        public BaseEntityConfiguration()
        {
            _jsonSerializerOptions = new JsonSerializerOptions
            {
                WriteIndented = true,
            };
        }

        public void Configure(EntityTypeBuilder<TBaseEntity> builder)
        {
            // Common configuration for all entity types
            ConfigureCommon(builder);

            // Template Method Pattern Configuration
            ConfigureProperties(builder);
            ConfigureRelations(builder);
            ConfigureTable(builder);
        }

        protected abstract void ConfigureProperties(EntityTypeBuilder<TBaseEntity> builder);

        protected abstract void ConfigureRelations(EntityTypeBuilder<TBaseEntity> builder);

        protected abstract void ConfigureTable(EntityTypeBuilder<TBaseEntity> builder);

        private static void ConfigureCommon(EntityTypeBuilder<TBaseEntity> builder)
        {
            builder.Property(entity => entity.CreatedAt).HasDefaultValue(DateTime.Now);
        }
    }
}
