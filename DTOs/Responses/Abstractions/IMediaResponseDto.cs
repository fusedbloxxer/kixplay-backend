namespace KixPlay_Backend.DTOs.Responses.Abstractions
{
    public interface IMediaResponseDto
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Synopsis { get; set; }

        public string Description { get; set; }

        public string BannerUrl { get; set; }

        public string ThumbnailUrl { get; set; }

        public TimeSpan? Duration { get; set; }

        public DateTime? ReleaseDate { get; set; }

        public ICollection<string> PreviewImageUrls { get; set; }

        public ICollection<string> PreviewVideoUrls { get; set; }

        public string AiringStatus { get; set; }
    }
}
