using AutoMapper;
using KixPlay_Backend.Data;
using KixPlay_Backend.Data.Entities;
using KixPlay_Backend.Models;
using KixPlay_Backend.Services.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace KixPlay_Backend.Services.Repositories.Implementations
{
    public class MovieRepository : MediaRepository<Movie, MovieDetailsModel>, IMovieRepository
    {
        public MovieRepository(
            DataContext context,
            ILogger logger,
            IMapper mapper
        ) : base(context, logger, mapper)
        { }
    }
}
