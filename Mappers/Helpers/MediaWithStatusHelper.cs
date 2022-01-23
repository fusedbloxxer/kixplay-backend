using KixPlay_Backend.Data.Entities;
using static KixPlay_Backend.Data.Entities.TrackedMedia;

namespace KixPlay_Backend.Mappers.Helpers
{
    public class MediaWithStatusHelper<TMedia>
        where TMedia : Media
    {
        public TMedia Media { get; set; }

        public WatchStatus WatchingStatus { get; set; }
    }
}
