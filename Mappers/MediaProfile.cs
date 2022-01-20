using AutoMapper;
using KixPlay_Backend.Data.Entities;
using KixPlay_Backend.DTOs.Requests;
using KixPlay_Backend.DTOs.Responses;

namespace KixPlay_Backend.Mappers
{
    public class MediaProfile : Profile
    {
        public MediaProfile()
        {
            CreateMap<MediaCreateRequestDto, Media>()
                .ForMember(
                    media => media.CurrentStatus,
                    config => config.MapFrom(mediaDto => Enum.Parse<Media.Status>(mediaDto.CurrentStatus))
                )
                .IncludeAllDerived();
            CreateMap<MovieCreateRequestDto, Movie>()
                .ForMember(
                    movie => movie.MetreageType,
                    config => config.MapFrom(movieDto => Enum.Parse<Movie.Metreage>(movieDto.MetreageType))
                );

            CreateMap<MediaUpdateRequestDto, Media>()
                .ForMember(
                    media => media.CurrentStatus,
                    config => config.MapFrom(mediaDto => Enum.Parse<Media.Status>(mediaDto.CurrentStatus))
                )
                .IncludeAllDerived();
            CreateMap<MovieUpdateRequestDto, Movie>()
                .ForMember(
                    movie => movie.MetreageType,
                    config => config.MapFrom(movieDto => Enum.Parse<Movie.Metreage>(movieDto.MetreageType))
                );

            CreateMap<Media, MediaResponseDto>()
                .ForMember(
                    mediaDto => mediaDto.CurrentStatus,
                    config => config.MapFrom(media => media.CurrentStatus.ToString())
                )
                .IncludeAllDerived();
            CreateMap<Movie, MovieResponseDto>()
                .ForMember(
                    movieDto => movieDto.MetreageType,
                    config => config.MapFrom(movie => movie.MetreageType.ToString())
                );
        }
    }
}
