using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common
{
	[Serializable]
	public struct Range2 : IEquatable<Range2>
	{
		public Vector2 min;
		public Vector2 max;

		public static readonly Range2 Zero;

		public static readonly Range2 Max = new Range2(
			Vector2.one * float.MinValue,
			Vector2.one * float.MaxValue
		);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Range2(Vector2 min, Vector2 max)
		{
			this.min = min;
			this.max = max;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Range2(float minX, float minY, float maxX, float maxY)
		{
			this.min = new Vector2(minX, minY);
			this.max = new Vector2(maxX, maxY);
		}

		public Vector2 Center
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get { return (max + min) * 0.5f; }
		}

		public Vector2 Size
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get { return max - min; }
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Contains(Vector2 v)
		{
			return (
				Mathx.AreLesserOrEqual(min, v) &&
				Mathx.AreLesserOrEqual(v, max)
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Contains(Range2 other)
		{
			return (
				Mathx.AreLesserOrEqual(min, other.min) &&
				Mathx.AreLesserOrEqual(other.max, max)
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Overlaps(Range2 other)
		{
			return (
				Mathx.AreLesserOrEqual(min, other.max) &&
				Mathx.AreLesserOrEqual(other.min, max)
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Range2 Intersection(Range2 other)
		{
			return new Range2(
				Mathx.Max(min, other.min),
				Mathx.Min(max, other.max)
			);
		}

		public bool Equals(Range2 other)
		{
			return (
				Mathx.AreEqual(min, other.min) &&
				Mathx.AreEqual(max, other.max)
			);
		}

		public override bool Equals(object obj)
		{
			return obj is Range2 && Equals((Range2)obj);
		}

		public override int GetHashCode()
		{
			return min.GetHashCode() ^ (max.GetHashCode() << 2);
		}

		public override string ToString()
		{
			return string.Format("Range2({0}, {1})", min, max);
		}
	}
}