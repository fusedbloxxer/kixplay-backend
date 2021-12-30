namespace KixPlay_Backend.DTOs.Responses
{
    public class ErrorResponse : BaseResponse
    {
        public IEnumerable<string> Errors { get; set; }
    }
}
