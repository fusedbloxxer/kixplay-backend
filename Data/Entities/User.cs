using Microsoft.AspNetCore.Identity;

namespace KixPlay_Backend.Data.Entities
{
    public class User : IdentityUser
    {
        public ICollection<UserRole> UserRoles { get; set; }
    }
}
