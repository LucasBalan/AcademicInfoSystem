using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AcademicInfoSystem.Domain
{
    public class User
    {
        private long userId;
        private string username;
        private string password;
        private string firstName;
        private string lastName;
        private string role;
        private DateTime dateOfBirth;

        public User(long userid, string username, string password, string firstName, string lastName, string role, DateTime dateofbirth)
        {
            UserId = userid;
            Username = username;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
            Role = role;
            DateOfBirth = dateofbirth;

        }
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }
        public User(string username, string password, string firstName, string lastName, string role, DateTime dateofbirth)
        {
            
            Username = username;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
            Role = role;
            DateOfBirth = dateofbirth;

        }

   
        public long UserId
        {
            get { return userId; }
            protected set { userId = value; }
        }

        public string Username
        {
            get { return username; }
            protected set { username = value; }
        }

        public string Password
        {
           get { return password; }
           protected set { password = value; }
        }

        public string FirstName
        {
            get { return firstName; }   
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string Role
        {
            get { return role; }
            protected set { role = value; }
        }
        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        

    }
}
