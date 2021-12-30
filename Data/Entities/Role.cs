using Microsoft.AspNetCore.Identity;

namespace KixPlay_Backend.Data.Entities
{
    public class Role : IdentityRole
    {
        public static readonly IEnumerable<Role> Roles = new List<Role>()
        {
            new Role("Contributor"),
            new Role("Moderator"),
            new Role("Member"),
            new Role("Admin"),
        };
        
        public Role()
            : base() {}

        public Role(string roleName)
            : base(roleName) 
        {
            NormalizedName = roleName.ToUpperInvariant();
        }

        public ICollection<UserRole> UserRoles { get; set; }
    }
}
