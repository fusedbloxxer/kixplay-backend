using AutoMapper;
using KixPlay_Backend.Data.Entities;
using KixPlay_Backend.Services.Repositories.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace KixPlay_Backend.Services.Repositories.Implementations
{
    public class UserRoleRepository : IUserRoleRepository
    {
        private readonly IMapper _mapper;

        private readonly UserManager<User> _userManager;

        public IUserRepository UserRepository { get; }
        
        public IRoleRepository RoleRepository { get; }

        public UserRoleRepository(
            IUserRepository userRepository,
            IRoleRepository roleRepository,
            UserManager<User> userManager,
            IMapper mapper
        ) {
            UserRepository = userRepository;
            RoleRepository = roleRepository;
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task<IOperationResult<bool>> GrantRolesToUser(string userId, IEnumerable<string> roleNames)
        {
            var rolesExistResult = await RoleRepository.RolesExistAsync(roleNames);

            if (!rolesExistResult.IsSuccessful)
            {
                return rolesExistResult;
            }

            var userExistsResult = await UserRepository.GetByIdAsync(userId);

            if (!userExistsResult.IsSuccessful)
            {
                return new OperationResult<bool>(userExistsResult.Errors);
            }

            var grantRolesResult = await _userManager.AddToRolesAsync(userExistsResult.Result, roleNames);

            if (!grantRolesResult.Succeeded)
            {
                return _mapper.Map<OperationResult<bool>>(grantRolesResult);
            }

            return new OperationResult<bool>(true);
        }

        public async Task<IOperationResult<bool>> RevokeRolesFromUser(string userId, IEnumerable<string> roleNames)
        {
            var rolesExistResult = await RoleRepository.RolesExistAsync(roleNames);

            if (!rolesExistResult.IsSuccessful)
            {
                return rolesExistResult;
            }

            var userExistsResult = await UserRepository.GetByIdAsync(userId);

            if (!userExistsResult.IsSuccessful)
            {
                return new OperationResult<bool>(userExistsResult.Errors);
            }

            var grantRolesResult = await _userManager.RemoveFromRolesAsync(userExistsResult.Result, roleNames);

            if (!grantRolesResult.Succeeded)
            {
                return _mapper.Map<OperationResult<bool>>(grantRolesResult);
            }

            return new OperationResult<bool>(true);
        }

        public async Task<IOperationResult<IEnumerable<Role>>> GetRolesFromUser(string userId)
        {
            var userGetResult = await UserRepository.GetByIdAsync(userId);
        
            if (!userGetResult.IsSuccessful)
            {
                return new OperationResult<IEnumerable<Role>>(userGetResult.Errors);
            }

            var userRoles = await _userManager.GetRolesAsync(userGetResult.Result);

            var rolesResult = await RoleRepository.GetRolesByNames(userRoles);

            return rolesResult;
        }
    }
}
