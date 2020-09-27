using AE.CoreUtility;
using ChallengeApi.Interfaces;
using System.Web.Http;

namespace ChallengeApi.Controllers
{
    public class UserController : ApiController
    {
        private readonly IUserAction _userAction;

        public UserController(IUserAction userAction)
        {
            _userAction = userAction;
        }

        public User Get(string userName)
        {            
            return _userAction.GetUserByUserName(userName);
        }
    }
}
