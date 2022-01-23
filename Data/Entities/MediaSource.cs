using KixPlay_Backend.Data.Abstractions;

namespace KixPlay_Backend.Data.Entities
{
    public class MediaSource : BaseEntity
    {
        public string Url { get; set; }

        public Guid MediaId { get; set; }

        public Media Media { get; set; }

        public Guid ProviderId { get; set; }

        public Provider Provider { get; set; }
    }
}
