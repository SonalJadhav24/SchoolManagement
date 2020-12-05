using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace School.Management.Services
{
    public interface IService<TEntity> : IDisposable where TEntity : class
    {
        Task<List<TEntity>> GetAllAsync(int id);
        Task<TEntity> GetByIdAsync(int id );
        Task<TEntity> Add(TEntity TEntity);
        Task<TEntity> Update(TEntity TEntity);
        Task<TEntity> Delete(int  id);
    }
}
