using System;

namespace Common
{
    public static class Timestamp
    {
        public static readonly DateTime Epoch = new DateTime(1970, 1, 1);
        
        public static int NowUtc
        {
            get { return ToTimestamp(DateTime.UtcNow); }
        }

        public static int Now
        {
            get { return ToTimestamp(DateTime.Now); }
        }

        public static int ToTimestamp(DateTime date)
        {
            return (int)(date.Subtract(Epoch)).TotalSeconds;
        }

        public static DateTime ToDateTime(int timestamp)
        {
            return Epoch.AddSeconds(timestamp);
        }
    }
}
