using School.Management.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace School.Management.Services
{
    public interface IClassService : IService<Class>
    {
        public Task<Class> Add(Class TEntity)
        {
            throw new NotImplementedException();
        }

        public Task<Class> Delete(Class TEntity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<List<Class>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Class> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Class> Update(Class TEntity)
        {
            throw new NotImplementedException();
        }
    }
}
