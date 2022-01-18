using KixPlay_Backend.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KixPlay_Backend.Data.Configuration
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            // Add Many-To-One: UserRole >- User
            builder
                .HasOne(userRole => userRole.User)
                .WithMany(user => user.UserRoles);

            // Add Many-To-One: UserRole >- Role
            builder
                .HasOne(userRole => userRole.Role)
                .WithMany(role => role.UserRoles);

            // Rename Table
            builder
                .ToTable("UserRoles");
        }
    }
}
