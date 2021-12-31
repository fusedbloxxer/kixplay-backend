using KixPlay_Backend.Data.Entities;
using KixPlay_Backend.Services.Repositories.Implementations;

namespace KixPlay_Backend.Services.Repositories.Interfaces
{
    public interface IUserRepository : IGenericRepository<string, User>
    {
        Task<IOperationResult<User>> GetByEmailAsync(string email);

        Task<IOperationResult<User>> GetByUsernameAsync(string username);

        Task<IOperationResult<bool>> CreateWithOptions(User user, UserOptions options);

        Task<IOperationResult<bool>> CreateWithPasswordAsync(User user, string password);
    }
}
