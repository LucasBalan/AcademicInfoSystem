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
    public class SQLiteGroupSubjectRepository:SQLiteRepositoryBase, IGroupSubjectRepository
    {
        public void Assign(long subjectId, long groupId)
        {
            string sql = "INSERT INTO GroupSubject(SubjectID, GroupID) Values(@subjectId, @groupId); ";

            using (var connection = CreateConnection())
            {
                using (var command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@subjectId", subjectId);
                    command.Parameters.AddWithValue("@groupId", groupId);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
