namespace GenericApi.Interfaces;
using GenericApi.Models;
public interface IUserService
{
    public Task<string> SaveUserAsync(User user);
}