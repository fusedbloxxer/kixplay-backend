using KixPlay_Backend.Data.Entities;
using KixPlay_Backend.Services.Repositories.Implementations;

namespace KixPlay_Backend.Services.Repositories.Interfaces
{
    public interface IUserRepository : IGenericRepository<Guid, User>
    {
        Task<User> GetByEmailAsync(string email);

        Task<User> GetByUsernameAsync(string username);

        Task<bool> CanUserLoginAsync(User user, string password);

        Task<bool> UpdateUserPasswordAsync(User user, string password);

        Task<bool> CreateWithPasswordAsync(User user, string password);

        Task<bool> CreateWithOptionsAsync(User user, UserOptions options);
    }
}
