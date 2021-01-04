using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common.Mathematics
{
	public static class Mathx
	{
		private const float EPS = 1e-7f;


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
		public static int IncrIndex(int i, int count, int offset = 1)
		{
			return (i + offset) % count;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int DecrIndex(int i, int count, int offset = 1)
		{
			return (i - offset + count) % count;
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
		public static Vector2 Multiply(Vector2 l, Vector2 r)
		{
			return new Vector2(
				l.x * r.x,
				l.y * r.y
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Multiply(Vector3 l, Vector3 r)
		{
			return new Vector3(
				l.x * r.x,
				l.y * r.y,
				l.z * r.z
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 Multiply(Vector4 l, Vector4 r)
		{
			return new Vector4(
				l.x * r.x,
				l.y * r.y,
				l.z * r.z,
				l.w * r.w
			);
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Multiply(Vector2 l, Vector2Int r)
		{
			return new Vector2(
				l.x * r.x,
				l.y * r.y
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Multiply(Vector3 l, Vector3Int r)
		{
			return new Vector3(
				l.x * r.x,
				l.y * r.y,
				l.z * r.z
			);
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Multiply(Vector2Int l, Vector2 r)
		{
			return new Vector2(
				l.x * r.x,
				l.y * r.y
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Multiply(Vector3Int l, Vector3 r)
		{
			return new Vector3(
				l.x * r.x,
				l.y * r.y,
				l.z * r.z
			);
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2Int Multiply(Vector2Int l, Vector2Int r)
		{
			return new Vector2Int(
				l.x * r.x,
				l.y * r.y
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3Int Multiply(Vector3Int l, Vector3Int r)
		{
			return new Vector3Int(
				l.x * r.x,
				l.y * r.y,
				l.z * r.z
			);
		}
	}
}