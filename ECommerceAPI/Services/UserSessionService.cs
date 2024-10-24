using ECommerceAPI.Models;

namespace ECommerceAPI.Services
{
    public class UserSessionService : IUserSessionService
    {
        private UserSession _session;

        public void StartSession(int userId, string userName)
        {
            _session = new UserSession
            {
                UserId = userId,
                UserName = userName,
                LoginTime = DateTime.Now
            };
        }

        public UserSession GetSession()
        {
            return _session;
        } 
    }

}
