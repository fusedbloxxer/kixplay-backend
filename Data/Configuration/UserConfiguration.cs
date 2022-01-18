using KixPlay_Backend.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KixPlay_Backend.Data.Configuration
{
    public class UserConfiguration : BaseEntityConfiguration<Guid, User>
    {
        protected override void ConfigureProperties(EntityTypeBuilder<User> builder)
        {
            builder
                .Property(user => user.LastUpdated)
                .ValueGeneratedOnAddOrUpdate();
        }

        protected override void ConfigureRelations(EntityTypeBuilder<User> builder)
        {
            // Add One-To-Many: User -> UserRole
            builder
                .HasMany(user => user.UserRoles)
                .WithOne(userRole => userRole.User)
                .HasForeignKey(userRole => userRole.UserId)
                .IsRequired();
        }

        protected override void ConfigureTable(EntityTypeBuilder<User> builder)
        {
            builder
                .ToTable("Users");
        }
    }
}
