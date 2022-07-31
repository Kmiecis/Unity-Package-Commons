using UnityEngine;

namespace Common
{
    public static class TimeUtility
    {
        public static float GetTime(bool unscaled)
        {
            return unscaled ? Time.unscaledTime : Time.time;
        }

        public static float GetDeltaTime(bool unscaled)
        {
            return unscaled ? Time.unscaledDeltaTime : Time.deltaTime;
        }

        public static float GetFixedTime(bool unscaled)
        {
            return unscaled ? Time.fixedUnscaledTime : Time.fixedTime;
        }

        public static float GetFixedDeltaTime(bool unscaled)
        {
            return unscaled ? Time.fixedUnscaledDeltaTime : Time.fixedDeltaTime;
        }
    }
}
