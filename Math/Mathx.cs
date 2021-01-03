using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common.Mathematics
{
	public static class Mathx
	{
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