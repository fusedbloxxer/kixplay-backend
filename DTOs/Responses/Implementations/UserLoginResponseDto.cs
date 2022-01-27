using KixPlay_Backend.DTOs.Responses.Implementations;

namespace KixPlay_Backend.DTOs.Responses
{
    public class UserLoginResponseDto : UserGetResponseDto
    {
        public string Token { get; set; }
    }
}
