using AutoMapper;
using KixPlay_Backend.Data.Entities;
using KixPlay_Backend.DTOs.Requests;
using KixPlay_Backend.DTOs.Responses.Abstractions;
using KixPlay_Backend.DTOs.Responses.Implementations;
using KixPlay_Backend.Models;
using KixPlay_Backend.Models.Implementations;

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
                    mediaDto => mediaDto.AiringStatus,
                    config => config.MapFrom(media => media.AiringStatus.ToString())
                )
                .IncludeAllDerived();

            CreateMap<Media, MediaWatchStatusResponseDto>();

            CreateMap<MediaDetailsModel, MediaDetailsResponseDto>();

            CreateMap<MediaWatchStatusModel, MediaWatchStatusResponseDto>();
        }
    }
}
