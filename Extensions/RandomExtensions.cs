using System;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

namespace Common.Extensions
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
            return random.NextFloat() * max;
        }

        public static float NextFloat(this Random random, float min, float max)
        {
            return min + random.NextFloat() * (max - min);
        }

        public static bool NextBool(this Random random)
        {
            return random.NextDouble() > 0.5;
        }

        public static byte NextByte(this Random random)
        {
            return (byte)random.Next(256);
        }

        public static byte NextByte(this Random random, byte max)
        {
            return (byte)random.Next(max);
        }

        public static byte NextByte(this Random random, byte min, byte max)
        {
            return (byte)random.Next(min, max);
        }

        public static Vector2 NextUnitVector2(this Random random)
        {
            var angle = random.NextFloat() * Mathx.PI_DOUBLE;
            return new Vector2(
                Mathf.Cos(angle),
                Mathf.Sin(angle)
            );
        }

        public static Vector2 NextVector2(this Random random)
        {
            return new Vector2(
                random.NextFloat(),
                random.NextFloat()
            );
        }

        public static Vector2 NextVector2(this Random random, Vector2 max)
        {
            return new Vector2(
                random.NextFloat(max.x),
                random.NextFloat(max.y)
            );
        }

        public static Vector2 NextVector2(this Random random, Vector2 min, Vector2 max)
        {
            return new Vector2(
                random.NextFloat(min.x, max.x),
                random.NextFloat(min.y, max.y)
            );
        }

        public static Vector3 NextUnitVector3(this Random random)
        {
            var theta = random.NextFloat() * Mathx.PI_DOUBLE;
            var omega = random.NextFloat() * Mathx.PI_DOUBLE;
            var t = Mathf.Acos(omega * Mathx.PI_INV - 1.0f);
            return new Vector3(
                Mathf.Sin(t) * Mathf.Cos(theta),
                Mathf.Sin(t) * Mathf.Sin(theta),
                Mathf.Cos(t)
            );
        }

        public static Vector3 NextVector3(this Random random)
        {
            return new Vector3(
                random.NextFloat(),
                random.NextFloat(),
                random.NextFloat()
            );
        }

        public static Vector3 NextVector3(this Random random, Vector3 max)
        {
            return new Vector3(
                random.NextFloat(max.x),
                random.NextFloat(max.y),
                random.NextFloat(max.z)
            );
        }

        public static Vector3 NextVector3(this Random random, Vector3 min, Vector3 max)
        {
            return new Vector3(
                random.NextFloat(min.x, max.x),
                random.NextFloat(min.y, max.y),
                random.NextFloat(min.z, max.z)
            );
        }

        public static Color32 NextColor(this Random random)
        {
            return new Color32(
                random.NextByte(),
                random.NextByte(),
                random.NextByte(),
                random.NextByte()
            );
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
