using AcademicInfoSystem.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicInfoSystem.Data.Repositories
{
    public class SQLiteTeacherSubjectRepository:SQLiteRepositoryBase, ITeacherSubjectRepository
    {
        public void Assign(long teacherId, long subjectId)
        {
            string sql = "INSERT INTO TeacherSubject(UserID, SubjectID) VALUES(@userId,@subjectId);";

            using (var connection = CreateConnection())
            {
                using (var command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@userId", teacherId);
                    command.Parameters.AddWithValue("@subjectId", subjectId);
                    command.ExecuteNonQuery();
                }
            }
        }

    }
}
