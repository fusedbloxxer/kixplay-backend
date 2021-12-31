using KixPlay_Backend.Data.Entities;

namespace KixPlay_Backend.Services.Repositories.Interfaces
{
    public interface IUserRoleRepository
    {
        IUserRepository UserRepository { get; }

        IRoleRepository RoleRepository { get; }

        Task<IOperationResult<IEnumerable<Role>>> GetRolesFromUser(string userId);

        Task<IOperationResult<bool>> GrantRolesToUser(string userId, IEnumerable<string> roleNames);

        Task<IOperationResult<bool>> RevokeRolesFromUser(string userId, IEnumerable<string> roleNames);
    }
}
