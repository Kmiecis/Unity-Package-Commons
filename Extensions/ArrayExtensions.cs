using System;

namespace Common
{
    public static class ArrayExtensions
    {
        public static bool IsNullOrEmpty<T>(this T[] arr)
        {
            return arr == null || arr.Length == 0;
        }

        public static bool IsNullOrEmpty<T>(this T[,] arr)
        {
            return arr == null || arr.Length == 0;
        }

        public static int GetLengthSafely<T>(this T[] arr)
        {
            return arr == null ? 0 : arr.Length;
        }

        public static T First<T>(this T[] arr)
        {
            return arr[0];
        }

        public static T FirstOrNull<T>(this T[] arr)
        {
            return arr.IsNullOrEmpty() ? default : arr.First();
        }

        public static T Last<T>(this T[] arr)
        {
            return arr[arr.Length - 1];
        }

        public static T LastOrNull<T>(this T[] arr)
        {
            return arr.IsNullOrEmpty() ? default : arr.Last();
        }

        public static bool TryGet<T>(this T[] arr, int index, out T item)
        {
            if (0 > index || index > arr.Length - 1)
            {
                item = default;
                return false;
            }
            item = arr[index];
            return true;
        }

        public static bool TryGetFirst<T>(this T[] arr, out T item)
        {
            return arr.TryGet(0, out item);
        }

        public static bool TryGetLast<T>(this T[] arr, out T item)
        {
            return arr.TryGet(arr.Length - 1, out item);
        }

        public static bool TryIndexOf<T>(this T[] arr, T value, out int index)
        {
            index = Array.IndexOf(arr, value);
            return index != -1;
        }

        public static bool TryFind<T>(this T[] arr, Predicate<T> match, out T value)
        {
            value = Array.Find(arr, match);
            return value != default;
        }

        public static T[] Populate<T>(this T[] arr, T value)
        {
            for (int i = 0; i < arr.Length; ++i)
                arr[i] = value;
            return arr;
        }

        public static void Shuffle<T>(this T[] arr, int seed = default)
        {
            var random = new Random(seed);
            int n = arr.Length;
            while (n-- > 1)
            {
                int k = random.Next(0, n);
                T value = arr[k];
                arr[k] = arr[n];
                arr[n] = value;
            }
        }

        public static bool Contains<T>(this T[] arr, T value)
        {
            return Array.IndexOf(arr, value) != -1;
        }
    }
}