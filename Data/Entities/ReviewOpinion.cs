using KixPlay_Backend.Data.Abstractions;

namespace KixPlay_Backend.Data.Entities
{
    public class ReviewOpinion : BaseEntity
    {
        public Guid UserId { get; set; }

        public User User { get; set; }

        public Guid ReviewId { get; set; }

        public Review Review { get; set; }

        public bool IsFunny { get; set; }

        public bool IsHelpful { get; set; }

        public bool IsInteresting { get; set; }
    }
}
