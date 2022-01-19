using KixPlay_Backend.Data.Abstractions;
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

            // Seed the table
            builder
                .HasData(new List<UserRole>()
                {
                    new UserRole()
                    {
                        UserId = Guid.Parse("71a7ed13-227f-4a94-aa9a-c0813c60f602"),
                        RoleId = Guid.Parse("92215649-862e-4c2f-a4c6-1c61cb245ad5"),
                    },
                    new UserRole()
                    {
                        UserId = Guid.Parse("71a7ed13-227f-4a94-aa9a-c0813c60f602"),
                        RoleId = Guid.Parse("e98fc490-4589-4beb-a316-add18c8f3ddf"),
                    },
                    new UserRole()
                    {
                        UserId = Guid.Parse("3ca625e3-0648-4d1b-a456-c1c6ee0e0da8"),
                        RoleId = Guid.Parse("92215649-862e-4c2f-a4c6-1c61cb245ad5"),
                    },
                    new UserRole()
                    {
                        UserId = Guid.Parse("fc4ce336-fac9-49dc-88f6-f60ff4231985"),
                        RoleId = Guid.Parse("92215649-862e-4c2f-a4c6-1c61cb245ad5"),
                    },
                    new UserRole()
                    {
                        UserId = Guid.Parse("9b0795d2-46f0-493f-b37a-f80cc4700976"),
                        RoleId = Guid.Parse("92215649-862e-4c2f-a4c6-1c61cb245ad5"),
                    },
                    new UserRole()
                    {
                        UserId = Guid.Parse("9b0795d2-46f0-493f-b37a-f80cc4700976"),
                        RoleId = Guid.Parse("8e7640e4-8701-46e5-85b9-596e03db2944"),
                    },
                    new UserRole()
                    {
                        UserId = Guid.Parse("a6a707c8-9d67-4b36-8036-86e085670b36"),
                        RoleId = Guid.Parse("92215649-862e-4c2f-a4c6-1c61cb245ad5"),
                    },
                    new UserRole()
                    {
                        UserId = Guid.Parse("a6a707c8-9d67-4b36-8036-86e085670b36"),
                        RoleId = Guid.Parse("8c6d9a31-3e47-45b5-b940-9225fa539f15"),
                    },
                });
        }
    }
}
