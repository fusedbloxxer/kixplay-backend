using KixPlay_Backend.Data.Abstractions;

namespace KixPlay_Backend.Data.Entities
{
    public class Review : BaseEntity
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public float Rating { get; set; }

        public bool HasSpoilers { get; set; }

        public bool Recommended { get; set; }
    }
}
