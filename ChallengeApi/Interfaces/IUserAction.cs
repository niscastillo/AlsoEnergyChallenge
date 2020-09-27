using AE.CoreUtility;

namespace ChallengeApi.Interfaces
{
    public interface IUserAction
    {
        User GetUserByUserName(string userName);
    }
}