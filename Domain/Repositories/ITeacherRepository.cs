using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicInfoSystem.Domain.Repositories
{
    public interface ITeacherRepository
    {
        Teacher GetById(long id);
        List<Teacher> GetAll();
        
        
        
        void Add(Teacher teacher);

        void Delete(long id);
    }
}
