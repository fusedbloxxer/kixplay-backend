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
    [Authorize(Roles = "Admin")]
    public class AdminsController : BaseApiController
    {
        private readonly IMapper _mapper;

        private readonly IUnitOfWork _unitOfWork;

        private readonly ITokenService _tokenService;

        private readonly ILogger<AdminsController> _logger;

        public AdminsController(
            IMapper mapper,
            IUnitOfWork unitOfWork,
            ITokenService tokenService,
            ILogger<AdminsController> logger
        ) {
            _tokenService = tokenService;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpPost("create")]
        public async Task<ActionResult> Create([FromBody] UserRegisterRequestDto userRegisterDto)
        {
            try
            {
                var createAdminResult = await _unitOfWork.UserRepository.CreateWithOptionsAsync(
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

                var findAdminResult = await _unitOfWork.UserRepository.GetByUsernameAsync(userRegisterDto.UserName);

                if (findAdminResult == null)
                {
                    return StatusCode((int)HttpStatusCode.InternalServerError, new ErrorResponse("Could not find the recent admin created."));
                }

                var token = await _tokenService.CreateToken(findAdminResult);

                await _unitOfWork.CompleteAsync();

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
