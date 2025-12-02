using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AcademicInfoSystem.Domain;
using AcademicInfoSystem.Domain.Repositories;

namespace AcademicInfoSystem.Data.Repositories
{
    public class SQLiteUserRepository : SQLiteRepositoryBase, IUserRepository
    {
        string sql = @"SELECT UserID, Username, Password, FirstName, LastName, Role, DateOfBirth
                               FROM User
                               WHERE UserID = @id";

        public User GetById(long id)
        {
            using (var connection = CreateConnection())
            {


                using (var command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new User
                            (
                                reader.GetInt64(0),
                                reader.GetString(1),
                                reader.GetString(2),
                                reader.GetString(3),
                                reader.GetString(4),
                                reader.GetString(5),
                                reader.GetDateTime(6)
                            );


                        }
                    }
                }
                return null;
            }
        }

        public User GetByCredentials(string username, string password)
        {
            string credentialssql = @"SELECT UserID,Username, Password, FirstName, LastName, Role, DateOfBirth
                               FROM User
                               WHERE Username = @u AND Password = @p ";
            using (var connection = CreateConnection())
            {
                using (var command = new SQLiteCommand(credentialssql, connection))
                {
                    command.Parameters.AddWithValue("@u", username);
                    command.Parameters.AddWithValue("@p", password);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new User(
                                   reader.GetInt64(0),
                                   reader.GetString(1),
                                   reader.GetString(2),
                                   reader.GetString(3),
                                   reader.GetString(4),
                                   reader.GetString(5),
                                   reader.GetDateTime(6)
                                );
                        }
                    }
                }
            }
            return null;
        }

        public List<User> GetAll()
        {
            List<User> users = new List<User>();
            string sql2 = @"SELECT UserID, Username, Password, FirstName, LastName, Role, DateOfBirth
                               FROM User";
            using (var connection = CreateConnection())
            {
                using (var command = new SQLiteCommand(sql2, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            users.Add(new User(
                              reader.GetInt64(0),
                              reader.GetString(1),
                              reader.GetString(2),
                              reader.GetString(3),
                              reader.GetString(4),
                              reader.GetString(5),
                              reader.GetDateTime(6)

                                ));
                        }
                    }
                }
            }
            return users;
        }

        public long Add(User user)
        {
            string insertsql = @"
    INSERT INTO User (Username, Password, FirstName, LastName, Role, DateOfBirth)
    VALUES (@username, @password, @firstName, @lastName, @role, @dob);
    SELECT last_insert_rowid();";
            using (var connection = CreateConnection())
            {
                using (var command = new SQLiteCommand(insertsql, connection))
                {
                    command.Parameters.AddWithValue("@username", user.Username);
                    command.Parameters.AddWithValue("@password", user.Password);
                    command.Parameters.AddWithValue("@firstName", user.FirstName);
                    command.Parameters.AddWithValue("@lastName", user.LastName);
                    command.Parameters.AddWithValue("@role", user.Role);
                    command.Parameters.AddWithValue("@dob", user.DateOfBirth);

                   

                    long id = (long)command.ExecuteScalar();
                    return id;
                }
            }
        }

        public void Delete(long id)
        {
            using (var connection = CreateConnection())
            {
                string deletesql = "DELETE FROM User WHERE UserID = @id ";
                using(var command = new SQLiteCommand(deletesql, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
            }

        } 
    }
}
    

