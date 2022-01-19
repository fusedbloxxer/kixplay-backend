using KixPlay_Backend.Data.Abstractions;

namespace KixPlay_Backend.Data.Entities
{
    public partial class Media : BaseEntity
    {
        public string Title { get; set; }

        public string Synopsis { get; set; }

        public string Description { get; set; }

        public string BannerUrl { get; set; }

        public string ThumbnailUrl { get; set; }

        public TimeSpan? Duration { get; set; }

        public DateTime? ReleaseDate { get; set; }

        public Status CurrentStatus { get; set; }

        public ICollection<string> PreviewImageUrls { get; set; }

        public ICollection<string> PreviewVideoUrls { get; set; }

        public ICollection<MediaInGenre> InGenres { get; set; }

        public ICollection<MediaSource> MediaSources { get; set; }

        public ICollection<RelatedMedia> RelatedTo { get; set; }

        public ICollection<RelatedMedia> RelatedFrom { get; set; }

        public ICollection<TrackedMedia> TrackedMedias { get; set; }

        public ICollection<Review> Reviews { get; set; }

        public Media Previous { get; set; }

        public Media Next { get; set; }
    }

    public partial class Media : IEntity<Guid>
    {
        public enum Status
        {
            Unreleased,
            Abandoned,
            Finished,
            Unknown,
            Airing,
            Soon,
        }
    }
}
