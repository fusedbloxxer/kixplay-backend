using Microsoft.AspNetCore.Identity;

namespace KixPlay_Backend.Data.Entities
{
    public class Role : IdentityRole
    {
        public ICollection<UserRole> UserRoles { get; set; }
    }
}
