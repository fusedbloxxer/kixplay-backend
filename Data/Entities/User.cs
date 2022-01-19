using KixPlay_Backend.Data.Abstractions;
using KixPlay_Backend.Validators;
using Microsoft.AspNetCore.Identity;

namespace KixPlay_Backend.Data.Entities
{
    public class User : IdentityUser<Guid>, IEntity<Guid>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public ICollection<UserRole> UserRoles { get; set; }

        public ICollection<Comment> Comments { get; set; }

        public ICollection<Review> Reviews { get; set; }

        public ICollection<ReviewOpinion> ReviewOpinions { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime LastUpdatedAt { get; set; }
    }
}
