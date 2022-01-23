namespace KixPlay_Backend.DTOs.Responses.Abstractions
{
    public class RoleGrantResponseDto : UserGetResponseDto
    {
        public IEnumerable<RoleGetResponseDto> Roles { get; set; }
    }
}
