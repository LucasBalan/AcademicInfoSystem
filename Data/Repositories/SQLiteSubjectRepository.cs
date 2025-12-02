using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcademicInfoSystem.Domain;
using AcademicInfoSystem.Domain.Repositories;

namespace AcademicInfoSystem.Data.Repositories
{
    public class SQLiteSubjectRepository:SQLiteRepositoryBase, ISubjectRepository
    {
        public Subject GetById(long id)
        {
            string sql = "SELECT SubjectID, Name, Language, ClassNumber FROM Subject WHERE SubjectID = @id; ";

            using (var connection = CreateConnection())
            {
                using (var command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    using (var reader = command.ExecuteReader())
                    {

                        if (reader.Read())
                                {
                            return new Subject(
                                   reader.GetInt64(0),
                                   reader.GetString(1),
                                   reader.GetString(2),
                                   reader.GetString(3)
                                );
                             
                                }
                    }
                }
            }
            return null;
        }

        public List<Subject> GetAll()
        {
            List<Subject> subjects = new List<Subject>();
            string sql = "SELECT SubjectID, Name, Language, ClassNumber FROM Subject;   ";

            using (var connection = CreateConnection())
            {
                using (var command = new SQLiteCommand(sql, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            subjects.Add(new Subject(
                                reader.GetInt64(0),
                                reader.GetString(1),
                                reader.GetString(2),
                                reader.GetString(3)

                                ));
                        }
                    }
                }
            }
                return subjects;
            
        }

        public List<Subject> GetByTeacherId(long id)
        {
            List<Subject> subjects = new List<Subject>();
            string sql = "SELECT Subject.SubjectID, Name, Language, ClassNumber FROM Subject JOIN TeacherSubject ON Subject.SubjectID = TeacherSubject.SubjectID WHERE TeacherSubject.UserID = @id;  ";

            using (var connection = CreateConnection())
            {
                using (var command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            subjects.Add(new Subject(
                                reader.GetInt64(0),
                                reader.GetString(1),
                                reader.GetString(2),
                                reader.GetString(3)

                                ));
                        }
                    }
                }
            }
            return subjects;
        }   
        public void Add(Subject subject)
        {
            string insertsql = "INSERT INTO Subject(Name,Language,ClassNumber) VALUES(@name, @language, @classnumber);";
            using (var connection = CreateConnection())
            {
                using (var command = new SQLiteCommand(insertsql, connection))
                {
                    command.Parameters.AddWithValue("@name", subject.Name);
                    command.Parameters.AddWithValue("@language", subject.Language);
                    command.Parameters.AddWithValue("@classnumber", subject.Classnumber);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void Delete(long id)
        {
            string deletesql = "DELETE FROM Subject WHERE SubjectID = @id;";
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
