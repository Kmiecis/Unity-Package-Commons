﻿using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Common
{
    public static class URandom
    {
        public static bool Bool(float p = 0.5f)
        {
            return Random.Range(0.0f, 1.0f) > p;
        }

        public static int Sign(float p = 0.5f)
        {
            return Bool(p) ? +1 : -1;
        }

        public static int Unit()
        {
            return Random.Range(0, 2);
        }

        /// <summary> Calculates Gaussian number sample using Box-Muller transform with 70% values between -1.0 and 1.0 </summary>
        public static float Gaussian()
        {
            var u1 = 1.0f - Random.Range(0.0f, 1.0f);
            var u2 = 1.0f - Random.Range(0.0f, 1.0f);
            return Mathf.Sqrt(-2.0f * Mathf.Log(u1)) * Mathf.Sin(2.0f * Mathf.PI * u2);
        }

        /// <summary> Calculates Gaussian number sample using Box-Muller transform with 70% values between (mean - stdev) and (mean + stdev) </summary>
        public static float Gaussian(float mean, float stdev)
        {
            return mean + stdev * Gaussian();
        }

        public static byte Range(byte min, byte max)
        {
            return (byte)Random.Range(min, max);
        }

        public static uint Range(uint min, uint max)
        {
            return (uint)Random.Range((int)min, (int)max);
        }

        public static Vector2 Range(Vector2 min, Vector2 max)
        {
            return new Vector2(
                Random.Range(min.x, max.x),
                Random.Range(min.y, max.y)
            );
        }

        public static Vector3 Range(Vector3 min, Vector3 max)
        {
            return new Vector3(
                Random.Range(min.x, max.x),
                Random.Range(min.y, max.y),
                Random.Range(min.z, max.z)
            );
        }

        public static Vector4 Range(Vector4 min, Vector4 max)
        {
            return new Vector4(
                Random.Range(min.x, max.x),
                Random.Range(min.y, max.y),
                Random.Range(min.z, max.z),
                Random.Range(min.w, max.w)
            );
        }

        public static Color Range(Color min, Color max)
        {
            return new Color(
                Random.Range(min.r, max.r),
                Random.Range(min.g, max.g),
                Random.Range(min.b, max.b),
                Random.Range(min.a, max.a)
            );
        }

        public static TEnum Enum<TEnum>()
        {
            var values = System.Enum.GetValues(typeof(TEnum));
            var index = Random.Range(0, values.Length);
            return (TEnum)values.GetValue(index);
        }

        public static T Item<T>(IList<T> list, int min, int max)
        {
            return list[Random.Range(min, max)];
        }

        public static T Item<T>(IList<T> list, int max)
        {
            return Item(list, 0, max);
        }

        public static T Item<T>(IList<T> list)
        {
            return Item(list, list.Count);
        }

        public static void Items<T>(IList<T> source, IList<T> target)
        {
            for (int i = 0; i < target.Count; ++i)
            {
                target[i] = Item(source);
            }
        }

        public static void Uniques<T>(IList<T> source, IList<T> target)
        {
            int offset = Random.Range(0, source.Count);
            float step = source.Count * 1.0f / target.Count;
            for (int i = 0; i < target.Count; ++i)
            {
                int j = ((int)(i * step) + offset) % source.Count;
                target[i] = source[j];
            }
            Shuffle(target);
        }

        public static void Shuffle<T>(IList<T> list, int begin, int end)
        {
            int n = end;
            while (--n > begin)
            {
                int k = Random.Range(0, n);
                list.Swap(k, n);
            }
        }

        public static void Shuffle<T>(IList<T> list, int end)
        {
            Shuffle(list, 0, end);
        }

        public static void Shuffle<T>(IList<T> list)
        {
            Shuffle(list, list.Count);
        }

        public static IEnumerable<T> Enumerable<T>(IList<T> list)
        {
            int offset = Random.Range(0, list.Count);
            for (int i = 0; i < list.Count; ++i)
            {
                int index = (i + offset) % list.Count;
                yield return list[index];
            }
        }
    }
}
