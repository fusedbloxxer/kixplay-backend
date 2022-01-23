using KixPlay_Backend.Data.Entities;
using KixPlay_Backend.Models;

namespace KixPlay_Backend.Services.Repositories.Interfaces
{
    public interface IMovieRepository : IMediaRepository<Movie, MovieModel>
    {
    }
}
