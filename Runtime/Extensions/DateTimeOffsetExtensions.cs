using System;

namespace Common
{
    public static class DateTimeOffsetExtensions
    {
        public static long ToUnixTimeMidnight(this DateTimeOffset self)
        {
            return (self.ToUnixTimeSeconds() / UTime.DaySeconds) * UTime.DaySeconds;
        }
    }
}