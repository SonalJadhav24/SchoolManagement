using School.Management.Core;
using School.Management.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace School.Management.Data
{
    public class ClassRepository : Core.Repository.IClassRepository
    {
        SqlConnection sqlConnection = null;
        public Task<Class> Add(Class TEntity)
        {
            throw new NotImplementedException();
        }

        public Task<Class> Delete(int TEntity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
         
        }

        public async Task<List<Class>> GetAllAsync(int id)
        {
            try
            {
                string connectionString = "Server=DESKTOP-OUCK1GJ\\SQLEXPRESS;Database=SchoolManagement;Trusted_Connection=True;";
                // var connectionstring = ConfigurationManager.AppSettings["SqlConnection"];               
                sqlConnection = new SqlConnection(connectionString);
                await sqlConnection.OpenAsync();
                SqlCommand sqlcommand = new SqlCommand("SelectAllClasses", sqlConnection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                DataTable table = new DataTable();
                table.Load(await sqlcommand.ExecuteReaderAsync());
                List<Class> classes = new List<Class>(); 
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    var row = table.Rows[i];
                    var temp = new Class()
                    {
                       ClassID = Convert.ToInt32(row["Id"]),
                       ClassName = row["Name"].ToString()
                    };
                    classes.Add(temp);
                }
                await sqlConnection.CloseAsync();
                return classes;
            }
            catch (Exception ex)
            {
                return null;

            }
         
        }

        public Task<Class> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Class> Update(Class TEntity)
        {
            throw new NotImplementedException();
        }
    }
}
