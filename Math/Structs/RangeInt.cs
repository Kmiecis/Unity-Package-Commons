using System;
using System.Runtime.CompilerServices;

namespace Common
{
	[Serializable]
	public struct RangeInt : IEquatable<RangeInt>
	{
		public int min;
		public int max;

		public static readonly RangeInt Zero;

		public static readonly RangeInt Max = new RangeInt(
			int.MinValue,
			int.MaxValue
		);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public RangeInt(int min, int max)
		{
			this.min = min;
			this.max = max;
		}

		public float Center
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get { return (max + min) * 0.5f; }
		}

		public int Length
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get { return max - min; }
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Contains(int i)
		{
			return min <= i && i <= max;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Contains(RangeInt other)
		{
			return min <= other.min && other.max <= max;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Overlaps(RangeInt other)
		{
			return min <= other.max && other.min <= max;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public RangeInt Intersection(RangeInt other)
		{
			return new RangeInt(
				Math.Max(min, other.min),
				Math.Min(max, other.max)
			);
		}

		public bool Equals(RangeInt other)
		{
			return (
				min == other.min &&
				max == other.max
			);
		}

		public override bool Equals(object obj)
		{
			return obj is RangeInt && Equals((RangeInt)obj);
		}

		public override int GetHashCode()
		{
			return min.GetHashCode() ^ (max.GetHashCode() << 2);
		}

		public override string ToString()
		{
			return string.Format("RangeInt({0}, {1})", min, max);
		}
	}
}