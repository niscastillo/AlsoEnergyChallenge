using AE.CoreUtility;
using ChallengeApi.Interfaces;

namespace ChallengeApi.ActionClasses
{
    public class UserAction : IUserAction
    {
        private readonly IUserDb _userDb;
        public UserAction(IUserDb userDb)
        {
            _userDb = userDb;
        }

        public User GetUserByUserName(string userName)
        {
            var user = _userDb.GetUserByUserName(userName);
            if (user == null)
            {
                _userDb.AddNewUser(userName);
            }
            user = _userDb.GetUserByUserName(userName);
            return user;
        }
    }
}
