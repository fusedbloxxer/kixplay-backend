using KixPlay_Backend.Data.Configuration;
using KixPlay_Backend.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace KixPlay_Backend.Data
{
    public class DataContext : IdentityDbContext<User, Role, Guid, IdentityUserClaim<Guid>, UserRole, IdentityUserLogin<Guid>, IdentityRoleClaim<Guid>, IdentityUserToken<Guid>>
    {
        public DbSet<Media> Medias { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<Source> Sources { get; set; }

        public DbSet<MediaSource> MediaSources { get; set; }

        public DbSet<Entities.RelatedMedia> RelatedMedias { get; set; }

        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            ConfigureTables(builder);

            AddRelations(builder);

            RenameTables(builder);

            SeedWithData(builder);
        }

        private static void ConfigureTables(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        private static void AddRelations(ModelBuilder builder)
        {

        }

        private static void RenameTables(ModelBuilder builder)
        {
            builder.Entity<IdentityUserClaim<Guid>>()
                .ToTable("UserClaims");

            builder.Entity<IdentityRoleClaim<Guid>>()
                .ToTable("RoleClaims");

            builder.Entity<IdentityUserLogin<Guid>>()
                .ToTable("UserLogins");

            builder.Entity<IdentityUserToken<Guid>>()
                .ToTable("UserTokens");
        }

        private static void SeedWithData(ModelBuilder builder)
        {
        }
    }
}
