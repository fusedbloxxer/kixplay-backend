using KixPlay_Backend.Models.Abstractions;
using KixPlay_Backend.Models.Implementations;

namespace KixPlay_Backend.Models
{
    public class MovieDetailsModel : MovieModel, IMovieDetailsModel
    {
        public IEnumerable<string> Genres { get; set; }

        public IEnumerable<MediaSourcesModel> Providers { get; set; }
    }
}
