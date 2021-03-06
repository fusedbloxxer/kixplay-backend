using KixPlay_Backend.DTOs.Responses.Implementations;

namespace KixPlay_Backend.DTOs.Responses.Abstractions
{
    public class MediaDetailsResponseDto : MediaResponseDto, IMediaDetailsResponseDto
    {
        public IEnumerable<string> Genres { get; set; }

        public IEnumerable<MediaSourcesResponseDto> Providers { get; set; }
    }
}
