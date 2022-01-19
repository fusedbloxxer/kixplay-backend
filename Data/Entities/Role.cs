using KixPlay_Backend.Data.Abstractions;
using Microsoft.AspNetCore.Identity;

namespace KixPlay_Backend.Data.Entities
{
    public class Role : IdentityRole<Guid>, IEntity<Guid>
    {
        public Role()
            : base() { }

        public Role(string roleName)
            : base(roleName)
        {
            NormalizedName = roleName.ToUpperInvariant();
        }

        public ICollection<UserRole> UserRoles { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime LastUpdatedAt { get; set; }
    }
}
