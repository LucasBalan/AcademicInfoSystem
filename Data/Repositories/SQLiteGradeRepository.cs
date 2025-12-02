using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcademicInfoSystem.Domain;
using AcademicInfoSystem.Domain.Repositories;
using Microsoft.SqlServer.Server;

namespace AcademicInfoSystem.Data.Repositories
{
    public class SQLiteGradeRepository:SQLiteRepositoryBase, IGradeRepository
    {

        public Grade GetById(long id)
        {
            string sql = "SELECT GradeID, SubjectID, StudentID, TeacherID, GradeValue, GradeDate FROM Grade WHERE GradeID = @id; ";

            using (var connection = CreateConnection())
            {
                using (var command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue ("id", id);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Grade(
                                   reader.GetInt64(0),
                                   reader.GetInt64(1),
                                   reader.GetInt64(2),
                                   reader.GetInt64(3),
                                   reader.GetDouble(4),
                                   reader.GetDateTime(5)
                                );
                        }
                    }
                }

            }
            return null;
        }
        public List<Grade> GetByStudentId(long id)
        {
            List<Grade> grades = new List<Grade>(); 
            string sql = "SELECT GradeID, SubjectID, StudentID, TeacherID, GradeValue, GradeDate FROM Grade WHERE StudentID=@id; ";

            using (var connection = CreateConnection())
            {
                using (var command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            grades.Add( new Grade(
                                   reader.GetInt64(0),
                                reader.GetInt64(1),
                                reader.GetInt64(2),
                                reader.GetInt64(3),
                                reader.GetDouble(4),
                                reader.GetDateTime(5)
                                ));
                        }
                    }

                }
            }
            return grades;
        }
        public List<Grade> GetByTeacherAndSubject(long teacherId, long subjectId)
        {
            List<Grade> grades = new List<Grade>();
            string sql = "SELECT GradeID, SubjectID, StudentID, TeacherID, GradeValue, GradeDate FROM Grade WHERE TeacherID=@teacherid AND SubjectID=@subjectid; ";

            using (var connection = CreateConnection())
            {
                using (var command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@teacherid", teacherId);
                    command.Parameters.AddWithValue("@subjectid", subjectId);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            grades.Add(new Grade(
                                   reader.GetInt64(0),
                                reader.GetInt64(1),
                                reader.GetInt64(2),
                                reader.GetInt64(3),
                                reader.GetDouble(4),
                                reader.GetDateTime(5)
                                ));
                        }
                    }

                }
            }
            return grades;
        }
        public List<Grade> GetAll()
        {
            string sql = "SELECT GradeID, SubjectID, StudentID, TeacherID, GradeValue, GradeDate FROM Grade; ";
            List<Grade> grades = new List<Grade>();
            using (var connection = CreateConnection())
            {
                using(var command = new SQLiteCommand(sql, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            grades.Add(new Grade(
                                reader.GetInt64(0), 
                                reader.GetInt64(1),
                                reader.GetInt64(2),
                                reader.GetInt64(3),
                                reader.GetDouble(4),
                                reader.GetDateTime(5)
                                ));
                        }
                    }
                }
            }
            return grades;
        }
        public void Add(Grade grade)
        {
            string sql = "INSERT INTO Grade(SubjectID, StudentID, TeacherID, GradeValue, GradeDate) VALUES(@subjectId, @studentId, @teacherId, @gradeValue, @gradeDate) ";

            using (var connection = CreateConnection())
            {
                using (var command = new SQLiteCommand(sql, connection))
                {
 
                            command.Parameters.AddWithValue("@subjectId", grade.SubjectId);
                            command.Parameters.AddWithValue("@studentId", grade.StudentId);
                            command.Parameters.AddWithValue("@teacherId", grade.TeacherId);
                            command.Parameters.AddWithValue("@gradeValue", grade.GradeValue);
                            command.Parameters.AddWithValue("@gradeDate", grade.Date);

                            command.ExecuteNonQuery();
        
                }
            }
        }

        public void Update(Grade grade)
        {
            string updatesql = "UPDATE Grade SET StudentID = @studentId, TeacherID = @teacherId, SubjectID = @subjectId, GradeValue = @gradeValue, GradeDate=@date WHERE GradeID = @id; ";
            using (var connection = CreateConnection())
            using (var command = new SQLiteCommand(updatesql, connection))
            {
                command.Parameters.AddWithValue("@id", grade.GradeId);
                command.Parameters.AddWithValue("@studentId", grade.StudentId);
                command.Parameters.AddWithValue("@teacherId", grade.TeacherId);
                command.Parameters.AddWithValue("@subjectId", grade.SubjectId);
                command.Parameters.AddWithValue("@gradeValue", grade.GradeValue);
                command.Parameters.AddWithValue("@date", grade.Date);

                command.ExecuteNonQuery();
            }
        }

        public void Delete(long id) 
        {
            string deletesql = "DELETE FROM Grade WHERE GradeID = @id; ";
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
