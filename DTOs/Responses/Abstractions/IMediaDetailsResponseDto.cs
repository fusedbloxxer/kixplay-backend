using KixPlay_Backend.DTOs.Responses.Implementations;

namespace KixPlay_Backend.DTOs.Responses.Abstractions
{
    public interface IMediaDetailsResponseDto : IMediaResponseDto
    {
        public string WatchingStatus { get; set; }

        public IEnumerable<string> Genres { get; set; }

        public IEnumerable<MediaSourcesResponseDto> Providers { get; set; }
    }
}
