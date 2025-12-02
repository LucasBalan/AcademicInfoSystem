using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcademicInfoSystem.Domain;
using AcademicInfoSystem.Domain.Repositories;

namespace AcademicInfoSystem.Services
{
    public class TeacherService
    {
        private readonly ITeacherRepository _IteacherRepository;

        public TeacherService(ITeacherRepository IteacherRepository)
        {
            _IteacherRepository = IteacherRepository;
        }

        public Teacher GetById(long id)
        {
            return _IteacherRepository.GetById(id);
        }
        public List<Teacher> GetAll()
        {
            return _IteacherRepository.GetAll();
        }

        public void Add(Teacher teacher)
        {
            _IteacherRepository.Add(teacher);
        }
        public void Delete(long id)
        {
            _IteacherRepository.Delete(id);
        }
    }
}
