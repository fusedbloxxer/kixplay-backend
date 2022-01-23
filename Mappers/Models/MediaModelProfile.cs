using AutoMapper;
using KixPlay_Backend.Data.Entities;
using KixPlay_Backend.Mappers.Helpers;
using KixPlay_Backend.Models.Implementations;

namespace KixPlay_Backend.Mappers.Models
{
    public class MediaModelProfile : Profile
    {
        public MediaModelProfile()
        {
            CreateMap<Media, MediaDetailsModel>()
                .IncludeAllDerived();

            CreateMap<Media, MediaWatchStatusModel>();

            CreateMap<MediaWithStatusHelper<Media>, MediaWatchStatusModel>()
                .IncludeMembers(mediaWithStatus => mediaWithStatus.Media);
        }
    }
}
