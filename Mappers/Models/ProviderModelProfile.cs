using AutoMapper;
using KixPlay_Backend.Data.Entities;
using KixPlay_Backend.Models.Implementations;

namespace KixPlay_Backend.Mappers.Models
{
    public class ProviderModelProfile : Profile
    {
        public ProviderModelProfile()
        {
            CreateMap<Provider, ProviderModel>();
        }
    }
}
