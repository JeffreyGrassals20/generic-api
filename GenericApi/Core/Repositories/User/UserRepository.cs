using System.Data.SqlClient;
using GenericApi.Interfaces;
using GenericApi.Models;

namespace GenericApi.Core.Repositories;

public class UserRepository : IUserRepository
{
    private string _connectionString;

    public UserRepository(string connection)
    {
        this._connectionString = connection;
    }
    
    public async Task<Models.User> SaveUser(Models.User user)
    {
        try
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string sql = "SELECT GETDATE()";

                var command = new SqlCommand(sql, connection);
                var result = command.ExecuteNonQuery();

                return new User
                {
                    Name = result.ToString()
                };
            }
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }

       
    }
}