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
    [Authorize(Roles = "Admin,Member,Contributor,Moderator")]
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

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<ActionResult> GetAllUsers()
        {
            var usersResult = await _userRepository.GetAllAsync();

            if (!usersResult.IsSuccessful)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new ErrorResponse
                {
                    Errors = usersResult.Errors,
                });
            }

            var usersDto = _mapper.ProjectTo<UserGetResponseDto>(usersResult.Result.AsQueryable());

            return Ok(usersDto);
        }

        [AllowAnonymous]
        [HttpGet("{userId}")]
        public async Task<ActionResult> GetUserById([FromRoute] Guid userId)
        {
            var userResult = await _userRepository.GetByIdAsync(userId);

            if (!userResult.IsSuccessful)
            {
                return BadRequest(new ErrorResponse
                {
                    Errors = userResult.Errors
                });
            }

            return Ok(_mapper.Map<UserGetResponseDto>(userResult.Result));
        }

        [AllowAnonymous]
        [HttpGet("findBy")]
        public async Task<ActionResult> GetUser([FromQuery] Guid userId, [FromQuery] string email, [FromQuery] string userName)
        {
            int countParams = 0;

            foreach (var param in new List<string> { email, userName })
            {
                if (!string.IsNullOrWhiteSpace(param))
                {
                    ++countParams;
                }
            }

            if (userId != Guid.Empty)
            {
                ++countParams;
            }

            if (countParams > 1)
            {
                return BadRequest(new ErrorResponse("You can search a user only by either userId, email or username."));
            }

            var usersResult = await _userRepository.GetAllAsync();

            if (!usersResult.IsSuccessful)
            {
                return BadRequest(new ErrorResponse
                {
                    Errors = usersResult.Errors,
                });
            }

            var user = usersResult.Result.FirstOrDefault(user =>
            {
                bool isMatch = false;

                isMatch |= !string.IsNullOrWhiteSpace(userName)
                    && user.NormalizedUserName.Equals(userName.ToUpperInvariant());

                isMatch |= !string.IsNullOrWhiteSpace(email)
                    && user.NormalizedEmail.Equals(email.ToUpperInvariant());

                isMatch |= userId != Guid.Empty
                    && user.Id.Equals(userId);

                return isMatch;
            });

            if (user == null)
            {
                return NotFound(new ErrorResponse("No user was found with the provided information."));
            }

            return Ok(_mapper.Map<UserGetResponseDto>(user));
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
                    Roles = new List<string> {
                        "Member",
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

            var userResult = await _userRepository.GetByUsernameAsync(userRegisterDto.UserName);

            if (!userResult.IsSuccessful)
            {
                return NotFound(new ErrorResponse
                {
                    Errors = userResult.Errors
                });
            }

            var token = await _tokenService.CreateToken(userResult.Result);

            return StatusCode(StatusCodes.Status201Created, new UserRegisterResponseDto
            {
                Token = token,
            });
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<ActionResult> LoginUser([FromBody] UserLoginRequestDto userLoginDto)
        {
            var user = await _userRepository.GetByEmailAsync(userLoginDto.Email);

            if (!user.IsSuccessful)
            {
                return NotFound(new ErrorResponse($"The user with the email {userLoginDto.Email} does not exist."));
            }

            var signInResult = await _userRepository.IsUserLoginValid(
                user.Result,
                userLoginDto.Password
            );

            if (!signInResult.IsSuccessful)
            {
                return BadRequest(new ErrorResponse
                {
                    Errors = signInResult.Errors
                });
            }

            var token = await _tokenService.CreateToken(user.Result);

            return Ok(new UserLoginResponseDto
            {
                Token = token,
            });
        }

        [Authorize(Policy = "IsSameUser")]
        [HttpDelete("{userId}/remove")]
        public async Task<ActionResult> DeleteUser([FromRoute] Guid userId)
        {
            if (userId == Guid.Empty)
            {
                return BadRequest(new ErrorResponse("The user id route param must have a proper value."));
            }

            var user = await _userRepository.GetByIdAsync(userId);

            if (!user.IsSuccessful)
            {
                return NotFound(new ErrorResponse($"The user with the id {userId} does not exist."));
            }

            var deleteResult = await _userRepository.DeleteAsync(userId);

            if (!deleteResult.IsSuccessful)
            {
                return BadRequest(new ErrorResponse
                {
                    Errors = deleteResult.Errors,
                });
            }

            return Ok();
        }

        [Authorize(Policy = "IsSameUser")]
        [HttpPut("{userId}/update")]
        public async Task<ActionResult> UpdateUser([FromRoute] Guid userId, [FromBody] UserUpdateRequestDto userUpdateDto)
        {
            if (userId == Guid.Empty)
                return BadRequest(new ErrorResponse("The user id route param must have a proper value."));

            var userResult = await _userRepository.GetByIdAsync(userId);
            var user = userResult.Result;

            if (!userResult.IsSuccessful)
            {
                return NotFound(new ErrorResponse($"The user with the id {userId} does not exist."));
            }

            var updatedUser = _mapper.Map(userUpdateDto, user);

            var updateResult = await _userRepository.UpdateAsync(updatedUser);

            if (!updateResult.IsSuccessful)
            {
                return BadRequest(new ErrorResponse()
                {
                    Errors = updateResult.Errors
                });
            }

            return NoContent();
        }
    }
}
