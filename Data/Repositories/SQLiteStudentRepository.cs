using AcademicInfoSystem.Domain;
using AcademicInfoSystem.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicInfoSystem.Data.Repositories
{
    public class SQLiteStudentRepository : SQLiteRepositoryBase, IStudentRepository
    {
        public Student GetById(long id)
        {
            string sql = "SELECT Student.UserID, Username, Password, FirstName,LastName, Role, DateOfBirth, GroupID, IsActive, CurrentYear FROM Student JOIN User ON  Student.UserID = User.UserID WHERE Student.UserID = @id AND User.Role = 'Student' ; ";

            using (var connection = CreateConnection())
            {
                
                using (var command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Student(
                                 reader.GetInt64(0),
                                 reader.GetString(1),
                                 reader.GetString(2),
                                 reader.GetString(3),
                                 reader.GetString(4),
                                 reader.GetString(5),
                                 reader.GetDateTime(6),
                                 reader.GetInt64(7),
                                 reader.GetBoolean(8),
                                 reader.GetInt32(9)

                                );

                           
                        }
                    }
                }
                return null;
            } 

        }

        public List<Student> GetAll()
        {
            string sql = "SELECT Student.UserID, Username, Password, FirstName,LastName, Role, DateOfBirth, GroupID, IsActive, CurrentYear FROM Student JOIN User ON  Student.UserID = User.UserID WHERE  User.Role = 'Student' ; ";
            List<Student> students = new List<Student>();
            using (var connection = CreateConnection())
            {
                using (var command = new SQLiteCommand(sql, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            students.Add(new Student(
                                reader.GetInt64(0),
                                 reader.GetString(1),
                                 reader.GetString(2),
                                 reader.GetString(3),
                                 reader.GetString(4),
                                 reader.GetString(5),
                                 reader.GetDateTime(6),
                                 reader.GetInt64(7),
                                 reader.GetBoolean(8),
                                 reader.GetInt32(9)

                                ));
                        }
                    }
                }
            }
            return students;
        }

        public void Add(Student student)
        {
            string insertsql = "INSERT INTO Student(UserID, GroupID, IsActive, CurrentYear) VALUES(@id, @groupId, @isActive, @currentYear);";

            using (var connection = CreateConnection())
            {
                using (var command = new SQLiteCommand(insertsql, connection))                {
                    command.Parameters.AddWithValue("@id", student.UserId);
                    command.Parameters.AddWithValue("@groupId", student.GroupId);
                    command.Parameters.AddWithValue("@isActive", student.IsActive);
                    command.Parameters.AddWithValue("@currentYear", student.CurrentYear);

                    command.ExecuteNonQuery();
                }
            }


        }
        public void Update(long studentId, long groupId)
        {
            string updatesql = "UPDATE Student SET GroupID=@groupId WHERE UserID = @studentId;";

            using (var connection = CreateConnection())
            {
                using (var command = new SQLiteCommand(updatesql, connection))
                {
                    command.Parameters.AddWithValue("@groupId", groupId);
                    command.Parameters.AddWithValue("@studentId", studentId);

                    command.ExecuteNonQuery();
                }
            }
        }
        public void Delete(long id)
        {
            string deletesql = "DELETE FROM Student WHERE UserID = @id";
            using (var connection = CreateConnection())
            {
                using (var command = new SQLiteCommand(deletesql, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
