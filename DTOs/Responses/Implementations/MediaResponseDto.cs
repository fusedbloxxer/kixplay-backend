using KixPlay_Backend.DTOs.Responses.Implementations;
using System.ComponentModel.DataAnnotations;

namespace KixPlay_Backend.DTOs.Responses.Abstractions
{
    public class MediaResponseDto : BaseResponse, IMediaResponseDto
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Synopsis { get; set; }

        public string Description { get; set; }

        public string BannerUrl { get; set; }

        public string ThumbnailUrl { get; set; }

        public TimeSpan? Duration { get; set; }

        public DateTime? ReleaseDate { get; set; }

        public string AiringStatus { get; set; }
    }
}
