using static KixPlay_Backend.Data.Entities.Movie;

namespace KixPlay_Backend.Models.Abstractions
{
    public interface IMovieModel : IMediaModel
    {
        public int WonAwards { get; set; }

        public Metreage MetreageType { get; set; }
    }
}
