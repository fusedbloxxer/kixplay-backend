using KixPlay_Backend.DTOs.Responses.Implementations;

namespace KixPlay_Backend.DTOs.Responses.Abstractions
{
    public class ProviderResponseDto : BaseResponse
    {
        public Guid Id { get; set; }

        public string Url { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string ThumbnailUrl { get; set; }

        public string Reliable { get; set; }
    }
}
