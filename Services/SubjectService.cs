using AcademicInfoSystem.Domain;
using AcademicInfoSystem.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicInfoSystem.Services
{
    public class SubjectService
    {
        private readonly ISubjectRepository _ISubjectRepository;
      
        public SubjectService(ISubjectRepository subjectRepository) 
        {
          _ISubjectRepository = subjectRepository;
        }
        public List<Subject> GetByTeacherId(long teacherId)
        {
            return _ISubjectRepository.GetByTeacherId(teacherId);
        }

        public List<Subject> GetAll()
        {
            return _ISubjectRepository.GetAll();
        }

        public void Add(Subject subject)
        {
            _ISubjectRepository.Add(subject);
        }
        public void Delete(long id)
        {
            _ISubjectRepository.Delete(id);
        }
    }
}
