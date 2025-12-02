using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcademicInfoSystem.Domain;
using AcademicInfoSystem.Domain.Repositories;

namespace AcademicInfoSystem.Data.Repositories
{
    public class SQLiteTeacherRepository:SQLiteRepositoryBase, ITeacherRepository
    {
       

        public Teacher GetById(long id)
        {
            string sql = @"SELECT User.UserID,Username, Password, FirstName, LastName, Role, DateOfBirth, Department, AcademicTitle, HireDate
                               FROM User
                               JOIN Teacher ON User.UserID=Teacher.UserID
                               WHERE UserID = @id AND Role = 'Teacher'; ";
            using (var connection = CreateConnection())
            {
                using (var command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", id);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Teacher(
                            reader.GetInt64(0),
                            reader.GetString(1),
                            reader.GetString(2),
                            reader.GetString(3),
                            reader.GetString(4),
                            reader.GetString(5),
                            reader.GetDateTime(6),
                            reader.GetString(7),
                            reader.GetString(8),
                            reader.GetDateTime(9)
                            );


                        }
                    }
                }
               

            }
            return null;
        }
        public List<Teacher> GetAll()
        {
            string sql = @"SELECT User.UserID,Username, Password, FirstName, LastName, Role, DateOfBirth, Department, AcademicTitle, HireDate
                               FROM User
                               JOIN Teacher ON User.UserID=Teacher.UserID
                               WHERE Role = 'Teacher'; ";
            List<Teacher> teachers = new List<Teacher>();
            using (var connection = CreateConnection())
            {
                using (var command = new SQLiteCommand(sql, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            teachers.Add(new Teacher(
                            reader.GetInt64(0),
                            reader.GetString(1),
                            reader.GetString(2),
                            reader.GetString(3),
                            reader.GetString(4),
                            reader.GetString(5),
                            reader.GetDateTime(6),
                            reader.GetString(7),
                            reader.GetString(8),
                            reader.GetDateTime(9)
                                ));

                        }
                    }
                }
                return teachers;
            }
        }

        public void Add(Teacher teacher)
        {
            string sql = "INSERT INTO Teacher(UserID, Department, AcademicTitle, HireDate) VALUES(@id, @department, @academicTitle, @hireDate);";

            using (var connection = CreateConnection())
            {
                using(var command = new SQLiteCommand(sql,connection))
                {
                    command.Parameters.AddWithValue("@id", teacher.UserId);
                    command.Parameters.AddWithValue("@department", teacher.Department);
                    command.Parameters.AddWithValue("@academicTitle", teacher.AcademicTitle);
                    command.Parameters.AddWithValue("@hireDate", teacher.HireDate);

                    command.ExecuteNonQuery();
                }
            }
        }
        public void Delete(long id)
        {
            string deletesql = "DELETE FROM Teacher Where UserID = @id;";
            using (var connection = CreateConnection()) 
            {
              using( var command = new SQLiteCommand(deletesql,connection))
                {   
                        command.Parameters.AddWithValue("@id", id);
                         command.ExecuteNonQuery();
                }
            }
        }

    }
}
