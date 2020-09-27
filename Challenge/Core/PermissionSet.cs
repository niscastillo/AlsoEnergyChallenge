using AE.CoreInterface;
using Challenge;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace AE.CoreUtility
{
    public class PermissionSet : IPermissionSet
    {
        private List<string> _permissionSet;
        private readonly IDataStore _dataStore;
        public PermissionSet(IDataStore dataStore)
        {
            _dataStore = dataStore;
        }

        public void LoadPermissionSet()
        {
            _permissionSet = _dataStore.GetUserPermissionSet();
        }
        public List<string> GetPermissionSet()
        {
            return _permissionSet;
        }
        public byte[] Map()
        {
            BinaryFormatter bf = new BinaryFormatter();
            var ms = new MemoryStream();
            bf.Serialize(ms, _permissionSet);
            return ms.ToArray();
        }


    }
}
