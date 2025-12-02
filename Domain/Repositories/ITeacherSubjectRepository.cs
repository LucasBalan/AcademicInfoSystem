using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicInfoSystem.Domain.Repositories
{
    public interface ITeacherSubjectRepository
    {
        void Assign(long teacherId, long subjectId);

    }
}
