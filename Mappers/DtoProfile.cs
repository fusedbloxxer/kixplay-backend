using AutoMapper;
using KixPlay_Backend.Data.Entities;
using KixPlay_Backend.DTOs.Requests;
using KixPlay_Backend.DTOs.Responses;

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
            CreateMap<UserUpdateRequestDto, User>()
                .ForAllMembers(options =>
                {
                    // Do not map null fileds to destination
                    options.Condition((dto, user, field) => field != null);
                });

            CreateMap<UserGetResponseDto, User>();
            CreateMap<User, UserGetResponseDto>();
        }
    }
}
