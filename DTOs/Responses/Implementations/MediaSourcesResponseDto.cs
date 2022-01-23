using KixPlay_Backend.DTOs.Responses.Abstractions;

namespace KixPlay_Backend.DTOs.Responses.Implementations
{
    public class MediaSourcesResponseDto : ProviderResponseDto
    {
        public IEnumerable<string> Sources { get; set; }
    }
}
