using static KixPlay_Backend.Data.Entities.Media;

namespace KixPlay_Backend.Models.Implementations
{
    public class MediaModel : BaseModel
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Synopsis { get; set; }

        public string Description { get; set; }

        public string BannerUrl { get; set; }

        public string ThumbnailUrl { get; set; }

        public TimeSpan? Duration { get; set; }

        public DateTime? ReleaseDate { get; set; }

        public AirStatus AiringStatus { get; set; }
    }
}
