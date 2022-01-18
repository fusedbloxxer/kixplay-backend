using AutoMapper;
using KixPlay_Backend.Data.Entities;
using KixPlay_Backend.Services.Repositories.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace KixPlay_Backend.Services.Repositories.Implementations
{
    public class RoleRepository : IRoleRepository
    {
        private readonly IMapper _mapper;

        private readonly RoleManager<Role> _roleManager;

        public RoleRepository(
            RoleManager<Role> roleManager,
            IMapper mapper
        )
        {
            _roleManager = roleManager;
            _mapper = mapper;
        }

        public async Task<IOperationResult<IEnumerable<Role>>> GetAllAsync()
        {
            var roles = await _roleManager.Roles.ToListAsync();

            return new OperationResult<IEnumerable<Role>>(roles);
        }

        public async Task<IOperationResult<bool>> CreateAsync(Role role)
        {
            var roleCreateResult = await _roleManager.CreateAsync(role);

            return _mapper.Map<OperationResult<bool>>(roleCreateResult);
        }

        public async Task<IOperationResult<bool>> DeleteAsync(Guid roleId)
        {
            var getRoleResult = await GetByIdAsync(roleId);

            if (!getRoleResult.IsSuccessful)
            {
                return new OperationResult<bool>(getRoleResult.Errors);
            }

            var deleteRoleResult = await _roleManager.DeleteAsync(getRoleResult.Result);

            if (!deleteRoleResult.Succeeded)
            {
                return _mapper.Map<OperationResult<bool>>(deleteRoleResult);
            }

            return new OperationResult<bool>(true);
        }

        public async Task<IOperationResult<bool>> ExistsAsync(Guid roleId)
        {
            var role = await _roleManager.FindByIdAsync(roleId.ToString());

            return new OperationResult<bool>(role != null);
        }

        public async Task<IOperationResult<Role>> GetByIdAsync(Guid roleId)
        {
            var role = await _roleManager.FindByIdAsync(roleId.ToString());

            if (role == null)
            {
                return new OperationResult<Role>($"The role {roleId} does not exist.");
            }

            return new OperationResult<Role>(role);
        }

        public async Task<IOperationResult<bool>> UpdateAsync(Role role)
        {
            var roleUpdateResult = await _roleManager.UpdateAsync(role);

            if (!roleUpdateResult.Succeeded)
            {
                return _mapper.Map<OperationResult<bool>>(roleUpdateResult);
            }

            return new OperationResult<bool>(true);
        }

        public async Task<IOperationResult<Role>> GetByNameAsync(string roleName)
        {
            var role = await _roleManager.FindByNameAsync(roleName);

            if (role == null)
            {
                return new OperationResult<Role>($"The role with the name {roleName} does not exist.");
            }

            return new OperationResult<Role>(role);
        }

        public async Task<IOperationResult<bool>> RolesExistAsync(IEnumerable<string> roleNames)
        {
            if (roleNames == null || !roleNames.Any())
            {
                return new OperationResult<bool>($"No role names were specified.");
            }

            foreach (var roleName in roleNames)
            {
                var roleExists = await _roleManager.RoleExistsAsync(roleName);

                if (!roleExists)
                {
                    return new OperationResult<bool>($"The role with the name {roleName} does not exist.");
                }
            }

            return new OperationResult<bool>(true);
        }

        public async Task<IOperationResult<IEnumerable<Role>>> GetRolesByNames(IEnumerable<string> roleNames)
        {
            if (roleNames == null || !roleNames.Any())
            {
                return new OperationResult<IEnumerable<Role>>($"No role names were specified.");
            }

            List<Role> roles = new(roleNames.Count());

            foreach (var roleName in roleNames)
            {
                var role = await _roleManager.FindByNameAsync(roleName);
            
                if (role == null)
                {
                    return new OperationResult<IEnumerable<Role>>($"Role with name {roleName} does not exist.");
                }

                roles.Add(role);
            }

            return new OperationResult<IEnumerable<Role>>(roles);
        }
    }
}
