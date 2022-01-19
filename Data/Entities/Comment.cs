using KixPlay_Backend.Data.Abstractions;

namespace KixPlay_Backend.Data.Entities
{
    public class Comment : BaseEntity
    {
        public User OriginalPoster { get; set; }

        public string Content { get; set; }

        public Comment Parent { get; set; }
    }
}
