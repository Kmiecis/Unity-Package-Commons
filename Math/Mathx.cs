using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common
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
			return (
				IsZero(v.x) &&
				IsZero(v.y)
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsZero(Vector3 v)
		{
			return (
				IsZero(v.x) &&
				IsZero(v.y) &&
				IsZero(v.z)
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsZero(Vector4 v)
		{
			return (
				IsZero(v.x) &&
				IsZero(v.y) &&
				IsZero(v.z) &&
				IsZero(v.w)
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsZero(int i)
		{
			return i == 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsZero(Vector2Int v)
		{
			return (
				IsZero(v.x) &&
				IsZero(v.y)
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsZero(Vector3Int v)
		{
			return (
				IsZero(v.x) &&
				IsZero(v.y) &&
				IsZero(v.z)
			);
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsOne(float f)
		{
			return IsZero(f - 1.0f);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsOne(Vector2 v)
		{
			return (
				IsOne(v.x) &&
				IsOne(v.y)
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsOne(Vector3 v)
		{
			return (
				IsOne(v.x) &&
				IsOne(v.y) &&
				IsOne(v.z)
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsOne(Vector4 v)
		{
			return (
				IsOne(v.x) &&
				IsOne(v.y) &&
				IsOne(v.z) &&
				IsOne(v.w)
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsOne(int i)
		{
			return i == 1;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsOne(Vector2Int v)
		{
			return (
				IsOne(v.x) &&
				IsOne(v.y)
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsOne(Vector3Int v)
		{
			return (
				IsOne(v.x) &&
				IsOne(v.y) &&
				IsOne(v.z)
			);
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AreEqual(float a, float b)
		{
			return IsZero(a - b);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AreEqual(Vector2 a, Vector2 b)
		{
			return (
				IsZero(a.x - b.x) &&
				IsZero(a.y - b.y)
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AreEqual(Vector3 a, Vector3 b)
		{
			return (
				IsZero(a.x - b.x) &&
				IsZero(a.y - b.y) &&
				IsZero(a.z - b.z)
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AreEqual(Vector4 a, Vector4 b)
		{
			return (
				IsZero(a.x - b.x) &&
				IsZero(a.y - b.y) &&
				IsZero(a.z - b.z) &&
				IsZero(a.w - b.w)
			);
		}
		
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AreEqual(Vector2Int a, Vector2Int b)
		{
			return (
				a.x == b.x &&
				a.y == b.y
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AreEqual(Vector3Int a, Vector3Int b)
		{
			return (
				a.x == b.x &&
				a.y == b.y &&
				a.z == b.z
			);
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Lerp(Vector2 a, Vector2 b, Vector2 v)
		{
			return a + Multiply(v, (b - a));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Lerp(Vector3 a, Vector3 b, Vector3 v)
		{
			return a + Multiply(v, b - a);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 Lerp(Vector4 a, Vector4 b, Vector4 v)
		{
			return a + Multiply(v, b - a);
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
		public static float Square(float f)
		{
			return f * f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Square(Vector2 v)
		{
			return Multiply(v, v);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Square(Vector3 v)
		{
			return Multiply(v, v);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 Square(Vector4 v)
		{
			return Multiply(v, v);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int Square(int i)
		{
			return i * i;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2Int Square(Vector2Int v)
		{
			return Multiply(v, v);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3Int Square(Vector3Int v)
		{
			return Multiply(v, v);
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Clamp(Vector2 v, Vector2 min, Vector2 max)
		{
			return new Vector2(
				Mathf.Clamp(v.x, min.x, max.x),
				Mathf.Clamp(v.y, min.y, max.y)
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Clamp(Vector3 v, Vector3 min, Vector3 max)
		{
			return new Vector3(
				Mathf.Clamp(v.x, min.x, max.x),
				Mathf.Clamp(v.y, min.y, max.y),
				Mathf.Clamp(v.z, min.z, max.z)
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 Clamp(Vector4 v, Vector4 min, Vector4 max)
		{
			return new Vector4(
				Mathf.Clamp(v.x, min.x, max.x),
				Mathf.Clamp(v.y, min.y, max.y),
				Mathf.Clamp(v.z, min.z, max.z),
				Mathf.Clamp(v.w, min.w, max.w)
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2Int Clamp(Vector2Int v, Vector2Int min, Vector2Int max)
		{
			return new Vector2Int(
				Mathf.Clamp(v.x, min.x, max.x),
				Mathf.Clamp(v.y, min.y, max.y)
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3Int Clamp(Vector3Int v, Vector3Int min, Vector3Int max)
		{
			return new Vector3Int(
				Mathf.Clamp(v.x, min.x, max.x),
				Mathf.Clamp(v.y, min.y, max.y),
				Mathf.Clamp(v.z, min.z, max.z)
			);
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Saturate(float f)
		{
			return Mathf.Clamp(f, 0.0f, 1.0f);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Saturate(Vector2 v)
		{
			return Clamp(v, Vector2.zero, Vector2.one);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Saturate(Vector3 v)
		{
			return Clamp(v, Vector3.zero, Vector3.one);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 Saturate(Vector4 v)
		{
			return Clamp(v, Vector4.zero, Vector4.one);
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float SmoothStep(float f)
		{
			return f * f * (3 - 2 * f);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 SmoothStep(Vector2 v)
		{
			return Multiply(v, Multiply(v, Subtract(3, Multiply(2, v))));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 SmoothStep(Vector3 v)
		{
			return Multiply(v, Multiply(v, Subtract(3, Multiply(2, v))));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 SmoothStep(Vector4 v)
		{
			return Multiply(v, Multiply(v, Subtract(3, Multiply(2, v))));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float SmoothStep(float a, float b, float t)
		{
			return SmoothStep(Unlerp(a, b, t));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 SmoothStep(Vector2 a, Vector2 b, Vector2 t)
		{
			return SmoothStep(Unlerp(a, b, t));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 SmoothStep(Vector3 a, Vector3 b, Vector3 t)
		{
			return SmoothStep(Unlerp(a, b, t));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 SmoothStep(Vector4 a, Vector4 b, Vector4 t)
		{
			return SmoothStep(Unlerp(a, b, t));
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float SmootherStep(float f)
		{
			return f * f * f * (f * (f * 6 - 15) + 10);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 SmootherStep(Vector2 f)
		{
			return Multiply(f, Multiply(f, Multiply(f, Add(Multiply(f, Subtract(Multiply(f, 6), 15)), 10))));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 SmootherStep(Vector3 f)
		{
			return Multiply(f, Multiply(f, Multiply(f, Add(Multiply(f, Subtract(Multiply(f, 6), 15)), 10))));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 SmootherStep(Vector4 f)
		{
			return Multiply(f, Multiply(f, Multiply(f, Add(Multiply(f, Subtract(Multiply(f, 6), 15)), 10))));
		}
		
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float SmootherStep(float a, float b, float t)
		{
			return SmootherStep(Unlerp(a, b, t));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 SmootherStep(Vector2 a, Vector2 b, Vector2 t)
		{
			return SmootherStep(Unlerp(a, b, t));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 SmootherStep(Vector3 a, Vector3 b, Vector3 t)
		{
			return SmootherStep(Unlerp(a, b, t));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 SmootherStep(Vector4 a, Vector4 b, Vector4 t)
		{
			return SmootherStep(Unlerp(a, b, t));
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Remap(float fromMin, float fromMax, float toMin, float toMax, float v)
		{
			return Mathf.Lerp(toMin, toMax, Unlerp(fromMin, fromMax, v));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Remap(Vector2 fromMin, Vector2 fromMax, Vector2 toMin, Vector2 toMax, Vector2 v)
		{
			return Lerp(toMin, toMax, Unlerp(fromMin, fromMax, v));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Remap(Vector3 fromMin, Vector3 fromMax, Vector3 toMin, Vector3 toMax, Vector3 v)
		{
			return Lerp(toMin, toMax, Unlerp(fromMin, fromMax, v));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 Remap(Vector4 fromMin, Vector4 fromMax, Vector4 toMin, Vector4 toMax, Vector4 v)
		{
			return Lerp(toMin, toMax, Unlerp(fromMin, fromMax, v));
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsInRange(int v, int min, int max)
		{
			return min <= v && v <= max;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsInRange(float v, float min, float max)
		{
			return min <= v && v <= max;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsNotInRange(int v, int min, int max)
		{
			return min > v || v > max;
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


		/// <summary> Calculates next index wrapped around by 'count' </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int NextIndex(int i, int count)
		{
			return (i + 1) % count;
		}

		/// <summary> Calculates incremented index by 'offset' and wrapped around by 'count' </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int IncrIndex(int i, int count, int offset)
		{
			return (i + offset) % count;
		}

		/// <summary> Calculates previous index wrapped around by 'count' </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int PrevIndex(int i, int count)
		{
			return (i - 1 + count) % count;
		}

		/// <summary> Calculates decremented index by 'offset' and wrapped around by 'count' </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int DecrIndex(int i, int count, int offset)
		{
			return (i - offset + count) % count;
		}


		/// <summary> Calculates direction vector from single value of range [0, 1] </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Direction(float u)
		{
			var angle = 2 * Mathf.PI * u;
			var x = Mathf.Cos(angle);
			var y = Mathf.Sin(angle);
			return new Vector2(x, y);
		}

		/// <summary> Calculates direction vector from two values of range [0, 1] </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Direction(float u, float v)
		{
			var omega = 2 * Mathf.PI * u;
			var theta = Mathf.Acos(2 * v - 1);
			var x = Mathf.Sin(theta) * Mathf.Cos(omega);
			var y = Mathf.Sin(theta) * Mathf.Sin(omega);
			var z = Mathf.Cos(theta);
			return new Vector3(x, y, z);
		}


		/// <summary> Projects point 'p' to plane defined by two axes 'ax' and 'ay' </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Project(Vector3 p, Vector3 ax, Vector3 ay)
		{
			var x = Vector3.Dot(ax, p);
			var y = Vector3.Dot(ay, p);
			return new Vector2(x, y);
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Reciprocal(float f)
		{
			return 1.0f / f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Reciprocal(Vector2 f)
		{
			return Divide(1.0f, f);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Reciprocal(Vector3 f)
		{
			return Divide(1.0f, f);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 Reciprocal(Vector4 f)
		{
			return Divide(1.0f, f);
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float ReciprocalSafe(float f)
		{
			return Reciprocal(Mathf.Max(f, EPS));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 ReciprocalSafe(Vector2 f)
		{
			return Reciprocal(Vector2.Max(f, new Vector2(EPS, EPS)));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 ReciprocalSafe(Vector3 f)
		{
			return Reciprocal(Vector3.Max(f, new Vector3(EPS, EPS, EPS)));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 ReciprocalSafe(Vector4 f)
		{
			return Reciprocal(Vector4.Max(f, new Vector4(EPS, EPS, EPS, EPS)));
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
		public static float Select(float a, float b, bool c)
		{
			return c ? b : a;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Select(Vector2 a, Vector2 b, Bool2 c)
		{
			return new Vector2(
				Select(a.x, b.x, c.x),
				Select(a.y, b.y, c.y)
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Select(Vector3 a, Vector3 b, Bool3 c)
		{
			return new Vector3(
				Select(a.x, b.x, c.x),
				Select(a.y, b.y, c.y),
				Select(a.z, b.z, c.z)
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 Select(Vector4 a, Vector4 b, Bool4 c)
		{
			return new Vector4(
				Select(a.x, b.x, c.x),
				Select(a.y, b.y, c.y),
				Select(a.z, b.z, c.z),
				Select(a.w, b.w, c.w)
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Select(Vector2 a, Vector2 b, bool c)
		{
			return c ? b : a;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Select(Vector3 a, Vector3 b, bool c)
		{
			return c ? b : a;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 Select(Vector4 a, Vector4 b, bool c)
		{
			return c ? b : a;
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Step(float a, float b)
		{
			return Select(0.0f, 1.0f, b >= a);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Step(Vector2 a, Vector2 b)
		{
			return Select(
				Vector2.zero,
				Vector2.one,
				new Bool2(b.x >= a.x, b.y >= a.y)
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Step(Vector3 a, Vector3 b)
		{
			return Select(
				Vector3.zero,
				Vector3.one,
				new Bool3(b.x >= a.x, b.y >= a.y, b.z >= a.z)
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 Step(Vector4 a, Vector4 b)
		{
			return Select(
				Vector4.zero,
				Vector4.one,
				new Bool4(b.x >= a.x, b.y >= a.y, b.z >= a.z, b.w >= a.w)
			);
		}


		/// <summary> Returns the fractional part of a float value </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Frac(float f)
		{
			return f - Mathf.Floor(f);
		}

		/// <summary> Returns the componentwise fractional part of a Vector2 vector </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Frac(Vector2 f)
		{
			return f - Floor(f);
		}

		/// <summary> Returns the componentwise fractional part of a Vector3 vector </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Frac(Vector3 f)
		{
			return f - Floor(f);
		}

		/// <summary> Returns the componentwise fractional part of a Vector4 vector </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 Frac(Vector4 f)
		{
			return f - Floor(f);
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Mod(float f, float m)
		{
			return f - Mathf.Floor(f * (1.0f / m)) * m;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Mod(Vector2 v, Vector2 m)
		{
			return v - Multiply(Floor(Multiply(v, Divide(1.0f, m))), m);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Mod(Vector3 v, Vector3 m)
		{
			return v - Multiply(Floor(Multiply(v, Divide(1.0f, m))), m);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 Mod(Vector4 v, Vector4 m)
		{
			return v - Multiply(Floor(Multiply(v, Divide(1.0f, m))), m);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Mod(Vector2 v, float m)
		{
			return v - Floor(Multiply(v, 1.0f / m)) * m;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Mod(Vector3 v, float m)
		{
			return v - Floor(Multiply(v, 1.0f / m)) * m;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 Mod(Vector4 v, float m)
		{
			return v - Floor(Multiply(v, 1.0f / m)) * m;
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Permute(float f, float p, float m)
		{
			return Mod((p * f + 1.0f) * f, m);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Permute(Vector2 v, Vector2 p, Vector2 m)
		{
			return Mod(Multiply(Add(Multiply(p, v), 1.0f), v), m);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Permute(Vector3 v, Vector3 p, Vector3 m)
		{
			return Mod(Multiply(Add(Multiply(p, v), 1.0f), v), m);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 Permute(Vector4 v, Vector4 p, Vector4 m)
		{
			return Mod(Multiply(Add(Multiply(p, v), 1.0f), v), m);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Permute(Vector2 v, float p, float m)
		{
			return Mod(Multiply(Add(Multiply(p, v), 1.0f), v), m);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Permute(Vector3 v, float p, float m)
		{
			return Mod(Multiply(Add(Multiply(p, v), 1.0f), v), m);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 Permute(Vector4 v, float p, float m)
		{
			return Mod(Multiply(Add(Multiply(p, v), 1.0f), v), m);
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Add(Vector2 v, float f)
		{
			return new Vector2(
				v.x + f,
				v.y + f
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Add(Vector3 v, float f)
		{
			return new Vector3(
				v.x + f,
				v.y + f,
				v.z + f
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 Add(Vector4 v, float f)
		{
			return new Vector4(
				v.x + f,
				v.y + f,
				v.z + f,
				v.w + f
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Add(float f, Vector2 v)
		{
			return new Vector2(
				 f + v.x,
				 f + v.y
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Add(float f, Vector3 v)
		{
			return new Vector3(
				 f + v.x,
				 f + v.y,
				 f + v.z
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 Add(float f, Vector4 v)
		{
			return new Vector4(
				 f + v.x,
				 f + v.y,
				 f + v.z,
				 f + v.w
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Add(Vector2 v, int i)
		{
			return new Vector2(
				v.x + i,
				v.y + i
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Add(Vector3 v, int i)
		{
			return new Vector3(
				v.x + i,
				v.y + i,
				v.z + i
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 Add(Vector4 v, int i)
		{
			return new Vector4(
				v.x + i,
				v.y + i,
				v.z + i,
				v.w + i
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Add(int i, Vector2 v)
		{
			return new Vector2(
				 i + v.x,
				 i + v.y
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Add(int i, Vector3 v)
		{
			return new Vector3(
				 i + v.x,
				 i + v.y,
				 i + v.z
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 Add(int i, Vector4 v)
		{
			return new Vector4(
				 i + v.x,
				 i + v.y,
				 i + v.z,
				 i + v.w
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Add(Vector2Int v, float f)
		{
			return new Vector2(
				v.x + f,
				v.y + f
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Add(Vector3Int v, float f)
		{
			return new Vector3(
				v.x + f,
				v.y + f,
				v.z + f
			);
		}
		
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Add(float f, Vector2Int v)
		{
			return new Vector2(
				 f + v.x,
				 f + v.y
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Add(float f, Vector3Int v)
		{
			return new Vector3(
				 f + v.x,
				 f + v.y,
				 f + v.z
			);
		}
		
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2Int Add(Vector2Int v, int i)
		{
			return new Vector2Int(
				v.x + i,
				v.y + i
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3Int Add(Vector3Int v, int i)
		{
			return new Vector3Int(
				v.x + i,
				v.y + i,
				v.z + i
			);
		}
		
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2Int Add(int i, Vector2Int v)
		{
			return new Vector2Int(
				 i + v.x,
				 i + v.y
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3Int Add(int i, Vector3Int v)
		{
			return new Vector3Int(
				 i + v.x,
				 i + v.y,
				 i + v.z
			);
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Subtract(Vector2 v, float f)
		{
			return new Vector2(
				v.x - f,
				v.y - f
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Subtract(Vector3 v, float f)
		{
			return new Vector3(
				v.x - f,
				v.y - f,
				v.z - f
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 Subtract(Vector4 v, float f)
		{
			return new Vector4(
				v.x - f,
				v.y - f,
				v.z - f,
				v.w - f
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Subtract(float f, Vector2 v)
		{
			return new Vector2(
				 f - v.x,
				 f - v.y
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Subtract(float f, Vector3 v)
		{
			return new Vector3(
				 f - v.x,
				 f - v.y,
				 f - v.z
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 Subtract(float f, Vector4 v)
		{
			return new Vector4(
				 f - v.x,
				 f - v.y,
				 f - v.z,
				 f - v.w
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Subtract(Vector2 v, int i)
		{
			return new Vector2(
				v.x - i,
				v.y - i
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Subtract(Vector3 v, int i)
		{
			return new Vector3(
				v.x - i,
				v.y - i,
				v.z - i
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 Subtract(Vector4 v, int i)
		{
			return new Vector4(
				v.x - i,
				v.y - i,
				v.z - i,
				v.w - i
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Subtract(int i, Vector2 v)
		{
			return new Vector2(
				 i - v.x,
				 i - v.y
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Subtract(int i, Vector3 v)
		{
			return new Vector3(
				 i - v.x,
				 i - v.y,
				 i - v.z
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 Subtract(int i, Vector4 v)
		{
			return new Vector4(
				 i - v.x,
				 i - v.y,
				 i - v.z,
				 i - v.w
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Subtract(Vector2Int v, float f)
		{
			return new Vector2(
				v.x - f,
				v.y - f
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Subtract(Vector3Int v, float f)
		{
			return new Vector3(
				v.x - f,
				v.y - f,
				v.z - f
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Subtract(float f, Vector2Int v)
		{
			return new Vector2(
				 f - v.x,
				 f - v.y
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Subtract(float f, Vector3Int v)
		{
			return new Vector3(
				 f - v.x,
				 f - v.y,
				 f - v.z
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2Int Subtract(Vector2Int v, int i)
		{
			return new Vector2Int(
				v.x - i,
				v.y - i
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3Int Subtract(Vector3Int v, int i)
		{
			return new Vector3Int(
				v.x - i,
				v.y - i,
				v.z - i
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2Int Subtract(int i, Vector2Int v)
		{
			return new Vector2Int(
				 i - v.x,
				 i - v.y
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3Int Subtract(int i, Vector3Int v)
		{
			return new Vector3Int(
				 i - v.x,
				 i - v.y,
				 i - v.z
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
		public static Vector2 Multiply(Vector2 a, Vector2Int b)
		{
			return new Vector2(
				a.x * b.x,
				a.y * b.y
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
		public static Vector2 Multiply(Vector2Int a, Vector2 b)
		{
			return new Vector2(
				a.x * b.x,
				a.y * b.y
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
		public static Vector2 Multiply(Vector2 v, float f)
		{
			return new Vector2(
				v.x * f,
				v.y * f
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Multiply(Vector3 v, float f)
		{
			return new Vector3(
				v.x * f,
				v.y * f,
				v.z * f
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 Multiply(Vector4 v, float f)
		{
			return new Vector4(
				v.x * f,
				v.y * f,
				v.z * f,
				v.w * f
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Multiply(float f, Vector2 v)
		{
			return new Vector2(
				 f * v.x,
				 f * v.y
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Multiply(float f, Vector3 v)
		{
			return new Vector3(
				f * v.x,
				f * v.y,
				f * v.z
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 Multiply(float f, Vector4 v)
		{
			return new Vector4(
				f * v.x,
				f * v.y,
				f * v.z,
				f * v.w
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
		public static Vector3 Multiply(Vector3Int v, float f)
		{
			return new Vector3(
				v.x * f,
				v.y * f,
				v.z * f
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
		public static Vector3 Multiply(float f, Vector3Int v)
		{
			return new Vector3(
				f * v.x,
				f * v.y,
				f * v.z
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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Divide(Vector2 a, Vector2Int b)
		{
			return new Vector2(
				a.x / b.x,
				a.y / b.y
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
		public static Vector2 Divide(Vector2Int a, Vector2 b)
		{
			return new Vector2(
				a.x / b.x,
				a.y / b.y
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
		public static Vector2 Divide(Vector2 v, float f)
		{
			return new Vector2(
				v.x / f,
				v.y / f
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Divide(Vector3 v, float f)
		{
			return new Vector3(
				v.x / f,
				v.y / f,
				v.z / f
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 Divide(Vector4 v, float f)
		{
			return new Vector4(
				v.x / f,
				v.y / f,
				v.z / f,
				v.w / f
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Divide(float f, Vector2 v)
		{
			return new Vector2(
				f / v.x,
				f / v.y
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Divide(float f, Vector3 v)
		{
			return new Vector3(
				f / v.x,
				f / v.y,
				f / v.z
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 Divide(float f, Vector4 v)
		{
			return new Vector4(
				v.x / f,
				v.y / f,
				v.z / f,
				v.w / f
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
		public static Vector3 Divide(Vector3Int v, float f)
		{
			return new Vector3(
				v.x / f,
				v.y / f,
				v.z / f
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
		public static Vector3 Divide(float f, Vector3Int v)
		{
			return new Vector3(
				f / v.x,
				f / v.y,
				f / v.z
			);
		}
	}
}