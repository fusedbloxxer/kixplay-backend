using AutoMapper;
using KixPlay_Backend.Data.Entities;
using KixPlay_Backend.DTOs;
using KixPlay_Backend.DTOs.Requests;
using KixPlay_Backend.DTOs.Responses;
using KixPlay_Backend.Services.Interfaces;
using KixPlay_Backend.Services.Repositories.Implementations;
using KixPlay_Backend.Services.Repositories.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KixPlay_Backend.Controllers
{
    [Authorize]
    public class UsersController : BaseApiController
    {
        private readonly IMapper _mapper;

        private readonly ITokenService _tokenService;

        private readonly IUserRepository _userRepository;

        public UsersController(
            IMapper mapper,
            ITokenService tokenService,
            IUserRepository userRepository
        )
        {
            _userRepository = userRepository;
            _tokenService = tokenService;
            _mapper = mapper;
        }

        [AllowAnonymous]
        [HttpPost("register")]
        public async Task<ActionResult> CreateUser([FromBody] UserRegisterRequestDto userRegisterDto)
        {
            var createResult = await _userRepository.CreateWithOptions(
                _mapper.Map<UserRegisterRequestDto, User>(userRegisterDto),
                new UserOptions
                {
                    Password = userRegisterDto.Password,
                    Roles = new List<Role> {
                        new Role("Member")
                    }
                }
            );

            if (!createResult.IsSuccessful)
            {
                return BadRequest(new ErrorResponse
                {
                    Errors = createResult.Errors
                });
            }

            var userResult = await _userRepository.GetByUsername(userRegisterDto.UserName);

            if (!userResult.IsSuccessful)
            {
                return NotFound(new ErrorResponse
                {
                    Errors = userResult.Errors
                });
            }

            var token = await _tokenService.CreateToken(userResult.Result);

            return Ok(new UserRegisterResponseDto
            {
                Token = token,
            });
        }
    }
}
