using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace School.Management.Core
{
    public interface IRespository<TEntity> : IDisposable where  TEntity : class
    {
        Task<List<TEntity>> GetAllAsync(int id);
        Task<TEntity> GetByIdAsync(int id);
        Task<TEntity> Add(TEntity TEntity);
        Task<TEntity> Update(TEntity TEntity);
        Task<TEntity> Delete(int id);
    }
}
