using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using AE.CoreUtility;
using Challenge;

namespace ChallengeTest
{
    public class PermissionSetTest
    {
        [Fact]
        public void TestLoadPermissionSetCanSerializeToByteArray_Pass()
        {
            PermissionSet permissionSet = new PermissionSet(new PermissionAutoGenStore());
            permissionSet.LoadPermissionSet();
            byte[] converted = permissionSet.Map();
            byte[] expected = new byte[1];
            Assert.Equal(expected.GetType(), converted.GetType());
            Assert.True(converted != null);
        }

        [Fact]
        public void TestLoadPermissionSetContains100Permissions_Pass()
        {
            PermissionSet permissionSet = new PermissionSet(new PermissionAutoGenStore());
            permissionSet.LoadPermissionSet();
            Assert.True(permissionSet.GetPermissionSet().Count == 100);
        }


    }
}
