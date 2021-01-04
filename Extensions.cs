using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;
using Random = System.Random;

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

    public static class ListExtensions
    {
        public static bool IsNullOrEmpty<T>(this List<T> list)
        {
            return list == null || list.Count == 0;
        }

        public static int GetCountSafely<T>(this List<T> list)
        {
            if (list == null)
                return 0;
            return list.Count;
        }

        public static T First<T>(this List<T> list)
        {
            return list[0];
        }

        public static T Last<T>(this List<T> list)
        {
            return list[list.Count - 1];
        }

        public static void RemoveLast<T>(this List<T> list)
        {
            list.RemoveAt(list.Count - 1);
        }

        public static void RemoveLast<T>(this List<T> list, int count)
        {
            list.RemoveRange(list.Count - 1 - count, count);
        }

        public static T Revoke<T>(this List<T> list, int index)
        {
            var result = list[index];
            list.RemoveAt(index);
            return result;
        }

        public static T RevokeLast<T>(this List<T> list)
        {
            var last = list.Last();
            list.RemoveLast();
            return last;
        }

        public static T[] RevokeLast<T>(this List<T> list, int count)
        {
            var last = new T[count];
            list.CopyTo(list.Count - 1 - count, last, 0, count);
            list.RemoveLast(count);
            return last;
        }

        public static void Shuffle<T>(this List<T> list, int seed = default)
        {
			var random = new Random(seed);
            int n = list.Count;
            while (n-- > 1)
            {
                int k = random.Next(0, n);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
		
        public static List<T> Populate<T>(this List<T> list, T value)
        {
            for (int i = 0; i < list.Count; ++i)
                list[i] = value;
            return list;
        }
    }
	
    public static class StringExtensions
    {
        public static Color32 HexToColorRGB(this string value)
        {
            byte r = Convert.ToByte(value.Substring(0, 2), 16);
            byte g = Convert.ToByte(value.Substring(2, 2), 16);
            byte b = Convert.ToByte(value.Substring(4, 2), 16);
            return new Color32(r, g, b, 255);
        }

        public static Color32 HexToColorRGBA(this string value)
        {
            byte r = Convert.ToByte(value.Substring(0, 2), 16);
            byte g = Convert.ToByte(value.Substring(2, 2), 16);
            byte b = Convert.ToByte(value.Substring(4, 2), 16);
            byte a = Convert.ToByte(value.Substring(6, 2), 16);
            return new Color32(r, g, b, a);
        }

		public static string Capitalize(this string value)
		{
			if (string.IsNullOrEmpty(value))
				return value;
			if (value.Length == 1)
				return char.ToUpper(value[0]).ToString();
			else
				return char.ToUpper(value[0]) + value.Substring(1);
		}

		public static bool StartsWith(this string value, string prefix)
		{
			if (string.IsNullOrEmpty(value) || string.IsNullOrEmpty(prefix))
				return false;

			var valueLength = value.Length;
			var prefixLength = prefix.Length;
			if (valueLength < prefixLength)
				return false;

			for (int i = 0; i < prefixLength; i++)
				if (value[i] != prefix[i])
					return false;
			return true;
		}

		public static bool EndsWith(this string value, string suffix)
		{
			if (string.IsNullOrEmpty(value) || string.IsNullOrEmpty(suffix))
				return false;

			var valueLength = value.Length;
			var suffixLength = suffix.Length;
			if (valueLength < suffixLength)
				return false;

			for (int i = 0; i < suffixLength; i++)
				if (value[valueLength - suffixLength + i] != suffix[i])
					return false;
			return true;
		}

		public static string RemovePrefix(this string value, string prefix)
		{
			if (StartsWith(value, prefix))
				return value.Substring(prefix.Length);
			return value;
		}

		public static string RemoveSuffix(this string value, string suffix)
		{
			if (EndsWith(value, suffix))
				return value.Substring(0, value.Length - suffix.Length);
			return value;
		}
    }

	public static class FloatExtensions
	{
		public static bool TryGetDigits(this float value, out int front, out int back)
		{
			var valueString = value.ToString();
			var split = valueString.Split(',');

			if (split.IsNullOrEmpty())
			{
				split = valueString.Split('.');
			}

			if (split.IsNullOrEmpty())
			{
				front = default;
				back = default;
				return false;
			}

			front = split[0].Length;
			back = split.Length == 2 ? split[1].Length : 0;
			return true;
		}

		public static int GetFrontDigits(this float value)
		{
			if (TryGetDigits(value, out int front, out int back))
				return front;
			return default;
		}

		public static int GetBackDigits(this float value)
		{
			if (TryGetDigits(value, out int front, out int back))
				return back;
			return default;
		}
	}
	
	public static class RectExtensions
	{
		public static Rect CopyAndSet(this Rect rect, float x = default, float y = default, float width = default, float height = default)
		{
			var result = new Rect();
			result.x = x == default ? rect.x : x;
			result.y = y == default ? rect.y : y;
			result.width = width == default ? rect.width : width;
			result.height = height == default ? rect.height : height;
			return result;
		}
	}

	public static class SerializedPropertyExtensions
	{
		public static void SetValue(this SerializedProperty property, object value)
		{
			switch (property.propertyType)
			{
				case SerializedPropertyType.AnimationCurve: property.animationCurveValue = (AnimationCurve)value; break;
				case SerializedPropertyType.ArraySize: property.arraySize = (int)value; break;
				case SerializedPropertyType.Boolean: property.boolValue = (bool)value; break;
				case SerializedPropertyType.Bounds: property.boundsValue = (Bounds)value; break;
				case SerializedPropertyType.BoundsInt: property.boundsIntValue = (BoundsInt)value; break;
				case SerializedPropertyType.Color: property.colorValue = (Color)value; break;
				case SerializedPropertyType.ExposedReference: property.exposedReferenceValue = (Object)value; break;
				case SerializedPropertyType.Float: property.floatValue = (float)value; break;
				case SerializedPropertyType.Integer: property.intValue = (int)value; break;
				case SerializedPropertyType.ManagedReference: property.managedReferenceValue = value; break;
				case SerializedPropertyType.ObjectReference: property.objectReferenceValue = (Object)value; break;
				case SerializedPropertyType.Quaternion: property.quaternionValue = (Quaternion)value; break;
				case SerializedPropertyType.Rect: property.rectValue = (Rect)value; break;
				case SerializedPropertyType.RectInt: property.rectIntValue = (RectInt)value; break;
				case SerializedPropertyType.String: property.stringValue = (string)value; break;
				case SerializedPropertyType.Vector2: property.vector2Value = (Vector2)value; break;
				case SerializedPropertyType.Vector2Int: property.vector2IntValue = (Vector2Int)value; break;
				case SerializedPropertyType.Vector3: property.vector3Value = (Vector3)value; break;
				case SerializedPropertyType.Vector3Int: property.vector3IntValue = (Vector3Int)value; break;
				case SerializedPropertyType.Vector4: property.vector4Value = (Vector4)value; break;
				default: throw new KeyNotFoundException($"Couldn't find {property.propertyType} in {property}");
			}
		}

		public static object GetValue(this SerializedProperty property)
		{
			switch (property.propertyType)
			{
				case SerializedPropertyType.AnimationCurve: return property.animationCurveValue;
				case SerializedPropertyType.ArraySize: return property.arraySize;
				case SerializedPropertyType.Boolean: return property.boolValue;
				case SerializedPropertyType.Bounds: return property.boundsValue;
				case SerializedPropertyType.BoundsInt: return property.boundsIntValue;
				case SerializedPropertyType.Color: return property.colorValue;
				case SerializedPropertyType.ExposedReference: return property.exposedReferenceValue;
				case SerializedPropertyType.Float: return property.floatValue;
				case SerializedPropertyType.Integer: return property.intValue;
				case SerializedPropertyType.ObjectReference: return property.objectReferenceValue;
				case SerializedPropertyType.Quaternion: return property.quaternionValue;
				case SerializedPropertyType.Rect: return property.rectValue;
				case SerializedPropertyType.RectInt: return property.rectIntValue;
				case SerializedPropertyType.String: return property.stringValue;
				case SerializedPropertyType.Vector2: return property.vector2Value;
				case SerializedPropertyType.Vector2Int: return property.vector2IntValue;
				case SerializedPropertyType.Vector3: return property.vector3Value;
				case SerializedPropertyType.Vector3Int: return property.vector3IntValue;
				case SerializedPropertyType.Vector4: return property.vector4Value;
				default: throw new KeyNotFoundException($"Couldn't find {property.propertyType} in {property}");
			}
		}
	}

	public static class TransformExtensions
	{
		public static void DestroyChildren(this Transform transform)
		{
			int childCount = transform.childCount;
			for (int i = childCount - 1; i > -1; i--)
			{
				var child = transform.GetChild(i);
				ObjectUtility.DestroySafely(child.gameObject);
			}
		}
	}

	public static class RandomExtensions
	{
		public static float NextFloat(this Random random)
		{
			return random.Next() * 1.0f / int.MaxValue;
		}

		public static float NextFloat(this Random random, float min, float max)
		{
			return min + NextFloat(random) * (max - min);
		}

		public static double NextDouble(this Random random, double min, double max)
		{
			return min + random.NextDouble() * (max - min);
		}
	}
}