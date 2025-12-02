using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicInfoSystem.Domain.Repositories
{
    public interface IGroupSubjectRepository
    {
        void Assign(long subjectId, long groupId);
    }
}
