using KixPlay_Backend.Data.Entities;

namespace KixPlay_Backend.Services.Repositories.Interfaces
{
    public interface IUserRoleRepository
    {
        IUserRepository UserRepository { get; }

        IRoleRepository RoleRepository { get; }

        Task<IOperationResult<IEnumerable<Role>>> GetRolesFromUser(Guid userId);

        Task<IOperationResult<bool>> GrantRolesToUser(Guid userId, IEnumerable<string> roleNames);

        Task<IOperationResult<bool>> RevokeRolesFromUser(Guid userId, IEnumerable<string> roleNames);
    }
}
