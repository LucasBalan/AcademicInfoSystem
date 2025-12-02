using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcademicInfoSystem.Domain;
using AcademicInfoSystem.Domain.Repositories;


namespace AcademicInfoSystem.Services
{
    public class GroupSubjectService
    {
        private readonly IGroupSubjectRepository _groupSubjectRepository;

        public GroupSubjectService(IGroupSubjectRepository groupSubjectRepository)
        {
           _groupSubjectRepository = groupSubjectRepository;
        }

        public void Assign(long subjectId, long groupId)
        {
            _groupSubjectRepository.Assign(subjectId, groupId);
        }
    }
}
