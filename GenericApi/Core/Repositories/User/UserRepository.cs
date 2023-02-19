using GenericApi.Interfaces;

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
        return new Models.User
        {
            Name = "Jeffrey",
            LastName = this._connectionString
        };
    }
}