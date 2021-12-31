using AutoMapper;
using KixPlay_Backend.Data.Entities;
using KixPlay_Backend.Services.Repositories.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace KixPlay_Backend.Services.Repositories.Implementations
{
    public class UserRepository : IUserRepository
    {
        private readonly IMapper _mapper;

        private readonly RoleManager<Role> _roleManager;
        
        private readonly UserManager<User> _userManager;

        public UserRepository(
            RoleManager<Role> roleManager,
            UserManager<User> userManager,
            IMapper mapper
        ) {
            _roleManager = roleManager;
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task<IOperationResult<bool>> CreateAsync(User user)
        {
            user.Id = Guid.NewGuid().ToString();

            var result = await _userManager.CreateAsync(user);

            return _mapper.Map<IdentityResult, OperationResult<bool>>(result);
        }

        public async Task<IOperationResult<bool>> CreateWithPasswordAsync(User user, string pass)
        {
            user.Id = Guid.NewGuid().ToString();

            var result = await _userManager.CreateAsync(user, pass);

            return _mapper.Map<IdentityResult, OperationResult<bool>>(result);
        }

        public async Task<IOperationResult<bool>> CreateWithOptions(User user, UserOptions options)
        {
            // Check the validity of the requested roles
            if (options.Roles != null && options.Roles.Any())
            {
                foreach (var role in options.Roles)
                {
                    var roles = _roleManager.Roles.ToList();

                    var roleExists = await _roleManager.RoleExistsAsync(role.Name);

                    if (!roleExists)
                    {
                        return new OperationResult<bool>(new List<string>()
                        {
                            $"Role {role} does not exist."
                        });
                    }
                }
            }

            IdentityResult result;

            user.Id = Guid.NewGuid().ToString();

            // Create the user with or without password
            if (!string.IsNullOrEmpty(options.Password))
            {
                result = await _userManager.CreateAsync(user, options.Password);

                if (!result.Succeeded)
                {
                    return _mapper.Map<IdentityResult, OperationResult<bool>>(result);
                }
            }
            else
            {
                result = await _userManager.CreateAsync(user);
            }

            if (!result.Succeeded)
            {
                return _mapper.Map<IdentityResult, OperationResult<bool>>(result);
            }

            // Add the requested roles to the user
            if (options.Roles != null && options.Roles.Any())
            {
                result = await _userManager.AddToRolesAsync(
                    user,
                    options.Roles.Select(role => role.Name)
                );

                if (!result.Succeeded)
                {
                    return _mapper.Map<IdentityResult, OperationResult<bool>>(result);
                }
            }

            return new OperationResult<bool>(true);
        }

        public async Task<IOperationResult<bool>> DeleteAsync(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
        
            if (user == null)
            {
                return new OperationResult<bool>($"User with id {id} does not exist.");
            }

            var result = await _userManager.DeleteAsync(user);

            return _mapper.Map<IdentityResult, OperationResult<bool>>(result);
        }

        public async Task<IOperationResult<bool>> ExistsAsync(string id)
        {
            var user = await _userManager.FindByIdAsync(id);

            return new OperationResult<bool>(user != null);
        }

        public async Task<IOperationResult<User>> GetByIdAsync(string id)
        {
            var user = await _userManager.FindByIdAsync(id);

            return new OperationResult<User>(user);
        }

        public async Task<IOperationResult<User>> GetByUsernameAsync(string username)
        {
            var user = await _userManager.FindByNameAsync(username);

            return new OperationResult<User>(user);
        }

        public async Task<IOperationResult<User>> GetByEmailAsync(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);

            return new OperationResult<User>(user);
        }

        public async Task<IOperationResult<bool>> UpdateAsync(User user)
        {
            var result = await _userManager.UpdateAsync(user);

            return _mapper.Map<IdentityResult, OperationResult<bool>>(result);
        }
    }
}
