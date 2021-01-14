using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common
{
	public static partial class Mathx
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool2 IsGreater(Vector2 a, Vector2 b)
		{
			return new Bool2(
				a.x > b.x,
				a.y > b.y
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool2 IsGreater(Vector2 v, float f)
		{
			return new Bool2(
				v.x > f,
				v.y > f
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool2 IsGreater(Vector2 v, int i)
		{
			return new Bool2(
				v.x > i,
				v.y > i
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool2 IsGreater(float f, Vector2 v)
		{
			return new Bool2(
				f > v.x,
				f > v.y
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool2 IsGreater(int i, Vector2 v)
		{
			return new Bool2(
				i > v.x,
				i > v.y
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool3 IsGreater(Vector3 a, Vector3 b)
		{
			return new Bool3(
				a.x > b.x,
				a.y > b.y,
				a.z > b.z
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool3 IsGreater(Vector3 v, float f)
		{
			return new Bool3(
				v.x > f,
				v.y > f,
				v.z > f
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool3 IsGreater(Vector3 v, int i)
		{
			return new Bool3(
				v.x > i,
				v.y > i,
				v.z > i
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool3 IsGreater(float f, Vector3 v)
		{
			return new Bool3(
				f > v.x,
				f > v.y,
				f > v.z
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool3 IsGreater(int i, Vector3 v)
		{
			return new Bool3(
				i > v.x,
				i > v.y,
				i > v.z
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool4 IsGreater(Vector4 a, Vector4 b)
		{
			return new Bool4(
				a.x > b.x,
				a.y > b.y,
				a.z > b.z,
				a.w > b.w
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool4 IsGreater(Vector4 v, float f)
		{
			return new Bool4(
				v.x > f,
				v.y > f,
				v.z > f,
				v.w > f
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool4 IsGreater(Vector4 v, int i)
		{
			return new Bool4(
				v.x > i,
				v.y > i,
				v.z > i,
				v.w > i
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool4 IsGreater(float f, Vector4 v)
		{
			return new Bool4(
				f > v.x,
				f > v.y,
				f > v.z,
				f > v.w
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool4 IsGreater(int i, Vector4 v)
		{
			return new Bool4(
				i > v.x,
				i > v.y,
				i > v.z,
				i > v.w
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool2 IsGreater(Vector2Int a, Vector2Int b)
		{
			return new Bool2(
				a.x > b.x,
				a.y > b.y
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool2 IsGreater(Vector2Int v, float f)
		{
			return new Bool2(
				v.x > f,
				v.y > f
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool2 IsGreater(Vector2Int v, int i)
		{
			return new Bool2(
				v.x > i,
				v.y > i
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool2 IsGreater(float f, Vector2Int v)
		{
			return new Bool2(
				f > v.x,
				f > v.y
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool2 IsGreater(int i, Vector2Int v)
		{
			return new Bool2(
				i > v.x,
				i > v.y
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool3 IsGreater(Vector3Int a, Vector3Int b)
		{
			return new Bool3(
				a.x > b.x,
				a.y > b.y,
				a.z > b.z
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool3 IsGreater(Vector3Int v, float f)
		{
			return new Bool3(
				v.x > f,
				v.y > f,
				v.z > f
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool3 IsGreater(Vector3Int v, int i)
		{
			return new Bool3(
				v.x > i,
				v.y > i,
				v.z > i
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool3 IsGreater(float f, Vector3Int v)
		{
			return new Bool3(
				f > v.x,
				f > v.y,
				f > v.z
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool3 IsGreater(int i, Vector3Int v)
		{
			return new Bool3(
				i > v.x,
				i > v.y,
				i > v.z
			);
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool2 IsGreaterOrEqual(Vector2 a, Vector2 b)
		{
			return new Bool2(
				a.x >= b.x,
				a.y >= b.y
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool2 IsGreaterOrEqual(Vector2 v, float f)
		{
			return new Bool2(
				v.x >= f,
				v.y >= f
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool2 IsGreaterOrEqual(Vector2 v, int i)
		{
			return new Bool2(
				v.x >= i,
				v.y >= i
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool2 IsGreaterOrEqual(float f, Vector2 v)
		{
			return new Bool2(
				f >= v.x,
				f >= v.y
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool2 IsGreaterOrEqual(int i, Vector2 v)
		{
			return new Bool2(
				i >= v.x,
				i >= v.y
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool3 IsGreaterOrEqual(Vector3 a, Vector3 b)
		{
			return new Bool3(
				a.x >= b.x,
				a.y >= b.y,
				a.z >= b.z
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool3 IsGreaterOrEqual(Vector3 v, float f)
		{
			return new Bool3(
				v.x >= f,
				v.y >= f,
				v.z >= f
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool3 IsGreaterOrEqual(Vector3 v, int i)
		{
			return new Bool3(
				v.x >= i,
				v.y >= i,
				v.z >= i
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool3 IsGreaterOrEqual(float f, Vector3 v)
		{
			return new Bool3(
				f >= v.x,
				f >= v.y,
				f >= v.z
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool3 IsGreaterOrEqual(int i, Vector3 v)
		{
			return new Bool3(
				i >= v.x,
				i >= v.y,
				i >= v.z
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool4 IsGreaterOrEqual(Vector4 a, Vector4 b)
		{
			return new Bool4(
				a.x >= b.x,
				a.y >= b.y,
				a.z >= b.z,
				a.w >= b.w
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool4 IsGreaterOrEqual(Vector4 v, float f)
		{
			return new Bool4(
				v.x >= f,
				v.y >= f,
				v.z >= f,
				v.w >= f
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool4 IsGreaterOrEqual(Vector4 v, int i)
		{
			return new Bool4(
				v.x >= i,
				v.y >= i,
				v.z >= i,
				v.w >= i
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool4 IsGreaterOrEqual(float f, Vector4 v)
		{
			return new Bool4(
				f >= v.x,
				f >= v.y,
				f >= v.z,
				f >= v.w
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool4 IsGreaterOrEqual(int i, Vector4 v)
		{
			return new Bool4(
				i >= v.x,
				i >= v.y,
				i >= v.z,
				i >= v.w
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool2 IsGreaterOrEqual(Vector2Int a, Vector2Int b)
		{
			return new Bool2(
				a.x >= b.x,
				a.y >= b.y
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool2 IsGreaterOrEqual(Vector2Int v, float f)
		{
			return new Bool2(
				v.x >= f,
				v.y >= f
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool2 IsGreaterOrEqual(Vector2Int v, int i)
		{
			return new Bool2(
				v.x >= i,
				v.y >= i
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool2 IsGreaterOrEqual(float f, Vector2Int v)
		{
			return new Bool2(
				f >= v.x,
				f >= v.y
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool2 IsGreaterOrEqual(int i, Vector2Int v)
		{
			return new Bool2(
				i >= v.x,
				i >= v.y
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool3 IsGreaterOrEqual(Vector3Int a, Vector3Int b)
		{
			return new Bool3(
				a.x >= b.x,
				a.y >= b.y,
				a.z >= b.z
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool3 IsGreaterOrEqual(Vector3Int v, float f)
		{
			return new Bool3(
				v.x >= f,
				v.y >= f,
				v.z >= f
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool3 IsGreaterOrEqual(Vector3Int v, int i)
		{
			return new Bool3(
				v.x >= i,
				v.y >= i,
				v.z >= i
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool3 IsGreaterOrEqual(float f, Vector3Int v)
		{
			return new Bool3(
				f >= v.x,
				f >= v.y,
				f >= v.z
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool3 IsGreaterOrEqual(int i, Vector3Int v)
		{
			return new Bool3(
				i >= v.x,
				i >= v.y,
				i >= v.z
			);
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool2 IsLesser(Vector2 a, Vector2 b)
		{
			return new Bool2(
				a.x < b.x,
				a.y < b.y
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool2 IsLesser(Vector2 v, float f)
		{
			return new Bool2(
				v.x < f,
				v.y < f
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool2 IsLesser(Vector2 v, int i)
		{
			return new Bool2(
				v.x < i,
				v.y < i
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool2 IsLesser(float f, Vector2 v)
		{
			return new Bool2(
				f < v.x,
				f < v.y
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool2 IsLesser(int i, Vector2 v)
		{
			return new Bool2(
				i < v.x,
				i < v.y
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool3 IsLesser(Vector3 a, Vector3 b)
		{
			return new Bool3(
				a.x < b.x,
				a.y < b.y,
				a.z < b.z
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool3 IsLesser(Vector3 v, float f)
		{
			return new Bool3(
				v.x < f,
				v.y < f,
				v.z < f
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool3 IsLesser(Vector3 v, int i)
		{
			return new Bool3(
				v.x < i,
				v.y < i,
				v.z < i
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool3 IsLesser(float f, Vector3 v)
		{
			return new Bool3(
				f < v.x,
				f < v.y,
				f < v.z
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool3 IsLesser(int i, Vector3 v)
		{
			return new Bool3(
				i < v.x,
				i < v.y,
				i < v.z
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool4 IsLesser(Vector4 a, Vector4 b)
		{
			return new Bool4(
				a.x < b.x,
				a.y < b.y,
				a.z < b.z,
				a.w < b.w
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool4 IsLesser(Vector4 v, float f)
		{
			return new Bool4(
				v.x < f,
				v.y < f,
				v.z < f,
				v.w < f
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool4 IsLesser(Vector4 v, int i)
		{
			return new Bool4(
				v.x < i,
				v.y < i,
				v.z < i,
				v.w < i
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool4 IsLesser(float f, Vector4 v)
		{
			return new Bool4(
				f < v.x,
				f < v.y,
				f < v.z,
				f < v.w
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool4 IsLesser(int i, Vector4 v)
		{
			return new Bool4(
				i < v.x,
				i < v.y,
				i < v.z,
				i < v.w
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool2 IsLesser(Vector2Int a, Vector2Int b)
		{
			return new Bool2(
				a.x < b.x,
				a.y < b.y
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool2 IsLesser(Vector2Int v, float f)
		{
			return new Bool2(
				v.x < f,
				v.y < f
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool2 IsLesser(Vector2Int v, int i)
		{
			return new Bool2(
				v.x < i,
				v.y < i
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool2 IsLesser(float f, Vector2Int v)
		{
			return new Bool2(
				f < v.x,
				f < v.y
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool2 IsLesser(int i, Vector2Int v)
		{
			return new Bool2(
				i < v.x,
				i < v.y
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool3 IsLesser(Vector3Int a, Vector3Int b)
		{
			return new Bool3(
				a.x < b.x,
				a.y < b.y,
				a.z < b.z
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool3 IsLesser(Vector3Int v, float f)
		{
			return new Bool3(
				v.x < f,
				v.y < f,
				v.z < f
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool3 IsLesser(Vector3Int v, int i)
		{
			return new Bool3(
				v.x < i,
				v.y < i,
				v.z < i
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool3 IsLesser(float f, Vector3Int v)
		{
			return new Bool3(
				f < v.x,
				f < v.y,
				f < v.z
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool3 IsLesser(int i, Vector3Int v)
		{
			return new Bool3(
				i < v.x,
				i < v.y,
				i < v.z
			);
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool2 IsLesserOrEqual(Vector2 a, Vector2 b)
		{
			return new Bool2(
				a.x <= b.x,
				a.y <= b.y
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool2 IsLesserOrEqual(Vector2 v, float f)
		{
			return new Bool2(
				v.x <= f,
				v.y <= f
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool2 IsLesserOrEqual(Vector2 v, int i)
		{
			return new Bool2(
				v.x <= i,
				v.y <= i
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool2 IsLesserOrEqual(float f, Vector2 v)
		{
			return new Bool2(
				f <= v.x,
				f <= v.y
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool2 IsLesserOrEqual(int i, Vector2 v)
		{
			return new Bool2(
				i <= v.x,
				i <= v.y
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool3 IsLesserOrEqual(Vector3 a, Vector3 b)
		{
			return new Bool3(
				a.x <= b.x,
				a.y <= b.y,
				a.z <= b.z
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool3 IsLesserOrEqual(Vector3 v, float f)
		{
			return new Bool3(
				v.x <= f,
				v.y <= f,
				v.z <= f
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool3 IsLesserOrEqual(Vector3 v, int i)
		{
			return new Bool3(
				v.x <= i,
				v.y <= i,
				v.z <= i
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool3 IsLesserOrEqual(float f, Vector3 v)
		{
			return new Bool3(
				f <= v.x,
				f <= v.y,
				f <= v.z
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool3 IsLesserOrEqual(int i, Vector3 v)
		{
			return new Bool3(
				i <= v.x,
				i <= v.y,
				i <= v.z
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool4 IsLesserOrEqual(Vector4 a, Vector4 b)
		{
			return new Bool4(
				a.x <= b.x,
				a.y <= b.y,
				a.z <= b.z,
				a.w <= b.w
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool4 IsLesserOrEqual(Vector4 v, float f)
		{
			return new Bool4(
				v.x <= f,
				v.y <= f,
				v.z <= f,
				v.w <= f
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool4 IsLesserOrEqual(Vector4 v, int i)
		{
			return new Bool4(
				v.x <= i,
				v.y <= i,
				v.z <= i,
				v.w <= i
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool4 IsLesserOrEqual(float f, Vector4 v)
		{
			return new Bool4(
				f <= v.x,
				f <= v.y,
				f <= v.z,
				f <= v.w
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool4 IsLesserOrEqual(int i, Vector4 v)
		{
			return new Bool4(
				i <= v.x,
				i <= v.y,
				i <= v.z,
				i <= v.w
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool2 IsLesserOrEqual(Vector2Int a, Vector2Int b)
		{
			return new Bool2(
				a.x <= b.x,
				a.y <= b.y
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool2 IsLesserOrEqual(Vector2Int v, float f)
		{
			return new Bool2(
				v.x <= f,
				v.y <= f
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool2 IsLesserOrEqual(Vector2Int v, int i)
		{
			return new Bool2(
				v.x <= i,
				v.y <= i
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool2 IsLesserOrEqual(float f, Vector2Int v)
		{
			return new Bool2(
				f <= v.x,
				f <= v.y
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool2 IsLesserOrEqual(int i, Vector2Int v)
		{
			return new Bool2(
				i <= v.x,
				i <= v.y
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool3 IsLesserOrEqual(Vector3Int a, Vector3Int b)
		{
			return new Bool3(
				a.x <= b.x,
				a.y <= b.y,
				a.z <= b.z
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool3 IsLesserOrEqual(Vector3Int v, float f)
		{
			return new Bool3(
				v.x <= f,
				v.y <= f,
				v.z <= f
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool3 IsLesserOrEqual(Vector3Int v, int i)
		{
			return new Bool3(
				v.x <= i,
				v.y <= i,
				v.z <= i
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool3 IsLesserOrEqual(float f, Vector3Int v)
		{
			return new Bool3(
				f <= v.x,
				f <= v.y,
				f <= v.z
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Bool3 IsLesserOrEqual(int i, Vector3Int v)
		{
			return new Bool3(
				i <= v.x,
				i <= v.y,
				i <= v.z
			);
		}
	}
}