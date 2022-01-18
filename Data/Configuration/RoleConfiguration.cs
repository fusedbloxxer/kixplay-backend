using KixPlay_Backend.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KixPlay_Backend.Data.Configuration
{
    public class RoleConfiguration : BaseEntityConfiguration<Guid, Role>
    {
        protected override void ConfigureProperties(EntityTypeBuilder<Role> builder)
        {
        }

        protected override void ConfigureRelations(EntityTypeBuilder<Role> builder)
        {
            // Add One-To-Many: Role -> UserRole
            builder
                .HasMany(role => role.UserRoles)
                .WithOne(userRole => userRole.Role)
                .HasForeignKey(userRole => userRole.RoleId)
                .IsRequired();
        }

        protected override void ConfigureTable(EntityTypeBuilder<Role> builder)
        {
            builder
                .ToTable("Roles");
        }
    }
}
