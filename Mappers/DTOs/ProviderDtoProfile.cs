using AutoMapper;
using KixPlay_Backend.DTOs.Responses.Abstractions;
using KixPlay_Backend.DTOs.Responses.Implementations;
using KixPlay_Backend.Models.Implementations;

namespace KixPlay_Backend.Mappers.DTOs
{
    public class ProviderDtoProfile : Profile
    {
        public ProviderDtoProfile()
        {
            CreateMap<ProviderModel, ProviderResponseDto>()
                .IncludeAllDerived();

            CreateMap<ProviderModel, MediaSourcesResponseDto>();
        }
    }
}
