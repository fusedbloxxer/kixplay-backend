using AutoMapper;
using KixPlay_Backend.Data.Abstractions;
using KixPlay_Backend.Services.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace KixPlay_Backend.Services.Repositories.Implementations
{
    public abstract class GenericRepository<TKey, TEntity, TContext> : IGenericRepository<TKey, TEntity>
        where TEntity : class, IEntity<TKey>
        where TKey : IEquatable<TKey>
        where TContext : DbContext
    {
        protected readonly ILogger _logger;

        protected readonly IMapper _mapper;

        private protected readonly TContext _context;
        
        private protected readonly DbSet<TEntity> _dbSet;

        public GenericRepository(
            TContext context,
            ILogger logger,
            IMapper mapper
        ) {
            _dbSet = context.Set<TEntity>();
            _context = context;
            _logger = logger;
            _mapper = mapper;
        }

        public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public virtual async Task<TEntity> GetByIdAsync(TKey id)
        {
            return await _dbSet.FindAsync(id);
        }

        public virtual async Task<bool> CreateAsync(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
            return true;
        }

        public virtual async Task<bool> DeleteAsync(TKey id)
        {
            var entry = await _dbSet.Where(entity => entity.Id.Equals(id)).FirstOrDefaultAsync();

            if (entry == null)
            {
                return false;
            }

            _dbSet.Remove(entry);
            return true;
        }

        public virtual async Task<bool> UpdateAsync(TEntity entity)
        {
            var entry = await _dbSet.Where(entity => entity.Id.Equals(entity.Id)).FirstOrDefaultAsync();

            if (entry == null)
            {
                return false;
            }

            entry = _mapper.Map(entity, entry);
            
            _dbSet.Update(entry);

            return true;
        }

        public virtual async Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _dbSet.Where(predicate).ToListAsync();
        }
    }
}
