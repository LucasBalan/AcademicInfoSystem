using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcademicInfoSystem.Domain;
using AcademicInfoSystem.Domain.Repositories;

namespace AcademicInfoSystem.Services
{
    public class GradeService
    {
        private readonly IGradeRepository _gradeRepository;

        public GradeService(IGradeRepository gradeRepository)
        {
            _gradeRepository = gradeRepository;
        }

        public  List<Grade> GetByStudentId(long studentId)
        {
            List<Grade> grades = _gradeRepository.GetByStudentId(studentId);

                return grades;
            
        }

        public List<Grade> GetByTeacherAndSubject(long teacherId, long subjectId)
        {
            List<Grade> grades = _gradeRepository.GetByTeacherAndSubject(teacherId, subjectId);
            return grades;
        }

        public void AddGrade(Grade grade)
        {
           _gradeRepository.Add(grade);
        }
        public void UpdateGrade(Grade grade)
        {
            _gradeRepository.Update(grade);
        }
        public void DeleteGrade(long gradeId)
        { _gradeRepository.Delete(gradeId);}
    }
}
