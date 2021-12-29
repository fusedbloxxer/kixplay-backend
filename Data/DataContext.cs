﻿using KixPlay_Backend.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace KixPlay_Backend.Data
{
    public class DataContext : IdentityDbContext<
        User, Role, string,
        IdentityUserClaim<string>, UserRole, IdentityUserLogin<string>,
        IdentityRoleClaim<string>, IdentityUserToken<string>>
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            AddRelations(builder);
            
            RenameTables(builder);
        }

        private static void AddRelations(ModelBuilder builder)
        {
            // Add One-To-Many: User -> UserRoles
            builder.Entity<User>()
                .HasMany(user => user.UserRoles)
                .WithOne(userRole => userRole.User)
                .HasForeignKey(userRole => userRole.UserId);

            // Add One-To-Many: Role -> UserRoles 
            builder.Entity<Role>()
                .HasMany(role => role.UserRoles)
                .WithOne(userRole => userRole.Role)
                .HasForeignKey(userRole => userRole.RoleId);
        }

        private static void RenameTables(ModelBuilder builder)
        {
            builder.Entity<User>()
                .ToTable("Users");

            builder.Entity<Role>()
                .ToTable("Roles");

            builder.Entity<UserRole>()
                .ToTable("UserRoles");

            builder.Entity<IdentityUserClaim<string>>()
                .ToTable("UserClaims");

            builder.Entity<IdentityRoleClaim<string>>()
                .ToTable("RoleClaims");

            builder.Entity<IdentityUserLogin<string>>()
                .ToTable("UserLogins");

            builder.Entity<IdentityUserToken<string>>()
                .ToTable("UserTokens");
        }
    }
}
