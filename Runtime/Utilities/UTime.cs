using UnityEngine;

namespace Common
{
    public static class UTime
    {
        public static float previousTime
            => Time.time - Time.deltaTime;

        public static float previousRealtime
            => Time.realtimeSinceStartup - Time.unscaledDeltaTime;
    }
}
