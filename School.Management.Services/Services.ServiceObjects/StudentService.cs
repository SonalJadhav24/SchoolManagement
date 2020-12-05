using School.Management.Core.Entities;
using School.Management.Core.Repository;
using System;

using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace School.Management.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public Task<Student> Add(Student TEntity)
        {
            return _studentRepository.Add(TEntity);
        }
        public Task<Student> Delete(int id)
        {
            return _studentRepository.Delete(id);
        }
        public void Dispose()
        {
           
        }
        public Task<List<Student>> GetAllAsync(int id)
        {
          return _studentRepository.GetAllAsync(id);
        }

        public Task<Student> GetByIdAsync(int id)
        {
            return _studentRepository.GetByIdAsync(id);
        }

        public Task<Student> Update(Student TEntity)
        {
            return _studentRepository.Update(TEntity);
        }
    }
}
