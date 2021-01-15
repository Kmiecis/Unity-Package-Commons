using System;
using System.Runtime.CompilerServices;

namespace Common
{
	[Serializable]
	public struct Range : IEquatable<Range>
	{
		public float min;
		public float max;

		public static readonly Range Max = new Range(
			float.MinValue,
			float.MaxValue
		);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Range(float min, float max)
		{
			this.min = min;
			this.max = max;
		}

		public float Length
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get { return max - min; }
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Contains(float f)
		{
			return min <= f && f <= max;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Contains(Range other)
		{
			return min <= other.min && other.max <= max;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Overlaps(Range other)
		{
			return min <= other.max && other.min <= max;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Range Intersection(Range other)
		{
			return new Range(
				Math.Max(min, other.min),
				Math.Min(max, other.max)
			);
		}

		public bool Equals(Range other)
		{
			return (
				Mathx.AreEqual(min, other.min) &&
				Mathx.AreEqual(max, other.max)
			);
		}

		public override bool Equals(object obj)
		{
			return obj is Range && Equals((Range)obj);
		}

		public override int GetHashCode()
		{
			return min.GetHashCode() ^ (max.GetHashCode() << 2);
		}

		public override string ToString()
		{
			return string.Format("Range({0}, {1})", min, max);
		}
	}
}