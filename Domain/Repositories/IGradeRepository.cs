using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicInfoSystem.Domain.Repositories
{
    public interface IGradeRepository
    {
        Grade GetById(long id);

        List<Grade> GetAll();
        List<Grade> GetByStudentId(long studentId);

        List<Grade> GetByTeacherAndSubject(long teacherId, long subjectId);
        void Add(Grade grade);
        void Update(Grade grade);
        void Delete(long id);
    }
}
