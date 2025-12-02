using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcademicInfoSystem.Domain;
using AcademicInfoSystem.Domain.Repositories;

namespace AcademicInfoSystem.Services
{
    public class LoginService
    {
        private readonly IUserRepository userRepository;

        public LoginService(IUserRepository repo) 
        {
          userRepository = repo;
        }

        public User Login(string username, string password)
        {
           var user = userRepository.GetByCredentials(username, password);
            if (user == null)
            {
                return null;
            }
            else
            {
                return user;
            }
        }
    }
}
