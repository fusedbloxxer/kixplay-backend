using AutoMapper;
using KixPlay_Backend.Data.Entities;
using KixPlay_Backend.DTOs.Requests;
using KixPlay_Backend.DTOs.Responses;

namespace KixPlay_Backend.Mappers.DTOs
{
    public class MovieDtoProfile : Profile
    {
        public MovieDtoProfile()
        {
            CreateMap<MovieCreateRequestDto, Movie>()
                .ForMember(
                    movie => movie.MetreageType,
                    config => config.MapFrom(movieDto => Enum.Parse<Movie.Metreage>(movieDto.MetreageType))
                );

            CreateMap<MovieUpdateRequestDto, Movie>()
                .ForMember(
                    movie => movie.MetreageType,
                    config => config.MapFrom(movieDto => Enum.Parse<Movie.Metreage>(movieDto.MetreageType))
                );

            CreateMap<Movie, MovieResponseDto>()
                .ForMember(
                    movieDto => movieDto.MetreageType,
                    config => config.MapFrom(movie => movie.MetreageType.ToString())
                );
        }
    }
}
