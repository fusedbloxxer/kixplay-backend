using Microsoft.AspNetCore.Identity;

namespace KixPlay_Backend.Data.Entities
{
    public class UserRole : IdentityUserRole<string>
    {
        public User User { get; set; }

        public Role Role { get; set; }
    }
}
