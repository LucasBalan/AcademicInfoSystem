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
    public class SQLiteGroupRepository:SQLiteRepositoryBase, IGroupRepository
    {
        public Group GetById(long id)
        {
            string sql = "SELECT GroupID, TotalStudents FROM [Group] WHERE GroupID = @id; ";

            using (var connection = CreateConnection())
            {
                using (var command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("id", id);  
                    using (var reader = command.ExecuteReader())
                    {
                        if(reader.Read())
                        {
                            return new Group(
                                reader.GetInt64(0),
                                reader.GetInt32(1)
                            
                                );
                        }
                    }
                }


            }
            return null;
        }

        public List<Group> GetAll()
        {
            string sql = "SELECT GroupID, TotalStudents FROM [Group];";
            List<Group> groups = new List<Group>(); 
            using (var connection = CreateConnection())
            {
                using (var command = new SQLiteCommand(sql, connection))
                {

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            groups.Add(new Group(
                                reader.GetInt64(0),
                                reader.GetInt32(1)

                                ));
                        }
                    }
                }


            }
            return groups;
        }

        public void Add(Group group)
        {
            string addsql = "INSERT INTO [Group](TotalStudents) VALUES(@totalStudents);";
            using (var connection = CreateConnection())
            {
                using(var command = new SQLiteCommand(addsql, connection) )
                {
                    command.Parameters.AddWithValue("@totalStudents", group.TotalStudents);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Delete(long id)
        {
            string deletesql = "DELETE FROM [Group] WHERE GroupID= @id;";
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

