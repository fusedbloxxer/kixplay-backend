using AutoMapper;
using KixPlay_Backend.Data.Entities;
using KixPlay_Backend.Services.Repositories.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace KixPlay_Backend.Services.Repositories.Implementations
{
    public class UserRepository : IUserRepository
    {
        private readonly IMapper _mapper;
        
        private readonly UserManager<User> _userManager;
        
        private readonly IRoleRepository _roleRepository;

        private readonly SignInManager<User> _signInManager;

        public UserRepository(
            SignInManager<User> signInManager,
            IRoleRepository roleRepository,
            UserManager<User> userManager,
            IMapper mapper
        ) {
            _roleRepository = roleRepository;
            _signInManager = signInManager;
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task<IOperationResult<bool>> CreateAsync(User user)
        {
            user.Id = Guid.NewGuid();

            var result = await _userManager.CreateAsync(user);

            return _mapper.Map<IdentityResult, OperationResult<bool>>(result);
        }

        public async Task<IOperationResult<bool>> CreateWithPasswordAsync(User user, string pass)
        {
            user.Id = Guid.NewGuid();

            var result = await _userManager.CreateAsync(user, pass);

            return _mapper.Map<IdentityResult, OperationResult<bool>>(result);
        }

        public async Task<IOperationResult<bool>> CreateWithOptions(User user, UserOptions options)
        {
            // Check the validity of the requested roles
            var rolesExistResult = await _roleRepository.RolesExistAsync(options.Roles);

            if (!rolesExistResult.IsSuccessful)
            {
                return rolesExistResult;
            }

            IdentityResult result;

            user.Id = Guid.NewGuid();

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
                    options.Roles
                );

                if (!result.Succeeded)
                {
                    return _mapper.Map<IdentityResult, OperationResult<bool>>(result);
                }
            }

            return new OperationResult<bool>(true);
        }

        public async Task<IOperationResult<bool>> DeleteAsync(Guid id)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());
        
            if (user == null)
            {
                return new OperationResult<bool>($"User with id {id} does not exist.");
            }

            var result = await _userManager.DeleteAsync(user);

            return _mapper.Map<IdentityResult, OperationResult<bool>>(result);
        }

        public async Task<IOperationResult<bool>> ExistsAsync(Guid id)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());

            return new OperationResult<bool>(user != null);
        }

        public async Task<IOperationResult<User>> GetByIdAsync(Guid id)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());

            if (user == null)
            {
                return new OperationResult<User>($"User with id {id} does not exist.");
            }

            return new OperationResult<User>(user);
        }

        public async Task<IOperationResult<User>> GetByUsernameAsync(string username)
        {
            var user = await _userManager.FindByNameAsync(username);

            if (user == null)
            {
                return new OperationResult<User>($"User with username {username} does not exist.");
            }

            return new OperationResult<User>(user);
        }

        public async Task<IOperationResult<User>> GetByEmailAsync(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);

            if (user == null)
            {
                return new OperationResult<User>($"User with email {email} does not exist.");
            }

            return new OperationResult<User>(user);
        }

        public async Task<IOperationResult<bool>> UpdateAsync(User user)
        {
            var result = await _userManager.UpdateAsync(user);

            return _mapper.Map<IdentityResult, OperationResult<bool>>(result);
        }

        public async Task<IOperationResult<bool>> IsUserLoginValid(User user, string password)
        {
            var signInResult = await _signInManager.CheckPasswordSignInAsync(
                user,
                password,
                false
            );

            if (!signInResult.Succeeded)
            {
                return new OperationResult<bool>($"Could not sign in the user with the email {user.Email}.");
            }

            if (signInResult.IsLockedOut)
            {
                return new OperationResult<bool>($"Access to the user with the email {user.Email} is blocked temporarily.");
            }

            if (signInResult.IsNotAllowed)
            {
                return new OperationResult<bool>($"The user with the email {user.Email} has not been authorized.");
            }

            return new OperationResult<bool>(true);
        }

        public async Task<IOperationResult<IEnumerable<User>>> GetAllAsync()
        {
            var users = await _userManager.Users.ToListAsync();

            return new OperationResult<IEnumerable<User>>(users);
        }
    }
}
