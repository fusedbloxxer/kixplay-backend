namespace KixPlay_Backend.DTOs.Responses
{
    public class RoleGrantResponseDto : UserGetResponseDto
    {
        public IEnumerable<RoleGetResponseDto> Roles { get; set; }
    }
}
