namespace KixPlay_Backend.DTOs.Responses.Abstractions
{
    public interface IMovieResponseDto : IMediaResponseDto
    {
        public int WonAwards { get; set; }

        public string MetreageType { get; set; }
    }
}
