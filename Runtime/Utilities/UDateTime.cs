using System;

namespace Common
{
    public static class UDateTime
    {
        private static readonly DateTime Epoch = new DateTime(1970, 1, 1);

        public static DateTime ToDateTime(int timestamp)
        {
            return Epoch.AddSeconds(timestamp);
        }
    }
}