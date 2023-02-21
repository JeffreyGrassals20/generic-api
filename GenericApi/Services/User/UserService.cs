using GenericApi.Interfaces;

namespace GenericApi.Services.User;

public class UserService : IUserService
{
    private IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    
    public async Task<string> SaveUserAsync(Models.User user)
    {
        var result = await this._userRepository.SaveUser(user);
        return result.Name;
    }
}