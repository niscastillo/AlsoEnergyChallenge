using AE.CoreUtility;
using System.Collections.Generic;

namespace AE.CoreInterface
{
    public interface IPermissionSet
    {
        // User GenerateUserPermission(string userName);
        //User GetUserPermission(string userName);
        void LoadPermissionSet();
        List<string> GetPermissionSet();
        byte[] Map();
    }
}