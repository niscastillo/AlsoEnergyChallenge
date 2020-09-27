using AE.CoreUtility;
using System.Collections.Generic;

namespace ChallengeApi.Interfaces
{
    public interface IUserDb
    {
        void AddNewUser(string username);
        User GetUserByUserName(string userName);
        List<User> GetUserList();
    }
}