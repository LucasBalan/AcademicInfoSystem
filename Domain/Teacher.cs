using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicInfoSystem.Domain
{
    public class Teacher : User
    {
        private string department;
        private string academicTitle;
        private DateTime hireDate;

        public Teacher(
       long userId,
       string username,
       string password,
       string firstName,
       string lastName,
       string role,
       DateTime dateOfBirth,
       string department,
       string academicTitle,
       DateTime hireDate
   )
       : base(userId, username, password, firstName, lastName, role, dateOfBirth)
        {
            Department = department;
            AcademicTitle = academicTitle;
            HireDate = hireDate;
        }
        public string Department
        { 
          get { return department; } 
          protected set { department = value; } 
        }

        public string AcademicTitle
        { 
          get { return academicTitle; } 
          protected set { academicTitle = value; } 
        }

        public DateTime HireDate
        { get { return hireDate; }
          private set { hireDate = value; }
        }
    }
}
