using System;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

namespace Common
{
    public static class RandomExtensions
    {
        public static double NextDouble(this Random self, double max)
        {
            return self.NextDouble() * max;
        }

        public static double NextDouble(this Random self, double min, double max)
        {
            return min + self.NextDouble() * (max - min);
        }

        public static float NextFloat(this Random self)
        {
            return (float)self.NextDouble();
        }

        public static float NextFloat(this Random self, float max)
        {
            return self.NextFloat() * max;
        }

        public static float NextFloat(this Random self, float min, float max)
        {
            return min + self.NextFloat() * (max - min);
        }

        public static bool NextBool(this Random self, double p = 0.5)
        {
            return self.NextDouble() > p;
        }

        public static int NextSign(this Random self, double p = 0.5)
        {
            return self.NextBool(p) ? +1 : -1;
        }

        public static int NextUnit(this Random self)
        {
            return self.Next(2);
        }

        public static byte NextByte(this Random self)
        {
            return (byte)self.Next(256);
        }

        public static byte NextByte(this Random self, byte max)
        {
            return (byte)self.Next(max);
        }

        public static byte NextByte(this Random self, byte min, byte max)
        {
            return (byte)self.Next(min, max);
        }

        public static long NextLong(this Random self, long min, long max)
        {
            var value = self.NextDouble();
            var range = (ulong)(max - min);
            return (long)(value * range + min);
        }

        public static long NextLong(this Random self, long max)
        {
            return self.NextLong(long.MinValue, max);
        }

        public static long NextLong(this Random self)
        {
            return self.NextLong(long.MaxValue);
        }

        /// <summary> Calculates Gaussian number sample using Box-Muller transform with 70% values between -1.0 and 1.0 </summary>
        public static float NextGaussian(this Random self)
        {
            var u1 = 1.0f - self.NextFloat();
            var u2 = 1.0f - self.NextFloat();
            return Mathf.Sqrt(-2.0f * Mathf.Log(u1)) * Mathf.Sin(2.0f * Mathf.PI * u2);
        }

        /// <summary> Calculates Gaussian number sample using Box-Muller transform with 70% values between (mean - stdev) and (mean + stdev) </summary>
        public static float NextGaussian(this Random self, float mean, float stdev)
        {
            return mean + stdev * self.NextGaussian();
        }

        public static Vector2 NextUnitVector2(this Random self)
        {
            var angle = self.NextFloat() * 2.0f * Mathf.PI;
            return new Vector2(
                Mathf.Cos(angle),
                Mathf.Sin(angle)
            );
        }

        public static Vector2 NextVector2(this Random self)
        {
            return new Vector2(
                self.NextFloat(),
                self.NextFloat()
            );
        }

        public static Vector2 NextVector2(this Random self, Vector2 max)
        {
            return new Vector2(
                self.NextFloat(max.x),
                self.NextFloat(max.y)
            );
        }

        public static Vector2 NextVector2(this Random self, Vector2 min, Vector2 max)
        {
            return new Vector2(
                self.NextFloat(min.x, max.x),
                self.NextFloat(min.y, max.y)
            );
        }

        public static Vector3 NextUnitVector3(this Random self)
        {
            var theta = self.NextFloat() * 2.0f * Mathf.PI;
            var omega = self.NextFloat() * 2.0f * Mathf.PI;
            var t = Mathf.Acos(omega * (1.0f / Mathf.PI) - 1.0f);
            return new Vector3(
                Mathf.Sin(t) * Mathf.Cos(theta),
                Mathf.Sin(t) * Mathf.Sin(theta),
                Mathf.Cos(t)
            );
        }

        public static Vector3 NextVector3(this Random self)
        {
            return new Vector3(
                self.NextFloat(),
                self.NextFloat(),
                self.NextFloat()
            );
        }

        public static Vector3 NextVector3(this Random self, Vector3 max)
        {
            return new Vector3(
                self.NextFloat(max.x),
                self.NextFloat(max.y),
                self.NextFloat(max.z)
            );
        }

        public static Vector3 NextVector3(this Random self, Vector3 min, Vector3 max)
        {
            return new Vector3(
                self.NextFloat(min.x, max.x),
                self.NextFloat(min.y, max.y),
                self.NextFloat(min.z, max.z)
            );
        }

        public static Color NextColor(this Random self)
        {
            return new Color(
                self.NextFloat(),
                self.NextFloat(),
                self.NextFloat(),
                self.NextFloat()
            );
        }

        public static Color32 NextColor32(this Random self)
        {
            return new Color32(
                self.NextByte(),
                self.NextByte(),
                self.NextByte(),
                self.NextByte()
            );
        }

        public static TEnum NextEnum<TEnum>(this Random self)
        {
            var values = Enum.GetValues(typeof(TEnum));
            var index = self.Next(values.Length);
            return (TEnum)values.GetValue(index);
        }

        public static T NextItem<T>(this Random self, IList<T> list, int min, int max)
        {
            return list[self.Next(min, max)];
        }

        public static T NextItem<T>(this Random self, IList<T> list, int max)
        {
            return self.NextItem(list, 0, max);
        }

        public static T NextItem<T>(this Random self, IList<T> list)
        {
            return self.NextItem(list, list.Count);
        }

        public static void NextItems<T>(this Random self, IList<T> source, IList<T> target)
        {
            for (int i = 0; i < target.Count; ++i)
            {
                target[i] = self.NextItem(source);
            }
        }

        public static void NextUniques<T>(this Random self, IList<T> source, IList<T> target)
        {
            int offset = self.Next(0, source.Count);
            float step = source.Count * 1.0f / target.Count;
            for (int i = 0; i < target.Count; ++i)
            {
                int j = ((int)(i * step) + offset) % source.Count;
                target[i] = source[j];
            }
            self.NextShuffle(target);
        }

        public static void NextShuffle<T>(this Random self, IList<T> list, int begin, int end)
        {
            int n = end;
            while (--n > begin)
            {
                int k = self.Next(n);
                list.Swap(k, n);
            }
        }

        public static void NextShuffle<T>(this Random self, IList<T> list, int end)
        {
            self.NextShuffle(list, 0, end);
        }

        public static void NextShuffle<T>(this Random self, IList<T> list)
        {
            self.NextShuffle(list, list.Count);
        }

        public static IEnumerable<T> NextEnumerable<T>(this Random self, IList<T> list)
        {
            int offset = self.Next(list.Count);
            for (int i = 0; i < list.Count; ++i)
            {
                int index = (i + offset) % list.Count;
                yield return list[index];
            }
        }
    }
}
