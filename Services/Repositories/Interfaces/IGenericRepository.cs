﻿using KixPlay_Backend.Data.Interfaces;

namespace KixPlay_Backend.Services.Repositories.Interfaces
{
    public interface IGenericRepository<TKey, TEntity>
        where TKey : IEquatable<TKey>
        where TEntity : IEntity<TKey>
    {
        Task<IOperationResult<bool>> CreateAsync(TEntity entity);
        
        Task<IOperationResult<bool>> UpdateAsync(TEntity entity);

        Task<IOperationResult<bool>> DeleteAsync(TKey id);

        Task<IOperationResult<bool>> ExistsAsync(TKey id);

        Task<IOperationResult<TEntity>> GetAsync(TKey id);
    }
}