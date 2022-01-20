using KixPlay_Backend.Data.Entities;

namespace KixPlay_Backend.Services.Repositories.Interfaces
{
    public interface IMovieRepository : IMediaRepository<Movie>
    {
        Task<IEnumerable<object>> GetMoviesWithGenresAsync();
    }
}
