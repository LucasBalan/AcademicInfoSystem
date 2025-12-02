using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcademicInfoSystem.Domain;
using AcademicInfoSystem.Domain.Repositories;

namespace AcademicInfoSystem.Data.Repositories
{
    public abstract class SQLiteRepositoryBase
    {
        protected readonly string connectionString;

        protected SQLiteRepositoryBase()
        {
            connectionString = ConfigurationManager
                .ConnectionStrings["AcademicInfoConnection"].ConnectionString;
        }
        protected SQLiteConnection CreateConnection()
        {
            var connection = new SQLiteConnection(connectionString);
            connection.Open();
            return connection;
        }
    }
}
