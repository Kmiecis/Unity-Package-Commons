using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common
{
	[Serializable]
	public struct Range2Int : IEquatable<Range2Int>
	{
		public Vector2Int min;
		public Vector2Int max;

		public static readonly Range2Int Zero;

		public static readonly Range2Int Max = new Range2Int(
			Vector2Int.one * int.MinValue,
			Vector2Int.one * int.MaxValue
		);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Range2Int(Vector2Int min, Vector2Int max)
		{
			this.min = min;
			this.max = max;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Range2Int(int minX, int minY, int maxX, int maxY)
		{
			this.min = new Vector2Int(minX, minY);
			this.max = new Vector2Int(maxX, maxY);
		}

		public Vector2 Center
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get { return Mathx.Multiply((max + min), 0.5f); }
		}

		public Vector2Int Size
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get { return max - min; }
		}
		
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Contains(Vector2Int v)
		{
			return (
				Mathx.AreLesserOrEqual(min, v) &&
				Mathx.AreLesserOrEqual(v, max)
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Contains(Range2Int other)
		{
			return (
				Mathx.AreLesserOrEqual(min, other.min) &&
				Mathx.AreLesserOrEqual(other.max, max)
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Overlaps(Range2Int other)
		{
			return (
				Mathx.AreLesserOrEqual(min, other.max) &&
				Mathx.AreLesserOrEqual(other.min, max)
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Range2Int Intersection(Range2Int other)
		{
			return new Range2Int(
				Mathx.Max(min, other.min),
				Mathx.Min(max, other.max)
			);
		}

		public bool Equals(Range2Int other)
		{
			return (
				Mathx.AreEqual(min, other.min) &&
				Mathx.AreEqual(max, other.max)
			);
		}

		public override bool Equals(object obj)
		{
			return obj is Range2Int && Equals((Range2Int)obj);
		}

		public override int GetHashCode()
		{
			return min.GetHashCode() ^ (max.GetHashCode() << 2);
		}

		public override string ToString()
		{
			return string.Format("Range2Int({0}, {1})", min, max);
		}
	}
}