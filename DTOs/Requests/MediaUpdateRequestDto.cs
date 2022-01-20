using System.ComponentModel.DataAnnotations;
using static KixPlay_Backend.Data.Entities.Media;

namespace KixPlay_Backend.DTOs.Requests
{
    public class MediaUpdateRequestDto : BaseRequest
    {
        [MaxLength(256)]
        public string Title { get; set; }

        [MaxLength(4096)]
        public string Synopsis { get; set; }

        public string Description { get; set; }

        [Url]
        public string BannerUrl { get; set; }

        [Url]
        public string ThumbnailUrl { get; set; }

        public TimeSpan? Duration { get; set; }

        public DateTime? ReleaseDate { get; set; }

        public string CurrentStatus { get; set; }
    }
}
