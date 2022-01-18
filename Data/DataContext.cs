using KixPlay_Backend.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace KixPlay_Backend.Data
{
    public class DataContext : IdentityDbContext<User, Role, Guid, IdentityUserClaim<Guid>, UserRole, IdentityUserLogin<Guid>, IdentityRoleClaim<Guid>, IdentityUserToken<Guid>>
    {
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
            builder.Entity<User>()
                .Property(user => user.CreatedAt)
                .HasDefaultValue(DateTime.Now);

            builder.Entity<Role>()
                .Property(Role => Role.CreatedAt)
                .HasDefaultValue(DateTime.Now);

            builder.Entity<UserRole>()
                .Property(UserRole => UserRole.AddedAt)
                .HasDefaultValue(DateTime.Now);
        }

        private static void AddRelations(ModelBuilder builder)
        {
            // Add One-To-Many: User -> UserRole
            builder.Entity<User>()
                .HasMany(user => user.UserRoles)
                .WithOne(userRole => userRole.User)
                .HasForeignKey(userRole => userRole.UserId)
                .IsRequired();

            // Add One-To-Many: Role -> UserRole
            builder.Entity<Role>()
                .HasMany(role => role.UserRoles)
                .WithOne(userRole => userRole.Role)
                .HasForeignKey(userRole => userRole.RoleId)
                .IsRequired();

            // Add Many-To-One: UserRole >- User
            builder.Entity<UserRole>()
                .HasOne(userRole => userRole.User)
                .WithMany(user => user.UserRoles);

            // Add Many-To-One: UserRole >- Role
            builder.Entity<UserRole>()
                .HasOne(userRole => userRole.Role)
                .WithMany(role => role.UserRoles);
        }

        private static void RenameTables(ModelBuilder builder)
        {
            builder.Entity<User>()
                .ToTable("Users");

            builder.Entity<Role>()
                .ToTable("Roles");

            builder.Entity<UserRole>()
                .ToTable("UserRoles");

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
            builder.Entity<Role>().HasData(Role.Roles);
        }
    }
}
