using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicInfoSystem.Domain.Repositories
{
    public interface IGroupRepository
    {
        Group GetById(long id);
        List<Group> GetAll();

        void Add(Group group);

        void Delete(long id);

    }
}
