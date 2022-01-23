using KixPlay_Backend.Data.Entities;
using static KixPlay_Backend.Data.Entities.Media;
using static KixPlay_Backend.Data.Entities.TrackedMedia;

namespace KixPlay_Backend.Models
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

        public WatchStatus WatchingStatus { get; set; }

        public IEnumerable<string> Genres { get; set; }

        public IEnumerable<MediaSourcesModel> Sources { get; set; }
    }
}
