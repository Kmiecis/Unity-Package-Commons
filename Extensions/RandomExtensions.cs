using System;

namespace Common
{
    public static class RandomExtensions
    {
        public static double NextDouble(this Random random, double min, double max)
        {
            return min + random.NextDouble() * (max - min);
        }

        public static float NextFloat(this Random random)
        {
            return random.Next() * 1.0f / int.MaxValue;
        }

        public static float NextFloat(this Random random, float min, float max)
        {
            return min + NextFloat(random) * (max - min);
        }

        public static bool NextBool(this Random random)
        {
            return random.Next(2) == 1;
        }
    }
}