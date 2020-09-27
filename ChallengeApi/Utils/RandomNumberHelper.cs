using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;

namespace ChallengeApi.Utils
{
    public static class RandomNumberHelper
    {
        private static int numberOfCalls = 0;
        public static int GenerateRandomNumber(int range)
        {
            Random randomGenerator = new Random(DateTime.Now.Millisecond + numberOfCalls++);
            return randomGenerator.Next(1, range);
        }

    }
}