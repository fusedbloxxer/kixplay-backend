using KixPlay_Backend.Data.Entities;
using KixPlay_Backend.Models.Abstractions;

namespace KixPlay_Backend.Models.Implementations
{
    public class MediaDetailsModel : MediaModel, IMediaDetailsModel
    {
        public IEnumerable<string> Genres { get; set; }

        public IEnumerable<MediaSourcesModel> Providers { get; set; }
    }
}
