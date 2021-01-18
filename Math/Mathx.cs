using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common
{
	public static partial class Mathx
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
		public static Vector2 Lerp(Vector2 a, Vector2 b, Vector2 t)
		{
			return a + Multiply(t, (b - a));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Lerp(Vector3 a, Vector3 b, Vector3 t)
		{
			return a + Multiply(t, b - a);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 Lerp(Vector4 a, Vector4 b, Vector4 t)
		{
			return a + Multiply(t, b - a);
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Unlerp(float a, float b, float t)
		{
			return (t - a) / (b - a);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Unlerp(Vector2 a, Vector2 b, Vector2 t)
		{
			return new Vector2(
				Unlerp(a.x, b.x, t.x),
				Unlerp(a.y, b.y, t.y)
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Unlerp(Vector3 a, Vector3 b, Vector3 t)
		{
			return new Vector3(
				Unlerp(a.x, b.x, t.x),
				Unlerp(a.y, b.y, t.y),
				Unlerp(a.z, b.z, t.z)
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 Unlerp(Vector4 a, Vector4 b, Vector4 t)
		{
			return new Vector4(
				Unlerp(a.x, b.x, t.x),
				Unlerp(a.y, b.y, t.y),
				Unlerp(a.z, b.z, t.z),
				Unlerp(a.w, b.w, t.w)
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
		public static Vector2 SmootherStep(Vector2 v)
		{
			return Multiply(v, Multiply(v, Multiply(v, Add(Multiply(v, Subtract(Multiply(v, 6), 15)), 10))));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 SmootherStep(Vector3 v)
		{
			return Multiply(v, Multiply(v, Multiply(v, Add(Multiply(v, Subtract(Multiply(v, 6), 15)), 10))));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 SmootherStep(Vector4 v)
		{
			return Multiply(v, Multiply(v, Multiply(v, Add(Multiply(v, Subtract(Multiply(v, 6), 15)), 10))));
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
		public static Vector2 Reciprocal(Vector2 v)
		{
			return Divide(1.0f, v);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Reciprocal(Vector3 v)
		{
			return Divide(1.0f, v);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 Reciprocal(Vector4 v)
		{
			return Divide(1.0f, v);
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float ReciprocalSafe(float f)
		{
			return Reciprocal(Mathf.Max(f, EPS));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 ReciprocalSafe(Vector2 v)
		{
			return Reciprocal(Vector2.Max(v, new Vector2(EPS, EPS)));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 ReciprocalSafe(Vector3 v)
		{
			return Reciprocal(Vector3.Max(v, new Vector3(EPS, EPS, EPS)));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 ReciprocalSafe(Vector4 v)
		{
			return Reciprocal(Vector4.Max(v, new Vector4(EPS, EPS, EPS, EPS)));
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
		public static int Select(int a, int b, bool c)
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
		public static Vector2 Select(Vector2 a, Vector2 b, bool c)
		{
			return c ? b : a;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2Int Select(Vector2Int a, Vector2Int b, Bool2 c)
		{
			return new Vector2Int(
				Select(a.x, b.x, c.x),
				Select(a.y, b.y, c.y)
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2Int Select(Vector2Int a, Vector2Int b, bool c)
		{
			return c ? b : a;
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
		public static Vector3 Select(Vector3 a, Vector3 b, bool c)
		{
			return c ? b : a;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3Int Select(Vector3Int a, Vector3Int b, Bool3 c)
		{
			return new Vector3Int(
				Select(a.x, b.x, c.x),
				Select(a.y, b.y, c.y),
				Select(a.z, b.z, c.z)
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3Int Select(Vector3Int a, Vector3Int b, bool c)
		{
			return c ? b : a;
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
		public static int Step(int a, int b)
		{
			return Select(0, 1, b >= a);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Step(Vector2 a, Vector2 b)
		{
			return new Vector2(
				Step(a.x, b.x),
				Step(a.y, b.y)
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2Int Step(Vector2Int a, Vector2Int b)
		{
			return new Vector2Int(
				Step(a.x, b.x),
				Step(a.y, b.y)
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Step(Vector3 a, Vector3 b)
		{
			return new Vector3(
				Step(a.x, b.x),
				Step(a.y, b.y),
				Step(a.z, b.z)
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3Int Step(Vector3Int a, Vector3Int b)
		{
			return new Vector3Int(
				Step(a.x, b.x),
				Step(a.y, b.y),
				Step(a.z, b.z)
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 Step(Vector4 a, Vector4 b)
		{
			return new Vector4(
				Step(a.x, b.x),
				Step(a.y, b.y),
				Step(a.z, b.z),
				Step(a.w, b.w)
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


		/// <summary> Returns the componentwise minimum of two Vector2 vectors </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Min(Vector2 a, Vector2 b)
		{
			return new Vector2(
				Mathf.Min(a.x, b.x),
				Mathf.Min(a.y, b.y)
			);
		}

		/// <summary> Returns the componentwise minimum of a Vector2 vector and a float value </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Min(Vector2 v, float f)
		{
			return new Vector2(
				Mathf.Min(v.x, f),
				Mathf.Min(v.y, f)
			);
		}

		/// <summary> Returns the componentwise minimum of a float value and a Vector2 vector </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Min(float f, Vector2 v)
		{
			return new Vector2(
				Mathf.Min(f, v.x),
				Mathf.Min(f, v.y)
			);
		}

		/// <summary> Returns the componentwise minimum of two Vector2Int vectors </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2Int Min(Vector2Int a, Vector2Int b)
		{
			return new Vector2Int(
				Mathf.Min(a.x, b.x),
				Mathf.Min(a.y, b.y)
			);
		}

		/// <summary> Returns the componentwise minimum of a Vector2Int vector and an int value </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2Int Min(Vector2Int v, int i)
		{
			return new Vector2Int(
				Mathf.Min(v.x, i),
				Mathf.Min(v.y, i)
			);
		}

		/// <summary> Returns the componentwise minimum of an int value and a Vector2Int vector </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2Int Min(int i, Vector2Int v)
		{
			return new Vector2Int(
				Mathf.Min(i, v.x),
				Mathf.Min(i, v.y)
			);
		}

		/// <summary> Returns the componentwise minimum of two Vector3 vectors </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Min(Vector3 a, Vector3 b)
		{
			return new Vector3(
				Mathf.Min(a.x, b.x),
				Mathf.Min(a.y, b.y),
				Mathf.Min(a.z, b.z)
			);
		}

		/// <summary> Returns the componentwise minimum of a Vector3 vector and a float value </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Min(Vector3 v, float f)
		{
			return new Vector3(
				Mathf.Min(v.x, f),
				Mathf.Min(v.y, f),
				Mathf.Min(v.z, f)
			);
		}

		/// <summary> Returns the componentwise minimum of a float value and a Vector3 vector </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Min(float f, Vector3 v)
		{
			return new Vector3(
				Mathf.Min(f, v.x),
				Mathf.Min(f, v.y),
				Mathf.Min(f, v.z)
			);
		}

		/// <summary> Returns the componentwise minimum of two Vector3Int vectors </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3Int Min(Vector3Int a, Vector3Int b)
		{
			return new Vector3Int(
				Mathf.Min(a.x, b.x),
				Mathf.Min(a.y, b.y),
				Mathf.Min(a.z, b.z)
			);
		}

		/// <summary> Returns the componentwise minimum of a Vector3Int vector and an int value </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3Int Min(Vector3Int v, int i)
		{
			return new Vector3Int(
				Mathf.Min(v.x, i),
				Mathf.Min(v.y, i),
				Mathf.Min(v.z, i)
			);
		}

		/// <summary> Returns the componentwise minimum of an int value and a Vector3Int vector </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3Int Min(int i, Vector3Int v)
		{
			return new Vector3Int(
				Mathf.Min(i, v.x),
				Mathf.Min(i, v.y),
				Mathf.Min(i, v.z)
			);
		}

		/// <summary> Returns the componentwise minimum of two Vector4 vectors </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 Min(Vector4 a, Vector4 b)
		{
			return new Vector4(
				Mathf.Min(a.x, b.x),
				Mathf.Min(a.y, b.y),
				Mathf.Min(a.z, b.z),
				Mathf.Min(a.w, b.w)
			);
		}

		/// <summary> Returns the componentwise minimum of a Vector4 vector and a float value </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 Min(Vector4 v, float f)
		{
			return new Vector4(
				Mathf.Min(v.x, f),
				Mathf.Min(v.y, f),
				Mathf.Min(v.z, f),
				Mathf.Min(v.w, f)
			);
		}

		/// <summary> Returns the componentwise minimum of a float value and a Vector4 vector </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 Min(float f, Vector4 v)
		{
			return new Vector4(
				Mathf.Min(f, v.x),
				Mathf.Min(f, v.y),
				Mathf.Min(f, v.z),
				Mathf.Min(f, v.w)
			);
		}


		/// <summary> Returns the componentwise maximum of two Vector2 vectors </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Max(Vector2 a, Vector2 b)
		{
			return new Vector2(
				Mathf.Max(a.x, b.x),
				Mathf.Max(a.y, b.y)
			);
		}

		/// <summary> Returns the componentwise maximum of a Vector2 vector and a float value </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Max(Vector2 v, float f)
		{
			return new Vector2(
				Mathf.Max(v.x, f),
				Mathf.Max(v.y, f)
			);
		}

		/// <summary> Returns the componentwise maximum of a float value and a Vector2 vector </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Max(float f, Vector2 v)
		{
			return new Vector2(
				Mathf.Max(f, v.x),
				Mathf.Max(f, v.y)
			);
		}

		/// <summary> Returns the componentwise maximum of two Vector2Int vectors </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2Int Max(Vector2Int a, Vector2Int b)
		{
			return new Vector2Int(
				Mathf.Max(a.x, b.x),
				Mathf.Max(a.y, b.y)
			);
		}

		/// <summary> Returns the componentwise maximum of a Vector2Int vector and an int value </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2Int Max(Vector2Int v, int i)
		{
			return new Vector2Int(
				Mathf.Max(v.x, i),
				Mathf.Max(v.y, i)
			);
		}

		/// <summary> Returns the componentwise maximum of an int value and a Vector2Int vector </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2Int Max(int i, Vector2Int v)
		{
			return new Vector2Int(
				Mathf.Max(i, v.x),
				Mathf.Max(i, v.y)
			);
		}

		/// <summary> Returns the componentwise maximum of two Vector3 vectors </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Max(Vector3 a, Vector3 b)
		{
			return new Vector3(
				Mathf.Max(a.x, b.x),
				Mathf.Max(a.y, b.y),
				Mathf.Max(a.z, b.z)
			);
		}

		/// <summary> Returns the componentwise maximum of a Vector3 vector and a float value </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Max(Vector3 v, float f)
		{
			return new Vector3(
				Mathf.Max(v.x, f),
				Mathf.Max(v.y, f),
				Mathf.Max(v.z, f)
			);
		}

		/// <summary> Returns the componentwise maximum of a float value and a Vector3 vector </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Max(float f, Vector3 v)
		{
			return new Vector3(
				Mathf.Max(f, v.x),
				Mathf.Max(f, v.y),
				Mathf.Max(f, v.z)
			);
		}

		/// <summary> Returns the componentwise maximum of two Vector3Int vectors </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3Int Max(Vector3Int a, Vector3Int b)
		{
			return new Vector3Int(
				Mathf.Max(a.x, b.x),
				Mathf.Max(a.y, b.y),
				Mathf.Max(a.z, b.z)
			);
		}

		/// <summary> Returns the componentwise maximum of a Vector3Int vector and an int value </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3Int Max(Vector3Int v, int i)
		{
			return new Vector3Int(
				Mathf.Max(v.x, i),
				Mathf.Max(v.y, i),
				Mathf.Max(v.z, i)
			);
		}

		/// <summary> Returns the componentwise maximum of an int value and a Vector3Int vector </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3Int Max(int i, Vector3Int v)
		{
			return new Vector3Int(
				Mathf.Max(i, v.x),
				Mathf.Max(i, v.y),
				Mathf.Max(i, v.z)
			);
		}

		/// <summary> Returns the componentwise maximum of two Vector4 vectors </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 Max(Vector4 a, Vector4 b)
		{
			return new Vector4(
				Mathf.Max(a.x, b.x),
				Mathf.Max(a.y, b.y),
				Mathf.Max(a.z, b.z),
				Mathf.Max(a.w, b.w)
			);
		}

		/// <summary> Returns the componentwise maximum of a Vector4 vector and a float value </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 Max(Vector4 v, float f)
		{
			return new Vector4(
				Mathf.Max(v.x, f),
				Mathf.Max(v.y, f),
				Mathf.Max(v.z, f),
				Mathf.Max(v.w, f)
			);
		}

		/// <summary> Returns the componentwise maximum of a float value and a Vector4 vector </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 Max(float f, Vector4 v)
		{
			return new Vector4(
				Mathf.Max(f, v.x),
				Mathf.Max(f, v.y),
				Mathf.Max(f, v.z),
				Mathf.Max(f, v.w)
			);
		}
	}
}