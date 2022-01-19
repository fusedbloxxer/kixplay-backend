using AutoMapper;
using KixPlay_Backend.Data.Entities;
using KixPlay_Backend.DTOs.Requests;
using KixPlay_Backend.DTOs.Responses;
using KixPlay_Backend.Services.Interfaces;
using KixPlay_Backend.Services.Repositories.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace KixPlay_Backend.Controllers
{
    //[Authorize(Roles = "Admin")]
    public class AdminsController : BaseApiController
    {
        private readonly IMapper _mapper;

        private readonly ITokenService _tokenService;
        
        private readonly IUserRepository _userRepository;

        private readonly ILogger<AdminsController> _logger;

        public AdminsController(
            IMapper mapper,
            ITokenService tokenService,
            IUserRepository userRepository,
            ILogger<AdminsController> logger
        ) {
            _mapper = mapper;
            _tokenService = tokenService;
            _userRepository = userRepository;
            _logger = logger;
        }

        [HttpPost("create")]
        public async Task<ActionResult> Create([FromBody] UserRegisterRequestDto userRegisterDto)
        {
            try
            {
                var createAdminResult = await _userRepository.CreateWithOptionsAsync(
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

                if (!createAdminResult)
                {
                    return BadRequest(new ErrorResponse("Invalid admin creation request."));
                }

                var findAdminResult = await _userRepository.GetByUsernameAsync(userRegisterDto.UserName);

                if (findAdminResult == null)
                {
                    return StatusCode((int)HttpStatusCode.InternalServerError, new ErrorResponse("Could not find the recent admin created."));
                }

                var token = await _tokenService.CreateToken(findAdminResult);

                return Ok(new UserRegisterResponseDto
                {
                    Token = token,
                });
            }
            catch (Exception ex)
            {
                _logger.LogError("Could not create admin from info {AdminRequest}. Exception: {Error}", userRegisterDto, ex);
                return StatusCode((int)HttpStatusCode.InternalServerError, new ErrorResponse("An internal error has occurred."));
            }
        }
    }
}
