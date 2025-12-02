using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicInfoSystem.Domain
{
    public class Group
    {
        private long groupId;
        private int totalStudents;

        public Group(long groupId, int totalStudents)
        {
            GroupId = groupId;
            TotalStudents = totalStudents;

        }
        public long GroupId
        { 
          get { return groupId; }
          private set { groupId = value; }
        }

        public int TotalStudents
        {
            get { return totalStudents; }
            private set { totalStudents = value; }
        }
    }
}
