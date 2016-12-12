using UraEsewaApp.Models;

namespace UraEsewaApp.Services.Abstract
{
    public interface IUserService : IServiceCommand<User>
    {
        bool CheckLogin(User user);
    }
}