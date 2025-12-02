using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicInfoSystem.Domain
{
    public class GroupSubject
    {
        private long groupSubjectId;
        private long groupId;
        private long subjectId;

        public long GroupSubjectId
        {
            get { return groupSubjectId; }
            private set { groupSubjectId = value; }
        }

        public long GroupId
        {
            get { return groupId; }
            private set { groupId = value; }
        }

        public long SubjectId
        {
            get { return subjectId; }
            private set { subjectId = value; }
        }
    }
}
