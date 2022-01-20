using AutoMapper;
using KixPlay_Backend.Data;
using KixPlay_Backend.Data.Entities;
using KixPlay_Backend.Services.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace KixPlay_Backend.Services.Repositories.Implementations
{
    public class MovieRepository : GenericRepository<Guid, Movie, DataContext>, IMovieRepository
    {
        public MovieRepository(
            DataContext context,
            ILogger logger,
            IMapper mapper
        ) : base(context, logger, mapper)
        { }

        public async Task<IEnumerable<object>> GetMoviesWithGenresAsync()
        {
            return await _dbSet
               .Join(
                   _context.MediaInGenres,
                   movie => movie.Id,
                   mediaInGenre => mediaInGenre.MediaId,
                   (movie, movieInGenre) => new
                   {
                       movie = movie,
                       genreId = movieInGenre.GenreId,
                   }
               )
               .Join(
                    _context.Genres,
                    o => o.genreId,
                    genre => genre.Id,
                    (o, genre) => new
                    {
                        Movie = o.movie,
                        Genre = genre,
                    }
               )
               .ToListAsync();
        }
    }
}
