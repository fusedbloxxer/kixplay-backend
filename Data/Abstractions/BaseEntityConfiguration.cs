using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Text.Json;

namespace KixPlay_Backend.Data.Abstractions
{
    public abstract class BaseEntityConfiguration<TKey, TEntity> : IEntityTypeConfiguration<TEntity>
        where TEntity : class, IEntity<TKey>
        where TKey : IEquatable<TKey>
    {
        protected readonly JsonSerializerOptions _jsonSerializerOptions;

        public BaseEntityConfiguration()
        {
            _jsonSerializerOptions = new JsonSerializerOptions
            {
                WriteIndented = true,
            };
        }

        public void Configure(EntityTypeBuilder<TEntity> builder)
        {
            // Common configuration for all entity types
            ConfigureCommon(builder);

            // Template Method Pattern Configuration
            ConfigureProperties(builder);
            ConfigureRelations(builder);
            ConfigureTable(builder);
            ConfigureSeed(builder);
        }
        protected abstract void ConfigureProperties(EntityTypeBuilder<TEntity> builder);

        protected abstract void ConfigureRelations(EntityTypeBuilder<TEntity> builder);

        protected abstract void ConfigureTable(EntityTypeBuilder<TEntity> builder);

        protected abstract void ConfigureSeed(EntityTypeBuilder<TEntity> builder);

        private static void ConfigureCommon(EntityTypeBuilder<TEntity> builder)
        {
            builder
                .Property(entity => entity.Id)
                .ValueGeneratedOnAdd();

            builder
                .Property(entity => entity.CreatedAt)
                .HasDefaultValueSql("GETDATE()");

            builder
                .Property(entity => entity.LastUpdatedAt)
                .HasDefaultValueSql("GETDATE()");
        }
    }
}
