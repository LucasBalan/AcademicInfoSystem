using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicInfoSystem.Domain
{
    public class TeacherSubject
    {
        private long teacherSubjectId;
        private long userId;
        private long subjectId;

        public long TeacherSubjectId
        {
            get { return teacherSubjectId; }
            set { teacherSubjectId = value; }
        }
        public long UserId
        { get { return userId; } private set { userId = value; } }

        public long SubjectId {  get { return subjectId; } private set { subjectId = value; } }
    }
}
