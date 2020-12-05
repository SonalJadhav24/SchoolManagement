using School.Management.Core.Entities;
using School.Management.Core.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace School.Management.Services
{
    public class TeacherService : ITeacherService
    {
        private readonly ITeacherRepository teacherRepository ;
        public TeacherService(ITeacherRepository _teacherRepository )
        {
            teacherRepository = _teacherRepository;
        }

         
        public Task<Teacher> Add(Teacher TEntity)
        {
            throw new NotImplementedException();
        }

        public Task<Teacher> Delete(int TEntity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
        }

        public Task<List<Teacher>> GetAllAsync(int id)
        {
           return  teacherRepository.GetAllAsync(0);
        }

        public Task<Teacher> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Teacher> Update(Teacher TEntity)
        {
            throw new NotImplementedException();
        }
    }
}
