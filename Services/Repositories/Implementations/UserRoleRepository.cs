using AutoMapper;
using KixPlay_Backend.Data.Entities;
using KixPlay_Backend.Services.Repositories.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace KixPlay_Backend.Services.Repositories.Implementations
{
    public class UserRoleRepository : IUserRoleRepository
    {
        private readonly ILogger<UserRoleRepository> _logger;
        private readonly UserManager<User> _userManager;

        public IUserRepository UserRepository { get; }
        
        public IRoleRepository RoleRepository { get; }

        public UserRoleRepository(
            ILogger<UserRoleRepository> logger,
            IUserRepository userRepository,
            IRoleRepository roleRepository,
            UserManager<User> userManager
        ) {
            UserRepository = userRepository;
            RoleRepository = roleRepository;
            _userManager = userManager;
            _logger = logger;
        }

        public async Task<bool> GrantRolesToUser(Guid userId, IEnumerable<string> roleNames)
        {
            var rolesExistResult = await RoleRepository.RolesExistAsync(roleNames);

            if (!rolesExistResult)
            {
                _logger.LogError("Could not grant roles {RoleNames} to user with id {Id}.", roleNames, userId);
                return false;
            }

            var user = await UserRepository.GetByIdAsync(userId);

            if (user == null)
            {
                _logger.LogError("Could not grant roles {RoleNames} to user with id {Id}.", roleNames, userId);
                return false;
            }

            var grantRolesResult = await _userManager.AddToRolesAsync(user, roleNames);

            if (!grantRolesResult.Succeeded)
            {
                _logger.LogError("Could not grant roles {RoleNames} to user with id {Id}. IdentityErrors: {IdentityErrors}", roleNames, userId, grantRolesResult.Errors);
                return false;
            }

            return true;
        }

        public async Task<bool> RevokeRolesFromUser(Guid userId, IEnumerable<string> roleNames)
        {
            var rolesExist = await RoleRepository.RolesExistAsync(roleNames);

            if (!rolesExist)
            {
                _logger.LogError("Could not revoke roles {RoleNames} from user with id {Id}.", roleNames, userId);
                return false;
            }

            var user = await UserRepository.GetByIdAsync(userId);

            if (user == null)
            {
                _logger.LogError("Could not revoke roles {RoleNames} from user with id {Id}.", roleNames, userId);
                return false;
            }

            var revokeRolesResult = await _userManager.RemoveFromRolesAsync(user, roleNames);

            if (!revokeRolesResult.Succeeded)
            {
                _logger.LogError("Could not grant roles {RoleNames} to user with id {Id}. IdentityErrors: {IdentityErrors}", roleNames, userId, revokeRolesResult.Errors);
                return false;
            }

            return true;
        }

        public async Task<IEnumerable<Role>> GetRolesFromUser(Guid userId)
        {
            var user = await UserRepository.GetByIdAsync(userId);
        
            if (user == null)
            {
                _logger.LogError("Could not retrieve roles for user with id {Id}.", userId);
                throw new Exception($"Could not retrieve roles for user {userId}. User was not found");
            }

            var roleNames = await _userManager.GetRolesAsync(user);

            var rolesResult = await RoleRepository.GetRolesByNamesAsync(roleNames);

            return rolesResult;
        }
    }
}
