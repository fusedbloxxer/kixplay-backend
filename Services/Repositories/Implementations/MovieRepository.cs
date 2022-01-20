using AutoMapper;
using KixPlay_Backend.Data;
using KixPlay_Backend.Data.Entities;
using KixPlay_Backend.Services.Repositories.Interfaces;

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
    }
}
