using KixPlay_Backend.Data.Entities;

namespace KixPlay_Backend.Services.Repositories.Interfaces
{
    public interface IRoleRepository : IGenericRepository<Guid, Role>
    {
        public Task<Role> GetByNameAsync(string roleName);

        public Task<bool> RolesExistAsync(IEnumerable<string> roleNames);

        public Task<IEnumerable<Role>> GetRolesByNamesAsync(IEnumerable<string> roleNames);
    }
}
