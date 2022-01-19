using KixPlay_Backend.Data.Abstractions;

namespace KixPlay_Backend.Data.Entities
{
    public class Comment : BaseEntity
    {
        public Guid? ParentId { get; set; }

        public ICollection<Comment> Children { get; set; }

        public string Content { get; set; }

        public Guid OriginalPosterId{ get; set; }

        public User OriginalPoster { get; set; }

        public Guid ReviewId { get; set; }

        public Review Review { get; set; }
    }
}
