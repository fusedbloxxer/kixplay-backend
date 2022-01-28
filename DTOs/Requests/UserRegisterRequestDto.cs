using KixPlay_Backend.Validators;
using System.ComponentModel.DataAnnotations;

namespace KixPlay_Backend.DTOs.Requests
{
    public class UserRegisterRequestDto : BaseRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z0-9\-]{3,}$")]
        public string UserName { get; set; }

        [Required]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[0-9])(?=.*[A-Z])(?=.*[^\w\s]).*$")]
        public string Password { get; set; }

        [RegularExpression(@"^[A-Z][a-z\-]*$")]
        public string FirstName { get; set; }

        [RegularExpression(@"^[A-Z][a-z\-]*$")]
        public string LastName { get; set; }

        [Required]
        [MinimumAge(18)]
        public DateTime? DateOfBirth { get; set; }
    }
}
