namespace KixPlay_Backend.DTOs.Responses
{
    public class MovieResponseDto : MediaResponseDto
    {
        public int WonAwards { get; set; }

        public string MetreageType { get; set; }
    }
}
