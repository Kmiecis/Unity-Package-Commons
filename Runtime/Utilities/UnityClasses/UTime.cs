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

        public static float previousTime
            => Time.time - Time.deltaTime;

        public static float previousRealtime
            => Time.realtimeSinceStartup - Time.unscaledDeltaTime;
    }
}
