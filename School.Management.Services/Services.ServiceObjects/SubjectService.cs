using School.Management.Core.Entities;
using School.Management.Core.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace School.Management.Services
{
    public class SubjectService : ISubjectService
    {
        private readonly ISubjectRepository subjectRepository;
        public SubjectService(ISubjectRepository _subjectRepository)
        {
            subjectRepository = _subjectRepository;
        }
        public Task<Subject> Add(Subject TEntity)
        {
           return subjectRepository.Add(TEntity);
        }

        public Task<Subject> Delete(int id)
        {
            return subjectRepository.Delete(id);
        }

        public void Dispose()
        {
          
        }

        public Task<List<Subject>> GetAllAsync(int id)
        {
           return  subjectRepository.GetAllAsync(1);

        }

        public Task<Subject> GetByIdAsync(int id)
        {
            return subjectRepository.GetByIdAsync(1);
        }

        public Task<Subject> Update(Subject TEntity)
        {
            return subjectRepository.Update(TEntity);
        }
    }

}
