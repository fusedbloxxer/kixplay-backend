using KixPlay_Backend.Validators;
using System.ComponentModel.DataAnnotations;

namespace KixPlay_Backend.DTOs
{
    public class UserRegisterDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        [Required]
        [MinimumAge(18)]
        public DateTime DateOfBirth { get; set; }
    }
}
