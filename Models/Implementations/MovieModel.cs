using KixPlay_Backend.Data.Entities;
using KixPlay_Backend.Models.Abstractions;

namespace KixPlay_Backend.Models.Implementations
{
    public class MovieModel : MediaModel, IMovieModel
    {
        public int WonAwards { get; set; }

        public Movie.Metreage MetreageType { get; set; }
    }
}
