using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcademicInfoSystem.Data.Repositories;

namespace AcademicInfoSystem.Domain.Repositories
{
    public interface IUserRepository
    {
        User GetById(long id);
        List<User> GetAll();
        User GetByCredentials(string username, string password);

        long Add(User user);
        void Delete(long id);

    }
}
