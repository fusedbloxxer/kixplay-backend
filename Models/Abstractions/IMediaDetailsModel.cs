using KixPlay_Backend.Models.Implementations;

namespace KixPlay_Backend.Models.Abstractions
{
    public interface IMediaDetailsModel : IMediaModel
    {
        public IEnumerable<string> Genres { get; set; }

        public IEnumerable<MediaSourcesModel> Providers { get; set; }
    }
}
