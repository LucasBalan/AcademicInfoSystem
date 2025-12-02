using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicInfoSystem.Domain
{
    public class Admin:User
    {
        public Admin(long userId,
                     string username,
                     string password,
                     string firstName,
                     string lastName,
                     string role,
                     DateTime dateOfBirth)
            : base(userId, username, password, firstName, lastName, role, dateOfBirth)
        {
        }
    }
}
