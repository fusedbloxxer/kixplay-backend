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
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace KixPlay_Backend.Controllers
{
    [Authorize]
    public class UsersController : BaseApiController
    {
        private readonly IMapper _mapper;

        private readonly ITokenService _tokenService;

        private readonly IUserRepository _userRepository;

        private readonly SignInManager<User> _signInManager;

        public UsersController(
            IMapper mapper,
            ITokenService tokenService,
            IUserRepository userRepository,
            SignInManager<User> signInManager
        )
        {
            _userRepository = userRepository;
            _signInManager = signInManager;
            _tokenService = tokenService;
            _mapper = mapper;
        }

        [AllowAnonymous]
        [HttpPost("register")]
        public async Task<ActionResult> CreateUser([FromBody] UserRegisterRequestDto userRegisterDto)
        {
            var createResult = await _userRepository.CreateWithOptions(
                _mapper.Map<UserRegisterRequestDto, User>(userRegisterDto),
                new Services.Repositories.Implementations.UserOptions
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

        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<ActionResult> LoginUser([FromBody] UserLoginRequestDto userLoginDto)
        {
            var user = await _userRepository.GetByEmail(userLoginDto.Email);

            if (user == null)
            {
                return NotFound($"The user with the email {userLoginDto.Email} does not exist.");
            }

            var signInResult = await _signInManager.CheckPasswordSignInAsync(
                _mapper.Map<User>(userLoginDto),
                userLoginDto.Password,
                false
            );

            if (!signInResult.IsNotAllowed)
            {
                return Unauthorized($"The user with the email {userLoginDto.Email} has not been authorized.");
            }

            if (signInResult.IsLockedOut)
            {
                return Unauthorized($"Access to the user with the email {userLoginDto.Email} is blocked temporarily.");
            }

            if (!signInResult.Succeeded)
            {
                return BadRequest($"Could not sign in the user with the email {userLoginDto.Email}.");
            }

            var token = await _tokenService.CreateToken(user.Result);

            return Ok(new UserLoginResponseDto
            {
                Token = token,
            });
        }
    }
}
