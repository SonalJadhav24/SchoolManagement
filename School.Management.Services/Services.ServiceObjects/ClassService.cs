using School.Management.Core.Entities;
using School.Management.Core.Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace School.Management.Services
{
    public class ClassService : IClassService
    {
        private readonly IClassRepository _classRepository ;

   
        public ClassService(IClassRepository classRepository)
        {
            _classRepository = classRepository;
        }
        public Task<Class> Add(Class TEntity)
        {
            throw new NotImplementedException();
        }

        public Task<Class> Delete(int TEntity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
         
        }

        public Task<List<Class>> GetAllAsync(int id)
        {
           return  _classRepository.GetAllAsync(id);
        }

        public Task<Class> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
        public Task<Class> Update(Class TEntity)
        {
            throw new NotImplementedException();
        }
    }
}
