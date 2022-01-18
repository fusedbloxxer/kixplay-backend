using AutoMapper;
using KixPlay_Backend.DTOs.Requests;
using KixPlay_Backend.DTOs.Responses;
using KixPlay_Backend.Services.Repositories.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KixPlay_Backend.Controllers
{
    public class RolesController : BaseApiController
    {
        private readonly IMapper _mapper;

        private readonly IUserRoleRepository _userRoleRepository;

        public RolesController(
            IUserRoleRepository userRoleRepository,
            IMapper mapper
        )
        {
            _userRoleRepository = userRoleRepository;
            _mapper = mapper;
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<ActionResult> GetAllRoles()
        {
            var rolesResult = await _userRoleRepository.RoleRepository.GetAllAsync();

            if (!rolesResult.IsSuccessful)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new ErrorResponse
                {
                    Errors = rolesResult.Errors,
                });
            }

            return Ok(rolesResult.Result.Select(role => _mapper.Map<RoleGetResponseDto>(role)));
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("grant/{userId}")]
        public async Task<ActionResult> GrantRoleToUser([FromRoute] Guid userId, [FromBody] RoleRequestDto roleGrantRequest)
        {
            var grantResult = await _userRoleRepository.GrantRolesToUser(userId, roleGrantRequest.Roles);

            if (!grantResult.IsSuccessful)
            {
                return BadRequest(new ErrorResponse
                {
                    Errors = grantResult.Errors,
                });
            }

            var userGetResult = await _userRoleRepository.UserRepository.GetByIdAsync(userId);

            if (!userGetResult.IsSuccessful)
            {
                return BadRequest(new ErrorResponse
                {
                    Errors = userGetResult.Errors,
                });
            }

            var rolesGetResult = await _userRoleRepository.GetRolesFromUser(userGetResult.Result.Id);

            if (!rolesGetResult.IsSuccessful)
            {
                return BadRequest(new ErrorResponse
                {
                    Errors = rolesGetResult.Errors,
                });
            }

            var grantResponseDto = _mapper.Map<RoleGrantResponseDto>(userGetResult.Result);

            grantResponseDto.Roles = _mapper.Map<IEnumerable<RoleGetResponseDto>>(rolesGetResult.Result);

            return Ok(grantResponseDto);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("revoke/{userId}")]
        public async Task<ActionResult> RevokeRoleFromUser([FromRoute] Guid userId, [FromBody] RoleRequestDto roleGrantRequest)
        {
            var grantResult = await _userRoleRepository.RevokeRolesFromUser(userId, roleGrantRequest.Roles);

            if (!grantResult.IsSuccessful)
            {
                return BadRequest(new ErrorResponse
                {
                    Errors = grantResult.Errors,
                });
            }

            var userGetResult = await _userRoleRepository.UserRepository.GetByIdAsync(userId);

            if (!userGetResult.IsSuccessful)
            {
                return BadRequest(new ErrorResponse
                {
                    Errors = userGetResult.Errors,
                });
            }

            var rolesGetResult = await _userRoleRepository.GetRolesFromUser(userGetResult.Result.Id);

            if (!rolesGetResult.IsSuccessful)
            {
                return BadRequest(new ErrorResponse
                {
                    Errors = rolesGetResult.Errors,
                });
            }

            var grantResponseDto = _mapper.Map<RoleGrantResponseDto>(userGetResult.Result);

            grantResponseDto.Roles = _mapper.Map<IEnumerable<RoleGetResponseDto>>(rolesGetResult.Result);

            return Ok(grantResponseDto);
        }

        [Authorize(Policy = "IsSameUser")]
        [HttpGet("{userId}")]
        public async Task<ActionResult> GetRolesForUser([FromRoute] Guid userId)
        {
            var rolesGetResult = await _userRoleRepository.GetRolesFromUser(userId);

            if (!rolesGetResult.IsSuccessful)
            {
                return BadRequest(new ErrorResponse
                {
                    Errors = rolesGetResult.Errors,
                });
            }

            var rolesDto = _mapper.Map<IEnumerable<RoleGetResponseDto>>(rolesGetResult.Result);

            return Ok(rolesDto);
        }
    }
}
