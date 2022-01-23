using KixPlay_Backend.DTOs.Responses.Implementations;

namespace KixPlay_Backend.DTOs.Responses
{
    public class UserRegisterResponseDto : BaseResponse
    {
        public string Token { get; set; }
    }
}
