using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicInfoSystem.Domain.Repositories
{
    public interface IStudentRepository
    {
        Student GetById(long id);
     
        List<Student> GetAll();

        

        void Add(Student student);

        void Update(long studentId, long groupId);
        void Delete(long id);

    }
}
