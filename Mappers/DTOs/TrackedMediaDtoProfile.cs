using AutoMapper;
using KixPlay_Backend.Data.Entities;
using KixPlay_Backend.DTOs.Responses.Implementations;

namespace KixPlay_Backend.Mappers.DTOs
{
    public class TrackedMediaDtoProfile : Profile
    {
        public TrackedMediaDtoProfile()
        {
            CreateMap<TrackedMedia, MediaWatchStatusResponseDto>()
                .IncludeMembers(trackedMedia => trackedMedia.Media)
                .ForMember(dto => dto.WatchingStatus, o => o.MapFrom(trackedMedia => trackedMedia.Status.ToString()));
        }
    }
}
