using AE.CoreUtility;
using System;
using System.Collections.Generic;
using System.Linq;
using ChallengeApi.Interfaces;
using System.Web.UI;

namespace ChallengeApi.DataStore
{
    public sealed class UserDb : IUserDb
    {
        private readonly IColorDb _colorDb;
        private readonly IPermissionDb _permissionDb;

        private List<User> _userList;
        
    
        public UserDb(IColorDb colorDb, IPermissionDb permissionDb)
        {
            _colorDb = colorDb;
            _permissionDb = permissionDb;
            _userList = new List<User>();
        }
        public List<User> GetUserList()
        {
            return UserPermissionRepository.Instance.GetPermissionList();
        }
        public void AddNewUser(string username)
        {
            User user = new User() 
            {
                CreateDate = DateTime.Now,
                FavoriteColor = _colorDb.SelectRandomColor(), 
                UserName = username,  
                PermissionList = _permissionDb.SelectRandomPermissions() 
            };
            UserPermissionRepository.Instance.AddNewUser(user);
        }

        public User GetUserByUserName(string userName)
        {
            var user = UserPermissionRepository.Instance.GetPermissionList().Where(x => x.UserName == userName).FirstOrDefault();
            return user;

        }
    }
}
