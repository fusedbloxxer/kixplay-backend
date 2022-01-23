using AutoMapper;
using KixPlay_Backend.Settings.Application;
using Microsoft.IdentityModel.Tokens;

namespace KixPlay_Backend.Mappers.Settings
{
    public class SettingsProfile : Profile
    {
        public SettingsProfile()
        {
            CreateMap<JwtSettings, TokenValidationParameters>();
        }
    }
}
