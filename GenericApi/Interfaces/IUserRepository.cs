using GenericApi.Models;
namespace GenericApi.Interfaces;

public interface IUserRepository
{
    public Task<User> SaveUser(User user);
}