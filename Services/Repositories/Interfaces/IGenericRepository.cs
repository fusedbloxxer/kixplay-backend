using KixPlay_Backend.Data.Abstractions;
using System.Linq.Expressions;

namespace KixPlay_Backend.Services.Repositories.Interfaces
{
    public interface IGenericRepository<TKey, TEntity>
        where TKey : IEquatable<TKey>
        where TEntity : IEntity<TKey>
    {
        Task<IEnumerable<TEntity>> GetAllAsync();
        
        Task<TEntity> GetByIdAsync(TKey id);
        
        Task<bool> CreateAsync(TEntity entity);
        
        Task<bool> UpdateAsync(TEntity entity);

        Task<bool> DeleteAsync(TKey id);

        Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate);
    }
}
