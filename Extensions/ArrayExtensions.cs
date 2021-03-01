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
			if (arr == null)
				return 0;
			return arr.Length;
		}

		public static T First<T>(this T[] arr)
		{
			return arr[0];
		}

		public static T Last<T>(this T[] arr)
		{
			return arr[arr.Length - 1];
		}

		public static bool TryIndexOf<T>(this T[] arr, T value, out int index)
		{
			index = Array.IndexOf(arr, value);
			return index != -1;
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