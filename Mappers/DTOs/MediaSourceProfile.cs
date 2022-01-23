using AutoMapper;
using KixPlay_Backend.DTOs.Responses.Implementations;
using KixPlay_Backend.Models.Implementations;

namespace KixPlay_Backend.Mappers.DTOs
{
    public class MediaSourceProfile : Profile
    {
        public MediaSourceProfile()
        {
            CreateMap<MediaSourcesModel, MediaSourcesResponseDto>()
                .IncludeMembers(model => model.Provider)
                .ForMember(dto => dto.Sources, options => options.MapFrom(model => model.Sources.Select(source => source.Url)));
        }
    }
}
