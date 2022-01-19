using AutoMapper;
using KixPlay_Backend.Data.Entities;
using KixPlay_Backend.Services.Repositories.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace KixPlay_Backend.Services.Repositories.Implementations
{
    public class UserRepository : IUserRepository
    {
        private readonly UserManager<User> _userManager;

        private readonly ILogger<UserRepository> _logger;
        
        private readonly IRoleRepository _roleRepository;

        private readonly SignInManager<User> _signInManager;

        public UserRepository(
            SignInManager<User> signInManager,
            ILogger<UserRepository> logger,
            IRoleRepository roleRepository,
            UserManager<User> userManager
        ) {
            _roleRepository = roleRepository;
            _signInManager = signInManager;
            _userManager = userManager;
            _logger = logger;
        }

        public async Task<bool> CreateAsync(User user)
        {
            user.Id = Guid.NewGuid();

            var userCreateResult = await _userManager.CreateAsync(user);

            if (!userCreateResult.Succeeded)
            {
                _logger.LogError("Could not create user {User}. IdentityErrors occurred: {IdentityErrors}", user, userCreateResult.Errors);
                return false;
            }

            return true;
        }

        public async Task<bool> CreateWithPasswordAsync(User user, string pass)
        {
            user.Id = Guid.NewGuid();

            var userCreateResult = await _userManager.CreateAsync(user, pass);

            if (!userCreateResult.Succeeded)
            {
                _logger.LogError("Could not create user {User}. IdentityErrors occurred: {IdentityErrors}", user, userCreateResult.Errors);
                return false;
            }

            return true;
        }

        public async Task<bool> CreateWithOptionsAsync(User user, UserOptions options)
        {
            // Check the validity of the requested roles
            var rolesExistResult = await _roleRepository.RolesExistAsync(options.Roles);

            if (!rolesExistResult)
            {
                _logger.LogError("Could not create user {User} with options {Options}.", user, options);
                return false;
            }

            IdentityResult userCreateResult;

            user.Id = Guid.NewGuid();

            // Create the user with or without password
            if (!string.IsNullOrEmpty(options.Password))
            {
                userCreateResult = await _userManager.CreateAsync(user, options.Password);
            }
            else
            {
                userCreateResult = await _userManager.CreateAsync(user);
            }

            if (!userCreateResult.Succeeded)
            {
                _logger.LogError("Could not create user {User} with options {Options}. IdentityErrors occured: {IdentityErrors}", user, options, userCreateResult.Errors);
                return false;
            }

            // Add the requested roles to the user
            if (options.Roles != null && options.Roles.Any())
            {
                userCreateResult = await _userManager.AddToRolesAsync(
                    user,
                    options.Roles
                );

                if (!userCreateResult.Succeeded)
                {
                    _logger.LogError("Could not create user {User} with options {Options}. IdentityErrors occured: {IdentityErrors}", user, options, userCreateResult.Errors);
                    return false;
                }
            }

            return true;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());
        
            if (user == null)
            {
                _logger.LogError("Could not find user with id {UserId}", id);
                return false;
            }

            var userDeleteResult = await _userManager.DeleteAsync(user);

            if (!userDeleteResult.Succeeded)
            {
                _logger.LogError("Could not delete user {User} with id {UserId}. IdentityErrors occured: {IdentityErrors}", user, id, userDeleteResult.Errors);
                return false;
            }

            return true;
        }

        public async Task<User> GetByIdAsync(Guid id)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());

            if (user == null)
            {
                _logger.LogError("Could not find user with id {UserId}", id);
                return null;
            }

            return user;
        }

        public async Task<User> GetByUsernameAsync(string username)
        {
            var user = await _userManager.FindByNameAsync(username);

            if (user == null)
            {
                _logger.LogError("Could not find user with username {Username}", username);
                return null;
            }

            return user;
        }

        public async Task<User> GetByEmailAsync(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);

            if (user == null)
            {
                _logger.LogError("Could not find user with email {Email}", email);
                return null;
            }

            return user;
        }

        public async Task<bool> UpdateAsync(User user)
        {
            var updateUserResult = await _userManager.UpdateAsync(user);

            if (!updateUserResult.Succeeded)
            {
                _logger.LogError("Could not update user {User}. IdentityErrors occured: {IdentityErrors}", user, updateUserResult.Errors);
                return false;
            }

            return true;
        }

        public async Task<bool> CanUserLoginAsync(User user, string password)
        {
            var signInResult = await _signInManager.CheckPasswordSignInAsync(
                user,
                password,
                false
            );

            if (!signInResult.Succeeded)
            {
                _logger.LogInformation("User login information is invalid: {User}.", user);
                return false;
            }

            if (signInResult.IsLockedOut)
            {
                _logger.LogInformation("User login information is invalid: {User}.", user);
                return false;
            }

            if (signInResult.IsNotAllowed)
            {
                _logger.LogInformation("User is not allowed to login: {User}.", user);
                return false;
            }

            return true;
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            return await _userManager.Users.ToListAsync();
        }

        public async Task<IEnumerable<User>> FindAsync(Expression<Func<User, bool>> predicate)
        {
            return await _userManager.Users.Where(predicate).ToListAsync();
        }
    }
}
