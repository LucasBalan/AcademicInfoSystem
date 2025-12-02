using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcademicInfoSystem.Domain;
using AcademicInfoSystem.Domain.Repositories;

namespace AcademicInfoSystem.Services
{
    public class UserService
    {

        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User GetById(long id)
        {
            return _userRepository.GetById(id);
        }

        public User GetByCredentials(string username, string password)
        {
            return _userRepository.GetByCredentials(username, password);
        }

        public List<User> GetAll()
        {
            return _userRepository.GetAll();
        }
        public long Add(User user)
        {
              return _userRepository.Add(user);
        }
        public void Delete(long id)
        {
            _userRepository.Delete(id);
        }
    }
}
