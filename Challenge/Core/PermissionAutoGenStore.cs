using AE.CoreUtility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Challenge
{
    public class PermissionAutoGenStore : IDataStore
    {
        private List<string> _userPermissionList;

        public PermissionAutoGenStore()
        {
            _userPermissionList = new List<string>();
            GenerateUserPermissionSet();
        }

        public List<string> GetUserPermissionSet()
        {
            return _userPermissionList;
        }

        public void GenerateUserPermissionSet()
        {
            for (int a =1; a<=100; a++)
            {
                _userPermissionList.Add($"Permission{a}");
            }
        }

        public string GetUserPermissionByIndex(int index)
        {
            if (index < (_userPermissionList.Count - 1))
                return _userPermissionList[index];
            else
                return string.Empty;
        }

    }
}
