using Challenge;
using ChallengeApi.Interfaces;
using ChallengeApi.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeApi.DataStore
{
    public class PermissionDb : IPermissionDb
    {
        List<int> indexOfUsedPermissions = new List<int>();
        public List<string> SelectRandomPermissions()
        {
            PermissionAutoGenStore permissionStore = new PermissionAutoGenStore();
            int numberOfPermissions = RandomNumberHelper.GenerateRandomNumber(100);
            List<string> permissionList = new List<string>();
            for (int a = 1; a <= numberOfPermissions; a++)
            {
                var index = GetRandomUnusedIndex();
                indexOfUsedPermissions.Add(index);
                var randomPermission = permissionStore.GetUserPermissionByIndex(index - 1);
                permissionList.Add(randomPermission);
            }

            return permissionList;
        }

        private int GetRandomUnusedIndex()
        {
            int index;
            do
            {
                index = RandomNumberHelper.GenerateRandomNumber(100);
            } while (indexOfUsedPermissions.Contains(index));

            return index;
        }
    }
}