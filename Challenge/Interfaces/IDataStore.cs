using AE.CoreUtility;
using System.Collections.Generic;

namespace Challenge
{
    public interface IDataStore
    {
        List<string> GetUserPermissionSet();
        void GenerateUserPermissionSet();
        string GetUserPermissionByIndex(int index);
    }
}
