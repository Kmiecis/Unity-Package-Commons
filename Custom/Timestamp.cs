using System;

namespace Common
{
    public static class Timestamp
    {
        public static readonly DateTime Epoch = new DateTime(1970, 1, 1);
        
        public static float NowUtc
        {
            get { return (float)DateTime.UtcNow.Subtract(Epoch).TotalSeconds; }
        }

        public static float Now
        {
            get { return (float)DateTime.Now.Subtract(Epoch).TotalSeconds; }
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
