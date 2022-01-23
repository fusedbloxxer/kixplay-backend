using AutoMapper;
using KixPlay_Backend.Data.Entities;
using KixPlay_Backend.Models.Implementations;

namespace KixPlay_Backend.Mappers.Models
{
    public class MediaSourceModelProfile : Profile
    {
        public MediaSourceModelProfile()
        {
            CreateMap<MediaSource, MediaSourceModel>();
        }
    }
}
