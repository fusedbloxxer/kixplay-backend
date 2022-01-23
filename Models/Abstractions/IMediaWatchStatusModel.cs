using static KixPlay_Backend.Data.Entities.TrackedMedia;

namespace KixPlay_Backend.Models.Abstractions
{
    public interface IMediaWatchStatusModel : IMediaModel
    {
        public WatchStatus WatchingStatus { get; set; }
    }
}
