using KixPlay_Backend.Data.Abstractions;

namespace KixPlay_Backend.Data.Entities
{
    public partial class Provider : BaseEntity
    {
        public string Url { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string ThumbnailUrl { get; set; }

        public Reliability? Reliable { get; set; }
        
        public ICollection<MediaSource> MediaSources { get; set; }
    }

    public partial class Provider : BaseEntity
    {
        public enum Reliability
        {
            Trustworthy,
            Unreliable,
            Unknown,
            Sussy
        }
    }
}
