using AutoMapper;
using KixPlay_Backend.Data.Entities;
using KixPlay_Backend.Services.Repositories.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace KixPlay_Backend.Services.Repositories.Implementations
{
    public class RoleRepository : IRoleRepository
    {
        private readonly RoleManager<Role> _roleManager;

        private readonly ILogger<RoleRepository> _logger;

        public RoleRepository(
            ILogger<RoleRepository> logger,
            RoleManager<Role> roleManager
        ) {
            _logger = logger;
            _roleManager = roleManager;
        }

        public async Task<IEnumerable<Role>> GetAllAsync()
        {
            return await _roleManager.Roles.ToListAsync();
        }

        public async Task<bool> CreateAsync(Role role)
        {
            var roleCreateResult = await _roleManager.CreateAsync(role);

            if (!roleCreateResult.Succeeded)
            {
                _logger.LogError("Could not create role. IdentityError occurred: {IdentityErrors}", roleCreateResult.Errors);
                return false;
            }

            return true;
        }

        public async Task<bool> DeleteAsync(Guid roleId)
        {
            var role = await GetByIdAsync(roleId);

            if (role == null)
            {
                _logger.LogError("Could not delete role {RoleId}.", roleId);
                return false;
            }

            var deleteRoleResult = await _roleManager.DeleteAsync(role);

            if (!deleteRoleResult.Succeeded)
            {
                _logger.LogError("Could not delete role {RoleId}.", roleId);
                return false;
            }

            return true;
        }

        public async Task<Role> GetByIdAsync(Guid roleId)
        {
            var role = await _roleManager.FindByIdAsync(roleId.ToString());

            if (role == null)
            {
                _logger.LogError("Could not find role {RoleId}.", roleId);
                return null;
            }

            return role;
        }

        public async Task<bool> UpdateAsync(Role role)
        {
            var roleUpdateResult = await _roleManager.UpdateAsync(role);

            if (!roleUpdateResult.Succeeded)
            {
                _logger.LogError("Could not update role: {Role}. IdentityError occurred: {IdentityErrors}", role, roleUpdateResult.Errors);
                return false;
            }

            return true;
        }

        public async Task<Role> GetByNameAsync(string roleName)
        {
            var role = await _roleManager.FindByNameAsync(roleName);

            if (role == null)
            {
                _logger.LogError("Could not find role with name {RoleName}.", roleName);
                return null;
            }

            return role;
        }

        public async Task<bool> RolesExistAsync(IEnumerable<string> roleNames)
        {
            if (roleNames == null || !roleNames.Any())
            {
                throw new ArgumentNullException(nameof(roleNames));
            }

            foreach (var roleName in roleNames)
            {
                var roleExists = await _roleManager.RoleExistsAsync(roleName);

                if (!roleExists)
                {
                    _logger.LogError("Could not find role with name {RoleName}.", roleName);
                    return false;
                }
            }

            return true;
        }

        public async Task <IEnumerable<Role>> GetRolesByNamesAsync(IEnumerable<string> roleNames)
        {
            if (roleNames == null || !roleNames.Any())
            {
                throw new ArgumentNullException(nameof(roleNames));
            }

            List<Role> roles = new(roleNames.Count());

            foreach (var roleName in roleNames)
            {
                var role = await _roleManager.FindByNameAsync(roleName);
            
                if (role == null)
                {
                    _logger.LogError("Could not find role with name {RoleName}.", roleName);
                    continue;
                }

                roles.Add(role);
            }

            return roles;
        }

        public async Task<IEnumerable<Role>> FindAsync(Expression<Func<Role, bool>> predicate)
        {
            if (predicate == null)
            {
                throw new ArgumentNullException(nameof(predicate));
            }
            
            return await _roleManager.Roles.Where(predicate).ToListAsync();
        }
    }
}
