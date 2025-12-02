using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicInfoSystem.Domain.Repositories
{
    public interface ISubjectRepository
    { 
        Subject GetById(long id);

        List<Subject> GetAll();
        List<Subject> GetByTeacherId(long id);

        void Add(Subject subject);
     
        void Delete(long id);
        
    }
}
