using AcademicInfoSystem.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcademicInfoSystem.Domain;

namespace AcademicInfoSystem.Services
{
    public class GroupService
    {
        private readonly IGroupRepository _IGroupRepository;
        public GroupService(IGroupRepository iGroupRepository)
        {
            _IGroupRepository = iGroupRepository;
        }

        public Group GetById(long id)
        {
            return _IGroupRepository.GetById(id);
        }
        public List<Group> GetAll()
        {
            return _IGroupRepository.GetAll(); 
        }

        public void Add(Group group)
        {
            _IGroupRepository.Add(group);
        }
       
        public void Delete(long id)
        {
            _IGroupRepository.Delete(id); 
        }
    }
}
