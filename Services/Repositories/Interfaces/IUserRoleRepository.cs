using KixPlay_Backend.Data.Entities;

namespace KixPlay_Backend.Services.Repositories.Interfaces
{
    public interface IUserRoleRepository
    {
        IUserRepository UserRepository { get; }

        IRoleRepository RoleRepository { get; }

        Task<IEnumerable<Role>> GetRolesFromUser(Guid userId);

        Task<bool> GrantRolesToUser(Guid userId, IEnumerable<string> roleNames);

        Task<bool> RevokeRolesFromUser(Guid userId, IEnumerable<string> roleNames);
    }
}
