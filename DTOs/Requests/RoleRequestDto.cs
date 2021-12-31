namespace KixPlay_Backend.DTOs.Requests
{
    public class RoleRequestDto : BaseRequest
    {
        public IEnumerable<string> Roles { get; set; }
    }
}
