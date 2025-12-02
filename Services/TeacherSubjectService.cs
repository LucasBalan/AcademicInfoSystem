using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcademicInfoSystem.Domain;
using AcademicInfoSystem.Domain.Repositories;


namespace AcademicInfoSystem.Services
{
    public class TeacherSubjectService
    {
        private readonly ITeacherSubjectRepository _ITeacherSubjectRepository;

        public TeacherSubjectService(ITeacherSubjectRepository teacherSubjectRepository)
        {
            _ITeacherSubjectRepository = teacherSubjectRepository;
        }

        public void Assign(long teacherId, long subjectId)
        {
            _ITeacherSubjectRepository.Assign(teacherId, subjectId);
        }
    }
}
