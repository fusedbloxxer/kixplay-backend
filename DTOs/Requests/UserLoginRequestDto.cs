using System.ComponentModel.DataAnnotations;

namespace KixPlay_Backend.DTOs.Requests
{
    public class UserLoginRequestDto : BaseRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[0-9])(?=.*[A-Z])(?=.*[^\w\s]).*$")]
        public string Password { get; set; }
    }
}
