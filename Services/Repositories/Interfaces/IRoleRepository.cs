using KixPlay_Backend.Data.Entities;

namespace KixPlay_Backend.Services.Repositories.Interfaces
{
    public interface IRoleRepository : IGenericRepository<string, Role>
    {
        public Task<IOperationResult<Role>> GetByNameAsync(string roleName);

        public Task<IOperationResult<bool>> RolesExistAsync(IEnumerable<string> roleNames);

        public Task<IOperationResult<IEnumerable<Role>>> GetRolesByNames(IEnumerable<string> roleNames);
    }
}
