using AutoMapper;
using KixPlay_Backend.Data.Entities;
using KixPlay_Backend.DTOs;

namespace KixPlay_Backend.Mappers
{
    public class ApplicationProfile : Profile
    {
        public ApplicationProfile()
        {
            CreateMap<User, UserRegisterDto>();
            CreateMap<UserRegisterDto, User>();

            CreateMap<User, UserLoginDto>();
            CreateMap<UserLoginDto, User>();
        }
    }
}
