using ECommerceAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserSessionController : ControllerBase
    {
        private readonly IUserSessionService _userSessionService;

        public UserSessionController(IUserSessionService userSessionService)
        {
            _userSessionService = userSessionService;
        }
        /// <summary>
        /// This Method starts User Session
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="userName"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult StartSession(int userId, string userName)
        {
            _userSessionService.StartSession(userId, userName);
            return Ok();
        }
        /// <summary>
        /// THis methos gets the cureent user.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetSession()
        {
            return Ok(_userSessionService.GetSession());
        } 
    }

}
