using KixPlay_Backend.DTOs.Responses.Implementations;

namespace KixPlay_Backend.DTOs.Responses
{
    public class RoleGetResponseDto : BaseResponse
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}
