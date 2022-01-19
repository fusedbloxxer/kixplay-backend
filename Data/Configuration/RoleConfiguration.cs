using KixPlay_Backend.Data.Abstractions;
using KixPlay_Backend.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KixPlay_Backend.Data.Configuration
{
    public class RoleConfiguration : BaseEntityConfiguration<Guid, Role>
    {
        protected override void ConfigureTable(EntityTypeBuilder<Role> builder)
        {
            builder
                .ToTable("Roles");
        }

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
        protected override void ConfigureSeed(EntityTypeBuilder<Role> builder)
        {
            builder.HasData(new List<Role>()
            {
                new Role("Contributor")
                {
                    Id = Guid.Parse("8e7640e4-8701-46e5-85b9-596e03db2944")
                },
                new Role("Moderator")
                {
                    Id = Guid.Parse("e98fc490-4589-4beb-a316-add18c8f3ddf")
                },
                new Role("Member")
                {
                    Id = Guid.Parse("92215649-862e-4c2f-a4c6-1c61cb245ad5")
                },
                new Role("Admin")
                {
                    Id = Guid.Parse("8c6d9a31-3e47-45b5-b940-9225fa539f15")
                },
            });
        }
    }
}
