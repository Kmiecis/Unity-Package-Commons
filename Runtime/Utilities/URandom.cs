using Common.Extensions;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Common
{
    public static class URandom
    {
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

        public static bool Bool()
        {
            return Random.Range(0.0f, 1.0f) > 0.5f;
        }

        public static int Sign()
        {
            return Bool() ? +1 : -1;
        }

        public static int Unit()
        {
            return Random.Range(0, 2);
        }

        public static TEnum Enum<TEnum>()
        {
            var values = System.Enum.GetValues(typeof(TEnum));
            return (TEnum)values.GetValue(Random.Range(0, values.Length));
        }

        public static T Item<T>(T[] args, int min, int max)
        {
            return args[Random.Range(min, max)];
        }

        public static T Item<T>(T[] args, int max)
        {
            return Item(args, 0, max);
        }

        public static T Item<T>(params T[] args)
        {
            return Item(args, args.Length);
        }

        public static T Item<T>(List<T> list, int min, int max)
        {
            return list[Random.Range(min, max)];
        }

        public static T Item<T>(List<T> list, int max)
        {
            return Item(list, 0, max);
        }

        public static T Item<T>(List<T> list)
        {
            return Item(list, list.Count);
        }

        public static void Items<T>(T[] source, T[] target)
        {
            for (int i = 0; i < target.Length; ++i)
            {
                target[i] = Item(source);
            }
        }

        public static void Items<T>(List<T> source, T[] target)
        {
            for (int i = 0; i < target.Length; ++i)
            {
                target[i] = Item(source);
            }
        }

        public static void Shuffle<T>(T[] array, int begin, int end)
        {
            int n = end;
            while (--n > begin)
            {
                int k = Random.Range(0, n);
                array.Swap(k, n);
            }
        }

        public static void Shuffle<T>(T[] array, int end)
        {
            Shuffle(array, 0, end);
        }

        public static void Shuffle<T>(T[] array)
        {
            Shuffle(array, array.Length);
        }

        public static void Shuffle<T>(List<T> list, int begin, int end)
        {
            int n = end;
            while (--n > begin)
            {
                int k = Random.Range(0, n);
                list.Swap(k, n);
            }
        }

        public static void Shuffle<T>(List<T> list, int end)
        {
            Shuffle(list, 0, end);
        }

        public static void Shuffle<T>(List<T> list)
        {
            Shuffle(list, list.Count);
        }
    }
}
