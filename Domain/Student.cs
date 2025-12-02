using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademicInfoSystem.Domain
{
    public class Student : User
    {
        private long groupId;
        private bool isActive;
        private int currentYear;

        public Student(
       long userId,
       string username,
       string password,
       string firstName,
       string lastName,
       string role,
       DateTime dateOfBirth,
       long groupId,
       bool isActive,
       int currentYear
   )
       : base(userId, username, password, firstName, lastName, role, dateOfBirth)
        {
           GroupId = groupId;
           IsActive = isActive;
           CurrentYear = currentYear;
        }

      
        public long GroupId
        {
            get { return groupId; }
            protected set { groupId = value; }
        }

        public bool IsActive
        {
            get { return isActive; }
            protected set { isActive = value; }
        }
        public int CurrentYear
        {
            get { return currentYear; }
            protected set { currentYear = value; }
        }
    }
}
