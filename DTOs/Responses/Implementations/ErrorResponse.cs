namespace KixPlay_Backend.DTOs.Responses.Implementations
{
    public class ErrorResponse : BaseResponse
    {
        public IEnumerable<string> Errors { get; set; }

        public ErrorResponse() { }

        public ErrorResponse(string singleErrorMessage)
        {
            Errors = new List<string>() { singleErrorMessage };
        }
    }
}
