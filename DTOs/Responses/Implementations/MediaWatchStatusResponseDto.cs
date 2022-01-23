using KixPlay_Backend.DTOs.Responses.Abstractions;

namespace KixPlay_Backend.DTOs.Responses.Implementations
{
    public class MediaWatchStatusResponseDto : MediaResponseDto, IMediaWatchStatusResponseDto
    {
        public string WatchingStatus { get; set; }
    }
}
