namespace KixPlay_Backend.DTOs.Responses.Abstractions
{
    public class MovieDetailsResponseDto : MediaDetailsResponseDto, IMovieDetailsResponseDto
    {
        public int WonAwards { get; set; }

        public string MetreageType { get; set; }
    }
}
