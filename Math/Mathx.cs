using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common.Mathematics
{
	public static class Mathx
	{
		private const float EPS = 1e-7f;

		public const float ROOT_3 = 1.73205080757f;
		public const float ROOT_2 = 1.41421356237f;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsZero(float f)
		{
			return Math.Abs(f) < EPS;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsZero(Vector2 v)
		{
			return IsZero(v.x) && IsZero(v.y);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsZero(Vector3 v)
		{
			return IsZero(v.x) && IsZero(v.y) && IsZero(v.z);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsZero(Vector4 v)
		{
			return IsZero(v.x) && IsZero(v.y) && IsZero(v.z) && IsZero(v.w);
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsOne(float f)
		{
			return IsZero(f - 1.0f);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsOne(Vector2 v)
		{
			return IsOne(v.x) && IsOne(v.y);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsOne(Vector3 v)
		{
			return IsOne(v.x) && IsOne(v.y) && IsOne(v.z);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsOne(Vector4 v)
		{
			return IsOne(v.x) && IsOne(v.y) && IsOne(v.z) && IsOne(v.w);
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AreEqual(float a, float b)
		{
			return IsZero(a - b);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AreEqual(Vector2 a, Vector2 b)
		{
			return IsZero(a.x - b.x) && IsZero(a.y - b.y);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AreEqual(Vector3 a, Vector3 b)
		{
			return IsZero(a.x - b.x) && IsZero(a.y - b.y) && IsZero(a.z - b.z);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AreEqual(Vector4 a, Vector4 b)
		{
			return IsZero(a.x - b.x) && IsZero(a.y - b.y) && IsZero(a.z - b.z) && IsZero(a.w - b.w);
		}
		
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AreEqual(Vector2Int a, Vector2Int b)
		{
			return a.x == b.x && a.y == b.y;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AreEqual(Vector3Int a, Vector3Int b)
		{
			return a.x == b.x && a.y == b.y && a.z == b.z;
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Square(float f)
		{
			return f * f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Saturate(float f)
		{
			return f < 0.0f ? 0.0f : f > 1.0f ? 1.0f : f;
		}
		
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float SmoothStep(float a, float b, float t)
		{
			t = Saturate(t);
			t = -2.0f * t * t * t + 3.0f * t * t;
			return b * t + a * (1.0f - t);
		}
		
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Remap(float v, float fromMin, float fromMax, float toMin, float toMax)
		{
			return (v - fromMin) / (fromMax - fromMin) * (toMax - toMin) + toMin;
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsInRange(int v, int min, int max)
		{
			return min <= v && v <= max;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsNotInRange(int v, int min, int max)
		{
			return min > v || v > max;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsInRange(float v, float min, float max)
		{
			return min <= v && v <= max;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsNotInRange(float v, float min, float max)
		{
			return min > v || v > max;
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsEven(int i)
		{
			return (i % 2) == 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsOdd(int i)
		{
			return (i % 2) == 1;
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int NextIndex(int i, int count, int offset = 1)
		{
			return (i + offset) % count;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int PrevIndex(int i, int count, int offset = 1)
		{
			return (i - offset + count) % count;
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Unlerp(float a, float b, float v)
		{
			return (v - a) / (b - a);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Unlerp(Vector2 a, Vector2 b, Vector2 v)
		{
			return new Vector2(
				Unlerp(a.x, b.x, v.x),
				Unlerp(a.y, b.y, v.y)
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Unlerp(Vector3 a, Vector3 b, Vector3 v)
		{
			return new Vector3(
				Unlerp(a.x, b.x, v.x),
				Unlerp(a.y, b.y, v.y),
				Unlerp(a.z, b.z, v.z)
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 Unlerp(Vector4 a, Vector4 b, Vector4 v)
		{
			return new Vector4(
				Unlerp(a.x, b.x, v.x),
				Unlerp(a.y, b.y, v.y),
				Unlerp(a.z, b.z, v.z),
				Unlerp(a.w, b.w, v.w)
			);
		}
		

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Round(Vector2 v)
		{
			return new Vector2(
				Mathf.Round(v.x),
				Mathf.Round(v.y)
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Round(Vector3 v)
		{
			return new Vector3(
				Mathf.Round(v.x),
				Mathf.Round(v.y),
				Mathf.Round(v.z)
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 Round(Vector4 v)
		{
			return new Vector4(
				Mathf.Round(v.x),
				Mathf.Round(v.y),
				Mathf.Round(v.z),
				Mathf.Round(v.w)
			);
		}
		
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Floor(Vector2 v)
		{
			return new Vector2(
				Mathf.Floor(v.x),
				Mathf.Floor(v.y)
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Floor(Vector3 v)
		{
			return new Vector3(
				Mathf.Floor(v.x),
				Mathf.Floor(v.y),
				Mathf.Floor(v.z)
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 Floor(Vector4 v)
		{
			return new Vector4(
				Mathf.Floor(v.x),
				Mathf.Floor(v.y),
				Mathf.Floor(v.z),
				Mathf.Floor(v.w)
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Ceil(Vector2 v)
		{
			return new Vector2(
				Mathf.Ceil(v.x),
				Mathf.Ceil(v.y)
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Ceil(Vector3 v)
		{
			return new Vector3(
				Mathf.Ceil(v.x),
				Mathf.Ceil(v.y),
				Mathf.Ceil(v.z)
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 Ceil(Vector4 v)
		{
			return new Vector4(
				Mathf.Ceil(v.x),
				Mathf.Ceil(v.y),
				Mathf.Ceil(v.z),
				Mathf.Ceil(v.w)
			);
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2Int RoundToInt(Vector2 v)
		{
			return new Vector2Int(
				Mathf.RoundToInt(v.x),
				Mathf.RoundToInt(v.y)
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3Int RoundToInt(Vector3 v)
		{
			return new Vector3Int(
				Mathf.RoundToInt(v.x),
				Mathf.RoundToInt(v.y),
				Mathf.RoundToInt(v.z)
			);
		}
		
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2Int FloorToInt(Vector2 v)
		{
			return new Vector2Int(
				Mathf.FloorToInt(v.x),
				Mathf.FloorToInt(v.y)
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3Int FloorToInt(Vector3 v)
		{
			return new Vector3Int(
				Mathf.FloorToInt(v.x),
				Mathf.FloorToInt(v.y),
				Mathf.FloorToInt(v.z)
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2Int CeilToInt(Vector2 v)
		{
			return new Vector2Int(
				Mathf.CeilToInt(v.x),
				Mathf.CeilToInt(v.y)
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3Int CeilToInt(Vector3 v)
		{
			return new Vector3Int(
				Mathf.CeilToInt(v.x),
				Mathf.CeilToInt(v.y),
				Mathf.CeilToInt(v.z)
			);
		}
		

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Abs(Vector2 v)
		{
			return new Vector2(
				Mathf.Abs(v.x),
				Mathf.Abs(v.y)
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Abs(Vector3 v)
		{
			return new Vector3(
				Mathf.Abs(v.x),
				Mathf.Abs(v.y),
				Mathf.Abs(v.z)
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 Abs(Vector4 v)
		{
			return new Vector4(
				Mathf.Abs(v.x),
				Mathf.Abs(v.y),
				Mathf.Abs(v.z),
				Mathf.Abs(v.w)
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2Int Abs(Vector2Int v)
		{
			return new Vector2Int(
				Mathf.Abs(v.x),
				Mathf.Abs(v.y)
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3Int Abs(Vector3Int v)
		{
			return new Vector3Int(
				Mathf.Abs(v.x),
				Mathf.Abs(v.y),
				Mathf.Abs(v.z)
			);
		}

		
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Multiply(Vector2 a, Vector2 b)
		{
			return new Vector2(
				a.x * b.x,
				a.y * b.y
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Multiply(Vector3 a, Vector3 b)
		{
			return new Vector3(
				a.x * b.x,
				a.y * b.y,
				a.z * b.z
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 Multiply(Vector4 a, Vector4 b)
		{
			return new Vector4(
				a.x * b.x,
				a.y * b.y,
				a.z * b.z,
				a.w * b.w
			);
		}
		
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Multiply(Vector2Int v, float f)
		{
			return new Vector2(
				v.x * f,
				v.y * f
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Multiply(Vector2Int a, Vector2 b)
		{
			return new Vector2(
				a.x * b.x,
				a.y * b.y
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Multiply(Vector3Int v, float f)
		{
			return new Vector3(
				v.x * f,
				v.y * f,
				v.z * f
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Multiply(Vector3Int a, Vector3 b)
		{
			return new Vector3(
				a.x * b.x,
				a.y * b.y,
				a.z * b.z
			);
		}
		
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Multiply(float f, Vector2Int v)
		{
			return new Vector2(
				f * v.x,
				f * v.y
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Multiply(Vector2 a, Vector2Int b)
		{
			return new Vector2(
				a.x * b.x,
				a.y * b.y
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Multiply(float f, Vector3Int v)
		{
			return new Vector3(
				f * v.x,
				f * v.y,
				f * v.z
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Multiply(Vector3 a, Vector3Int b)
		{
			return new Vector3(
				a.x * b.x,
				a.y * b.y,
				a.z * b.z
			);
		}
		
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2Int Multiply(Vector2Int a, Vector2Int b)
		{
			return new Vector2Int(
				a.x * b.x,
				a.y * b.y
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3Int Multiply(Vector3Int a, Vector3Int b)
		{
			return new Vector3Int(
				a.x * b.x,
				a.y * b.y,
				a.z * b.z
			);
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Divide(Vector2 a, Vector2 b)
		{
			return new Vector2(
				a.x / b.x,
				a.y / b.y
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Divide(Vector3 a, Vector3 b)
		{
			return new Vector3(
				a.x / b.x,
				a.y / b.y,
				a.z / b.z
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 Divide(Vector4 a, Vector4 b)
		{
			return new Vector4(
				a.x / b.x,
				a.y / b.y,
				a.z / b.z,
				a.w / b.w
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Divide(Vector2Int v, float f)
		{
			return new Vector2(
				v.x / f,
				v.y / f
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Divide(Vector2Int a, Vector2 b)
		{
			return new Vector2(
				a.x / b.x,
				a.y / b.y
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Divide(Vector3Int v, float f)
		{
			return new Vector3(
				v.x / f,
				v.y / f,
				v.z / f
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Divide(Vector3Int a, Vector3 b)
		{
			return new Vector3(
				a.x / b.x,
				a.y / b.y,
				a.z / b.z
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Divide(float f, Vector2Int v)
		{
			return new Vector2(
				f / v.x,
				f / v.y
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Divide(Vector2 a, Vector2Int b)
		{
			return new Vector2(
				a.x / b.x,
				a.y / b.y
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Divide(float f, Vector3Int v)
		{
			return new Vector3(
				f / v.x,
				f / v.y,
				f / v.z
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Divide(Vector3 a, Vector3Int b)
		{
			return new Vector3(
				a.x / b.x,
				a.y / b.y,
				a.z / b.z
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2Int Divide(Vector2Int a, Vector2Int b)
		{
			return new Vector2Int(
				a.x / b.x,
				a.y / b.y
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3Int Divide(Vector3Int a, Vector3Int b)
		{
			return new Vector3Int(
				a.x / b.x,
				a.y / b.y,
				a.z / b.z
			);
		}
	}
}