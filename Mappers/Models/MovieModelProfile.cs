using AutoMapper;
using KixPlay_Backend.Data.Entities;
using KixPlay_Backend.Mappers.Helpers;
using KixPlay_Backend.Models;

namespace KixPlay_Backend.Mappers.Models
{
    public class MovieModelProfile : Profile
    {
        public MovieModelProfile()
        {
            CreateMap<Movie, MovieModel>();

            CreateMap<MediaWithStatusHelper<Movie>, MovieModel>()
                .IncludeMembers(mediaWithStatus => mediaWithStatus.Media);
        }
    }
}
