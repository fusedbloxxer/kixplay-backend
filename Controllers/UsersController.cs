using AutoMapper;
using KixPlay_Backend.Data.Entities;
using KixPlay_Backend.DTOs.Requests;
using KixPlay_Backend.DTOs.Responses;
using KixPlay_Backend.DTOs.Responses.Implementations;
using KixPlay_Backend.Services.Interfaces;
using KixPlay_Backend.Services.Repositories.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace KixPlay_Backend.Controllers
{
    [Authorize(Roles = "Admin,Member,Contributor,Moderator")]
    public class UsersController : BaseApiController
    {
        private readonly IMapper _mapper;

        private readonly ITokenService _tokenService;

        private readonly IUnitOfWork _unitOfWork;
        
        private readonly ILogger<UsersController> _logger;

        public UsersController(
            IMapper mapper,
            IUnitOfWork unitOfWork,
            ITokenService tokenService,
            ILogger<UsersController> logger
        )
        {
            _tokenService = tokenService;
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<ActionResult> GetAllUsers()
        {
            try
            {
                var users = await _unitOfWork.UserRepository.GetAllAsync();

                var usersDto = _mapper.ProjectTo<UserGetResponseDto>(users.AsQueryable());

                return Ok(usersDto);
            }
            catch (Exception ex)
            {
                _logger.LogError("Could not retrieve users. Exception: {Error}", ex);
                return StatusCode((int)HttpStatusCode.InternalServerError, new ErrorResponse("An internal error has occurred."));
            }
        }

        [AllowAnonymous]
        [HttpGet("{userId}")]
        public async Task<ActionResult> GetUserById([FromRoute] Guid userId)
        {
            try
            {
                var user = await _unitOfWork.UserRepository.GetByIdAsync(userId);

                if (user == null)
                {
                    return NotFound(new ErrorResponse($"User {userId} not found."));
                }

                return Ok(_mapper.Map<UserGetResponseDto>(user));
            }
            catch (Exception ex)
            {
                _logger.LogError("Could not find user {userId}. Exception: {Error}", userId, ex);
                return StatusCode((int)HttpStatusCode.InternalServerError, new ErrorResponse("An internal error has occurred."));
            }
        }

        [AllowAnonymous]
        [HttpGet("findBy")]
        public async Task<ActionResult> GetUser([FromQuery] Guid userId, [FromQuery] string email, [FromQuery] string userName)
        {
            try
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

                var users = await _unitOfWork.UserRepository.GetAllAsync();

                var user = users.FirstOrDefault(user =>
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
            catch (Exception ex)
            {
                _logger.LogError("Could not find user. Id: {UserId}, Email: {Email}, Username: {Username}. Exception: {Error}", userId, email, userName, ex);
                return StatusCode((int)HttpStatusCode.InternalServerError, new ErrorResponse("An internal error has occurred."));
            }

        }

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(UserRegisterResponseDto))]
        [AllowAnonymous]
        [HttpPost("register")]
        public async Task<ActionResult> CreateUser([FromBody] UserRegisterRequestDto userRegisterDto)
        {
            try
            {
                var createResult = await _unitOfWork.UserRepository.CreateWithOptionsAsync(
                    _mapper.Map<UserRegisterRequestDto, User>(userRegisterDto),
                    new Services.Repositories.Implementations.UserOptions
                    {
                        Password = userRegisterDto.Password,
                        Roles = new List<string> {
                            "Member",
                        }
                    }
                );

                if (!createResult)
                {
                    return BadRequest(new ErrorResponse("Invalid username or email."));
                }

                var user = await _unitOfWork.UserRepository.GetByUsernameAsync(userRegisterDto.UserName);

                if (user == null)
                {
                    return StatusCode((int)HttpStatusCode.InternalServerError, new ErrorResponse("Could not find recently created user."));
                }

                var token = await _tokenService.CreateToken(user);

                await _unitOfWork.CompleteAsync();

                var responseDto = _mapper.Map(user, new UserRegisterResponseDto()
                {
                    Token = token,
                });

                return StatusCode(StatusCodes.Status201Created, responseDto);
            }
            catch (Exception ex)
            {
                _logger.LogError("Could not register user with options {Options}. Exception: {Error}", userRegisterDto, ex);
                return StatusCode((int)HttpStatusCode.InternalServerError, new ErrorResponse("An internal error has occurred."));
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(UserLoginResponseDto))]
        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<ActionResult> LoginUser([FromBody] UserLoginRequestDto userLoginDto)
        {
            try
            {
                var user = await _unitOfWork.UserRepository.GetByEmailAsync(userLoginDto.Email);

                if (user == null)
                {
                    return NotFound(new ErrorResponse($"The user with the email {userLoginDto.Email} does not exist."));
                }

                var signInResult = await _unitOfWork.UserRepository.CanUserLoginAsync(
                    user,
                    userLoginDto.Password
                );

                if (!signInResult)
                {
                    return BadRequest(new ErrorResponse("Invalid user credentials"));
                }

                var token = await _tokenService.CreateToken(user);

                var responseDto = _mapper.Map(user, new UserLoginResponseDto()
                {
                    Token = token,
                });

                return Ok(responseDto);
            }
            catch (Exception ex)
            {
                _logger.LogError("Could not login provided user {LoginDto}. Exception: {Error}", userLoginDto, ex);
                return StatusCode((int)HttpStatusCode.InternalServerError, new ErrorResponse("An internal error has occurred."));
            }
        }

        [Authorize(Policy = "IsSameUser")]
        [HttpDelete("{userId}/remove")]
        public async Task<ActionResult> DeleteUser([FromRoute] Guid userId)
        {
            try
            {
                if (userId == Guid.Empty)
                {
                    return BadRequest(new ErrorResponse("The user id route param must have a proper value."));
                }

                var user = await _unitOfWork.UserRepository.GetByIdAsync(userId);

                if (user == null)
                {
                    return NotFound(new ErrorResponse($"The user with the id {userId} does not exist."));
                }

                var deleteResult = await _unitOfWork.UserRepository.DeleteAsync(userId);

                if (!deleteResult)
                {
                    return StatusCode((int)HttpStatusCode.InternalServerError, new ErrorResponse($"Could not delete user {userId}."));
                }

                await _unitOfWork.CompleteAsync();

                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError("Could not delete user {UserId}. Exception: {Error}", userId, ex);
                return StatusCode((int)HttpStatusCode.InternalServerError, new ErrorResponse("An internal error has occurred."));
            }
        }

        [Authorize(Policy = "IsSameUser")]
        [HttpPut("{userId}/update")]
        public async Task<ActionResult> UpdateUser([FromRoute] Guid userId, [FromBody] UserUpdateRequestDto userUpdateDto)
        {
            try
            {
                if (userId == Guid.Empty)
                    return BadRequest(new ErrorResponse("The user id route param must have a proper value."));

                var user = await _unitOfWork.UserRepository.GetByIdAsync(userId);

                if (user == null)
                {
                    return NotFound(new ErrorResponse($"The user with the id {userId} does not exist."));
                }

                var updatedUser = _mapper.Map(userUpdateDto, user);

                var updateResult = await _unitOfWork.UserRepository.UpdateAsync(updatedUser);

                if (!updateResult)
                {
                    return BadRequest(new ErrorResponse($"Could not update the user with id {userId}."));
                }

                if (userUpdateDto.Password != null)
                {
                    var result = await _unitOfWork.UserRepository.UpdateUserPasswordAsync(user, userUpdateDto.Password);
                
                    if (!result)
                    {
                        return BadRequest(new ErrorResponse($"Could not update the user {userId}'s password."));
                    }
                }

                await _unitOfWork.CompleteAsync();

                var dbUpdatedUser = await _unitOfWork.UserRepository.GetByIdAsync(userId);

                var userResponseDto = _mapper.Map<UserUpdateResponseDto>(dbUpdatedUser);

                var token = await _tokenService.CreateToken(dbUpdatedUser);

                userResponseDto.Token = token;

                return Ok(userResponseDto);
            }
            catch (Exception ex)
            {
                _logger.LogError("Could not update user {UserId} using provided info {UpdateDto}. Exception: {Error}", userId, userUpdateDto, ex);
                return StatusCode((int)HttpStatusCode.InternalServerError, new ErrorResponse("An internal error has occurred."));
            }
        }
    }
}
