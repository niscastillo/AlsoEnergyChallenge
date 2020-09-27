using AE.CoreUtility;
using System;
using System.Collections.Generic;
using System.Text;

namespace AE.CoreUtility
{
    public class User
    {

        public string UserName { get; set; }
        public DateTime CreateDate { get; set; }
        public List<string> PermissionList { get; set; }
        public string FavoriteColor { get; set; }
        
    }
}
