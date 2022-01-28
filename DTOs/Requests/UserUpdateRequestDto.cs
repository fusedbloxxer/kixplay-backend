using KixPlay_Backend.Validators;
using System.ComponentModel.DataAnnotations;

namespace KixPlay_Backend.DTOs.Requests
{
    public class UserUpdateRequestDto : BaseRequest
    {
        [EmailAddress]
        public string Email { get; set; }

        [RegularExpression(@"^[a-zA-Z0-9\-]{3,}$")]
        public string UserName { get; set; }

        [RegularExpression(@"^(?=.*[a-z])(?=.*[0-9])(?=.*[A-Z])(?=.*[^\w\s]).*$")]
        public string Password { get; set; }

        [RegularExpression(@"^[A-Z][a-z\-]*$")]
        public string FirstName { get; set; }

        [RegularExpression(@"^[A-Z][a-z\-]*$")]
        public string LastName { get; set; }

        [MinimumAge(18)]
        public DateTime? DateOfBirth { get; set; }
    }
}
