using AE.CoreUtility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeApi.DataStore
{
    public class UserPermissionRepository
    {
        private List<User> _permissionList = new List<User>();
        private static readonly Lazy<UserPermissionRepository> lazy = new Lazy<UserPermissionRepository>(
        () => new UserPermissionRepository());
        public static UserPermissionRepository Instance
        {
            get
            {
                return lazy.Value;
            }
        }
         public void AddNewUser(User user)
        {
            _permissionList.Add(user);
        }
        public List<User>GetPermissionList()
        {
            return _permissionList;
        }

            
    }
}