using KixPlay_Backend.Data.Abstractions;

namespace KixPlay_Backend.Data.Entities
{
    public partial class Medium : BaseEntity
    {
        public string Title { get; set; }

        public string Synopsis { get; set; }

        public string Description { get; set; }

        public string BannerUrl { get; set; }

        public string Thumbnail { get; set; }

        public TimeSpan? Duration { get; set; }

        public DateTime? ReleaseDate { get; set; }

        public Status CurrentStatus { get; set; }

        public ICollection<string> PreviewImageUrls { get; set; }

        public ICollection<string> PreviewVideoUrls { get; set; }

        public ICollection<Genre> Genres { get; set; }

        public ICollection<Source> Sources { get; set; }

        public ICollection<RelatedMedium> RelatedMedias { get; set; }

        public Medium Previous { get; set; }

        public Medium Next { get; set; }
    }

    public partial class Medium : IEntity<Guid>
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
