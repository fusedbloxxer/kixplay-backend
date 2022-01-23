namespace KixPlay_Backend.DTOs.Responses.Abstractions
{
    public interface IMediaWatchStatusResponseDto : IMediaResponseDto
    {
        public string WatchingStatus { get; set; }
    }
}
