using System;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

namespace Common.Extensions
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

        public static int NextUnit(this Random self)
        {
            return self.Next(2);
        }

        public static bool NextBool(this Random self)
        {
            return self.NextDouble() > 0.5;
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
            return (TEnum)values.GetValue(self.Next(values.Length));
        }
        
        public static void Shuffle<T>(this Random self, T[] array, int begin, int end)
        {
            int n = end;
            while (--n > begin)
            {
                int k = self.Next(n);
                array.Swap(k, n);
            }
        }

        public static void Shuffle<T>(this Random self, T[] array, int end)
        {
            self.Shuffle(array, 0, end);
        }

        public static void Shuffle<T>(this Random self, T[] array)
        {
            self.Shuffle(array, array.Length);
        }

        public static void Shuffle<T>(this Random self, List<T> list, int begin, int end)
        {
            int n = end;
            while (--n > begin)
            {
                int k = self.Next(n);
                list.Swap(k, n);
            }
        }

        public static void Shuffle<T>(this Random self, List<T> list, int end)
        {
            self.Shuffle(list, 0, end);
        }

        public static void Shuffle<T>(this Random self, List<T> list)
        {
            self.Shuffle(list, list.Count);
        }

        public static T NextItem<T>(this Random self, T[] args, int min, int max)
        {
            return args[self.Next(min, max)];
        }

        public static T NextItem<T>(this Random self, T[] args, int max)
        {
            return self.NextItem(args, 0, max);
        }

        public static T NextItem<T>(this Random self, params T[] args)
        {
            return self.NextItem(args, args.Length);
        }

        public static T NextItem<T>(this Random self, List<T> list, int min, int max)
        {
            return list[self.Next(min, max)];
        }

        public static T NextItem<T>(this Random self, List<T> list, int max)
        {
            return self.NextItem(list, 0, max);
        }

        public static T NextItem<T>(this Random self, List<T> list)
        {
            return self.NextItem(list, list.Count);
        }

        public static void NextItems<T>(this Random self, T[] source, T[] target)
        {
            for (int i = 0; i < target.Length; ++i)
            {
                target[i] = self.NextItem(source);
            }
        }

        public static void NextItems<T>(this Random self, List<T> source, T[] target)
        {
            for (int i = 0; i < target.Length; ++i)
            {
                target[i] = self.NextItem(source);
            }
        }
    }
}
