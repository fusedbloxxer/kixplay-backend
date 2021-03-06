using AutoMapper;
using KixPlay_Backend.Data.Entities;
using KixPlay_Backend.DTOs.Requests;
using KixPlay_Backend.DTOs.Responses;
using KixPlay_Backend.DTOs.Responses.Implementations;

namespace KixPlay_Backend.Mappers.DTOs
{
    public class UserDtoProfile : Profile
    {
        public UserDtoProfile()
        {
            CreateMap<User, UserRegisterRequestDto>();
            CreateMap<UserRegisterRequestDto, User>();

            CreateMap<User, UserLoginRequestDto>();
            CreateMap<UserLoginRequestDto, User>();

            CreateMap<User, UserUpdateResponseDto>();
            CreateMap<User, UserUpdateRequestDto>();
            CreateMap<UserUpdateRequestDto, User>()
                .ForAllMembers(options =>
                {
                    // Do not map null fileds to destination
                    options.Condition((dto, user, field) => field != null);
                });

            CreateMap<UserGetResponseDto, User>();
            CreateMap<User, UserGetResponseDto>();

            CreateMap<Role, RoleGetResponseDto>();
            CreateMap<RoleGetResponseDto, Role>();

            CreateMap<RoleGrantResponseDto, User>();
            CreateMap<User, RoleGrantResponseDto>();
        }
    }
}
