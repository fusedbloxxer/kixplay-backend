using AutoMapper;
using KixPlay_Backend.Data.Entities;
using KixPlay_Backend.DTOs.Requests;
using KixPlay_Backend.DTOs.Responses;
using KixPlay_Backend.Services.Interfaces;
using KixPlay_Backend.Services.Repositories.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KixPlay_Backend.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminsController : BaseApiController
    {
        private readonly IMapper _mapper;

        private readonly ITokenService _tokenService;
        
        private readonly IUserRepository _userRepository;

        public AdminsController(
            IMapper mapper,
            ITokenService tokenService,
            IUserRepository userRepository
        ) {
            _mapper = mapper;
            _tokenService = tokenService;
            _userRepository = userRepository;
        }

        [HttpPost("create")]
        public async Task<ActionResult> Create([FromBody] UserRegisterRequestDto userRegisterDto)
        {
            var createAdminResult = await _userRepository.CreateWithOptions(
                _mapper.Map<User>(userRegisterDto),
                new Services.Repositories.Implementations.UserOptions
                {
                    Password = userRegisterDto.Password,
                    Roles = new List<string>()
                    {
                        "Admin",
                        "Member"
                    },
                }
            );

            if (!createAdminResult.IsSuccessful)
            {
                return BadRequest(new ErrorResponse
                {
                    Errors = createAdminResult.Errors,
                });
            }

            var findAdminResult = await _userRepository.GetByUsernameAsync(userRegisterDto.UserName);

            if (!findAdminResult.IsSuccessful)
            {
                return BadRequest(new ErrorResponse
                {
                    Errors = findAdminResult.Errors,
                });
            }

            var token = await _tokenService.CreateToken(findAdminResult.Result);

            return Ok(new UserRegisterResponseDto
            {
                Token = token,
            });
        }
    }
}
