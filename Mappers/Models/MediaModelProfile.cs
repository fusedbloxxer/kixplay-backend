using AutoMapper;
using KixPlay_Backend.Data.Entities;
using KixPlay_Backend.Mappers.Helpers;
using KixPlay_Backend.Models;

namespace KixPlay_Backend.Mappers.Models
{
    public class MediaModelProfile : Profile
    {
        public MediaModelProfile()
        {
            CreateMap<Media, MediaModel>()
                .IncludeAllDerived();

            CreateMap<MediaWithStatusHelper<Media>, MediaModel>()
                .IncludeMembers(mediaWithStatus => mediaWithStatus.Media);
        }
    }
}
