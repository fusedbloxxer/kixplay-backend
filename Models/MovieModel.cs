using static KixPlay_Backend.Data.Entities.Movie;

namespace KixPlay_Backend.Models
{
    public class MovieModel : MediaModel
    {
        public int WonAwards { get; set; }

        public Metreage MetreageType { get; set; }
    }
}
