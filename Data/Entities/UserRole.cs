using KixPlay_Backend.Data.Abstractions;
using Microsoft.AspNetCore.Identity;

namespace KixPlay_Backend.Data.Entities
{
    public class UserRole : IdentityUserRole<Guid>, IEntity<Guid>
    {
        public Guid Id { get; set; }

        public User User { get; set; }

        public Role Role { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
