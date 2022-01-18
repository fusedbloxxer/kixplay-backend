using KixPlay_Backend.Data.Abstractions;
using Microsoft.AspNetCore.Identity;

namespace KixPlay_Backend.Data.Entities
{
    public class Role : IdentityRole<Guid>, IEntity<Guid>
    {
        public static readonly IEnumerable<Role> Roles = new List<Role>()
        {
            new Role("Contributor") { Id=Guid.NewGuid() },
            new Role("Moderator") { Id=Guid.NewGuid() },
            new Role("Member") { Id=Guid.NewGuid() },
            new Role("Admin") { Id=Guid.NewGuid() },
        };

        public Role()
            : base() { }

        public Role(string roleName)
            : base(roleName)
        {
            NormalizedName = roleName.ToUpperInvariant();
        }

        public ICollection<UserRole> UserRoles { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
