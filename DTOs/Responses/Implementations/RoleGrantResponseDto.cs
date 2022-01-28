namespace KixPlay_Backend.DTOs.Responses.Implementations
{
    public class RoleGrantResponseDto : UserGetResponseDto
    {
        public IEnumerable<RoleGetResponseDto> Roles { get; set; }
    }
}
