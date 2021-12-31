using KixPlay_Backend.Data.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace KixPlay_Backend.Data.Entities
{
    public class Role : IdentityRole<string>, IEntity<string>
    {
        public static readonly IEnumerable<Role> Roles = new List<Role>()
        {
            new Role("Contributor") { Id="36fac547-d582-4a51-92df-5d7d389502cc" },
            new Role("Moderator") { Id="f5cce5f4-900a-41a4-a825-8aa1ad4b3cd2" },
            new Role("Member") { Id="14ee7d07-0182-4770-977c-be214ce3f404" },
            new Role("Admin") { Id="fa109a9e-e5a6-427f-8913-78acaf7ad3be" },
        };

        public Role()
            : base() { }

        public Role(string roleName)
            : base(roleName)
        {
            NormalizedName = roleName.ToUpperInvariant();
        }

        public ICollection<UserRole> UserRoles { get; set; }
    }
}
