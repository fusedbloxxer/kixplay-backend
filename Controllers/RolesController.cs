using AutoMapper;
using KixPlay_Backend.DTOs.Requests;
using KixPlay_Backend.DTOs.Responses;
using KixPlay_Backend.Services.Repositories.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace KixPlay_Backend.Controllers
{
    public class RolesController : BaseApiController
    {
        private readonly IMapper _mapper;

        private readonly ILogger<RolesController> _logger;

        private readonly IUserRoleRepository _userRoleRepository;

        public RolesController(
            IUserRoleRepository userRoleRepository,
            ILogger<RolesController> logger,
            IMapper mapper
        ) {
            _userRoleRepository = userRoleRepository;
            _logger = logger;
            _mapper = mapper;
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<ActionResult> GetAllRoles()
        {
            try
            {
                var roles = await _userRoleRepository.RoleRepository.GetAllAsync();
                return Ok(roles.Select(role => _mapper.Map<RoleGetResponseDto>(role)));
            }
            catch (Exception ex)
            {
                _logger.LogError("Could not retrieve all roles. Exception: {Error}", ex);
                return StatusCode((int)HttpStatusCode.InternalServerError, new ErrorResponse("An internal error has occurred."));
            }
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("grant/{userId}")]
        public async Task<ActionResult> GrantRoleToUser([FromRoute] Guid userId, [FromBody] RoleRequestDto roleGrantRequest)
        {
            try
            {
                var grantResult = await _userRoleRepository.GrantRolesToUser(userId, roleGrantRequest.Roles);

                if (!grantResult)
                {
                    return BadRequest(new ErrorResponse($"Could not grant roles to user {userId}."));
                }

                var user = await _userRoleRepository.UserRepository.GetByIdAsync(userId);

                if (user == null)
                {
                    return BadRequest(new ErrorResponse($"User {userId} not found."));
                }

                var roles = await _userRoleRepository.GetRolesFromUser(user.Id);

                var grantResponseDto = _mapper.Map<RoleGrantResponseDto>(user);

                grantResponseDto.Roles = _mapper.Map<IEnumerable<RoleGetResponseDto>>(roles);

                return Ok(grantResponseDto);
            }
            catch (Exception ex)
            {
                _logger.LogError("Could not grant role to user {UserId} from request {Request}. Exception: {Error}", userId, roleGrantRequest, ex);
                return StatusCode((int)HttpStatusCode.InternalServerError, new ErrorResponse("An internal error has occurred."));
            }
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("revoke/{userId}")]
        public async Task<ActionResult> RevokeRoleFromUser([FromRoute] Guid userId, [FromBody] RoleRequestDto roleRevokeRequest)
        {
            try
            {
                var revokeResult = await _userRoleRepository.RevokeRolesFromUser(userId, roleRevokeRequest.Roles);

                if (!revokeResult)
                {
                    return BadRequest(new ErrorResponse($"Invalid revoke roles request for {userId}."));
                }

                var user = await _userRoleRepository.UserRepository.GetByIdAsync(userId);

                if (user == null)
                {
                    return BadRequest(new ErrorResponse($"User {userId} was not found."));
                }

                var roles = await _userRoleRepository.GetRolesFromUser(user.Id);

                var grantResponseDto = _mapper.Map<RoleGrantResponseDto>(user);

                grantResponseDto.Roles = _mapper.Map<IEnumerable<RoleGetResponseDto>>(roles);

                return Ok(grantResponseDto);
            }
            catch (Exception ex)
            {
                _logger.LogError("Could not revoke roles from user {UserId} with request {Request}. Exception: {Error}", userId, roleRevokeRequest, ex);
                return StatusCode((int)HttpStatusCode.InternalServerError, new ErrorResponse("An internal error has occurred."));
            }
        }

        [Authorize(Policy = "IsSameUser")]
        [HttpGet("{userId}")]
        public async Task<ActionResult> GetRolesForUser([FromRoute] Guid userId)
        {
            try
            {
                var roles = await _userRoleRepository.GetRolesFromUser(userId);

                var rolesDto = _mapper.Map<IEnumerable<RoleGetResponseDto>>(roles);

                return Ok(rolesDto);
            }
            catch (Exception ex)
            {
                _logger.LogError("Could not retrieve all roles. Exception: {Error}", ex);
                return StatusCode((int)HttpStatusCode.InternalServerError, new ErrorResponse("An internal error has occurred."));
            }
        }
    }
}
