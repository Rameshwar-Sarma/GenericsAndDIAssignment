using ECommerceAPI.Models;

namespace ECommerceAPI.Services
{
    public interface IUserSessionService
    {
        void StartSession(int userId, string userName);
        UserSession GetSession();
    }


}
