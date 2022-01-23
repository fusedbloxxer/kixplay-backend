using KixPlay_Backend.DTOs.Responses.Abstractions;

namespace KixPlay_Backend.DTOs.Responses.Implementations
{
    public class MovieWatchStatusResponseDto : MovieResponseDto, IMovieWatchStatusResponseDto
    {
        public string WatchingStatus { get; set; }
    }
}
