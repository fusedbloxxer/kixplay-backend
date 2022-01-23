using AutoMapper;
using KixPlay_Backend.Data.Entities;
using KixPlay_Backend.Mappers.Helpers;
using KixPlay_Backend.Models;
using KixPlay_Backend.Models.Implementations;

namespace KixPlay_Backend.Mappers.Models
{
    public class MovieModelProfile : Profile
    {
        public MovieModelProfile()
        {
            CreateMap<Movie, MovieDetailsModel>();

            CreateMap<Movie, MovieWatchStatusModel>();

            CreateMap<MediaWithStatusHelper<Movie>, MovieWatchStatusModel>()
                .IncludeMembers(mediaWithStatus => mediaWithStatus.Media);
        }
    }
}
