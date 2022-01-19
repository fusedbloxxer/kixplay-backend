using KixPlay_Backend.Data.Abstractions;

namespace KixPlay_Backend.Data.Entities
{
    public partial class TrackedMedia : BaseEntity
    {
        public Guid UserId { get; set; }

        public User User { get; set; }

        public Guid MediaId { get; set; }

        public Media Media { get; set; }

        public WatchStatus Status { get; set; }
    }

    public partial class TrackedMedia : BaseEntity
    {
        public enum WatchStatus
        {
            OnPause,
            ToWatch,
            Watched,
            Dropped,
            Watching,
        }
    }
}
