using AutoMapper;
using KixPlay_Backend.Data.Entities;
using KixPlay_Backend.DTOs.Requests;
using KixPlay_Backend.DTOs.Responses;
using KixPlay_Backend.Models;

namespace KixPlay_Backend.Mappers.DTOs
{
    public class MediaDtoProfile : Profile
    {
        public MediaDtoProfile()
        {
            CreateMap<MediaCreateRequestDto, Media>()
                .ForMember(
                    media => media.AiringStatus,
                    config => config.MapFrom(mediaDto => Enum.Parse<Media.AirStatus>(mediaDto.CurrentStatus))
                )
                .IncludeAllDerived();

            CreateMap<MediaUpdateRequestDto, Media>()
                .ForMember(
                    media => media.AiringStatus,
                    config => config.MapFrom(mediaDto => Enum.Parse<Media.AirStatus>(mediaDto.CurrentStatus))
                )
                .IncludeAllDerived();

            CreateMap<Media, MediaResponseDto>()
                .ForMember(
                    mediaDto => mediaDto.CurrentStatus,
                    config => config.MapFrom(media => media.AiringStatus.ToString())
                )
                .IncludeAllDerived();
        }
    }
}
