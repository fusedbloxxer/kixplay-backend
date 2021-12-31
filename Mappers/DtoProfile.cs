using AutoMapper;
using KixPlay_Backend.Data.Entities;
using KixPlay_Backend.DTOs.Requests;

namespace KixPlay_Backend.Mappers
{
    public class DtoProfile : Profile
    {
        public DtoProfile()
        {
            CreateMap<User, UserRegisterRequestDto>();
            CreateMap<UserRegisterRequestDto, User>();

            CreateMap<User, UserLoginRequestDto>();
            CreateMap<UserLoginRequestDto, User>();

            CreateMap<User, UserUpdateRequestDto>();
            CreateMap<UserUpdateRequestDto, User>();
        }
    }
}
