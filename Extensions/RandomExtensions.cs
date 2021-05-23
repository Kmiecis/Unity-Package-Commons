using System;
using System.Collections.Generic;

namespace Common
{
    public static class RandomExtensions
    {
        public static double NextDouble(this Random random, double max)
        {
            return random.NextDouble() * max;
        }

        public static double NextDouble(this Random random, double min, double max)
        {
            return min + random.NextDouble() * (max - min);
        }

        public static float NextFloat(this Random random)
        {
            return (float)random.NextDouble();
        }

        public static float NextFloat(this Random random, float max)
        {
            return (float)random.NextDouble() * max;
        }

        public static float NextFloat(this Random random, float min, float max)
        {
            return min + random.NextFloat() * (max - min);
        }

        public static bool NextBool(this Random random)
        {
            return random.Next(2) == 1;
        }

        public static byte NextByte(this Random random)
        {
            return (byte)random.Next(256);
        }

        public static byte NextByte(this Random random, int max)
        {
            return (byte)random.Next(max);
        }

        public static byte NextByte(this Random random, int min, int max)
        {
            return (byte)random.Next(min, max);
        }

        public static TEnum NextEnum<TEnum>(this Random random)
        {
            var values = Enum.GetValues(typeof(TEnum));
            return (TEnum)values.GetValue(random.Next(values.Length));
        }

        public static T NextItem<T>(this Random random, List<T> list)
        {
            return list[random.Next(list.Count)];
        }

        public static T NextItem<T>(this Random random, params T[] args)
        {
            return args[random.Next(args.Length)];
        }

        public static void Shuffle<T>(this Random random, List<T> list)
        {
            int n = list.Count;
            while (n-- > 1)
            {
                int k = random.Next(n);
                list.Swap(k, n);
            }
        }

        public static void Shuffle<T>(this Random random, params T[] args)
        {
            int n = args.Length;
            while (n-- > 1)
            {
                int k = random.Next(n);
                args.Swap(k, n);
            }
        }
    }
}