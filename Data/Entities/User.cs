using KixPlay_Backend.Data.Interfaces;
using KixPlay_Backend.Validators;
using Microsoft.AspNetCore.Identity;

namespace KixPlay_Backend.Data.Entities
{
    public class User : IdentityUser<string>, IEntity<string>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        [DateIsPresentOrPast]
        public DateTime? LastSeen { get; set; }

        [MinimumAge(18)]
        public DateTime? DateOfBirth { get; set; }

        public ICollection<UserRole> UserRoles { get; set; }
    }
}
