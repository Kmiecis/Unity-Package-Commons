using System;

namespace Common
{
    public static class DateTimeExtensions
    {
        private const int EpochWeekDayShift = 3;

        private static readonly DateTime Epoch = new DateTime(1970, 1, 1);

        public static int ToTimestamp(this DateTime self)
        {
            return (int)(self.Subtract(Epoch)).TotalSeconds;
        }

        public static int ToMidnight(this DateTime self)
        {
            return (self.ToTimestamp() / UTime.DaySeconds) * UTime.DaySeconds;
        }

        public static int ToWeekstart(this DateTime self)
        {
            return (self.ToWeekIndex() * UTime.WeekDays - EpochWeekDayShift) * UTime.DaySeconds;
        }

        public static int ToDayIndex(this DateTime self)
        {
            return ((self.ToTimestamp() / UTime.DaySeconds) % UTime.WeekDays + EpochWeekDayShift) % UTime.WeekDays;
        }

        public static int ToWeekIndex(this DateTime self)
        {
            return ((self.ToTimestamp() / UTime.DaySeconds) + EpochWeekDayShift) / UTime.WeekDays;
        }
    }
}