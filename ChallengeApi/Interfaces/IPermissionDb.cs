using System.Collections.Generic;

namespace ChallengeApi.Interfaces
{
    public interface IPermissionDb
    {
        List<string> SelectRandomPermissions();
    }
}