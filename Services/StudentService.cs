using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcademicInfoSystem.Domain;
using AcademicInfoSystem.Domain.Repositories;

namespace AcademicInfoSystem.Services
{
    public class StudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public Student GetById(long id)
        {
            return _studentRepository.GetById(id);
        }

        public List<Student> GetAll()
        {
            return _studentRepository.GetAll();
        }
        public void Add(Student student)
        {
            _studentRepository.Add(student);
        }

        public void Delete(long id)
        {
            _studentRepository.Delete(id);
        }

        public void Update(long studentId, long groupid)
        {
            _studentRepository.Update(studentId, groupid);
        }

    }
}
