namespace KixPlay_Backend.DTOs.Responses
{
    public class MediaResponseDto : BaseResponse
    {
        public string Title { get; set; }

        public string Synopsis { get; set; }

        public string Description { get; set; }

        public string BannerUrl { get; set; }

        public string ThumbnailUrl { get; set; }

        public TimeSpan? Duration { get; set; }

        public DateTime? ReleaseDate { get; set; }

        public string CurrentStatus { get; set; }
    }
}
