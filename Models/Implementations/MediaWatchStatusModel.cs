using KixPlay_Backend.Models.Abstractions;
using static KixPlay_Backend.Data.Entities.TrackedMedia;

namespace KixPlay_Backend.Models.Implementations
{
    public class MediaWatchStatusModel : MediaModel, IMediaWatchStatusModel
    {
        public WatchStatus WatchingStatus { get; set; }
    }
}
