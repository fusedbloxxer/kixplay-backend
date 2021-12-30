using AutoMapper;
using KixPlay_Backend.Services.Repositories.Implementations;
using Microsoft.AspNetCore.Identity;

namespace KixPlay_Backend.Mappers
{
    public class ResultProfile : Profile
    {
        public ResultProfile()
        {
            CreateMap<IdentityResult, OperationResult<bool>>()
                .ForCtorParam("result", options => options.MapFrom(
                    identityResult => identityResult.Succeeded
                ))
                .ForCtorParam("errors", options => options.MapFrom(
                    identityResult => identityResult.Errors.Select(
                        error => $"{error.Code}: {error.Description}"
                    )
                ));
        }
    }
}
