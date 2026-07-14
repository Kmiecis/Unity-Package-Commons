using UnityEngine;

namespace Common
{
    public static class UTime
    {
        public const int MinuteSeconds = 60;
        public const int HourMinutes = 60;
        public const int DayHours = 24;
        public const int WeekDays = 7;

        public const int HourSeconds = HourMinutes * MinuteSeconds;
        public const int DaySeconds = DayHours * HourSeconds;
        public const int WeekSeconds = WeekDays * DaySeconds;

        public const int DayMinutes = DayHours * HourMinutes;
        public const int WeekMinutes = WeekDays * DayMinutes;

        public const int WeekHours = WeekDays * DayHours;

        private const int EpochWeekDayShift = 3;

        public static float previousTime
            => Time.time - Time.deltaTime;

        public static float previousRealtime
            => Time.realtimeSinceStartup - Time.unscaledDeltaTime;

        public static int ToDayStart(int timestamp)
        {
            return (timestamp / DaySeconds) * DaySeconds;
        }

        public static int ToDayEnd(int timestamp)
        {
            return ToDayStart(timestamp) + DaySeconds;
        }

        public static int ToDayIndex(int timestamp)
        {
            return ((timestamp / DaySeconds) % WeekDays + EpochWeekDayShift) % WeekDays;
        }

        public static int ToWeekStart(int timestamp)
        {
            return (ToWeekIndex(timestamp) * WeekDays - EpochWeekDayShift) * DaySeconds;
        }

        public static int ToWeekEnd(int timestamp)
        {
            return ToWeekStart(timestamp) + WeekSeconds;
        }

        public static int ToWeekIndex(int timestamp)
        {
            return ((timestamp / DaySeconds) + EpochWeekDayShift) / WeekDays;
        }
    }
}
