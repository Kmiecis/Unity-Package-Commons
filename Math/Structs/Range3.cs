using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common
{
	[Serializable]
	public struct Range3 : IEquatable<Range3>
	{
		public Vector3 min;
		public Vector3 max;

		public static readonly Range3 Zero;

		public static readonly Range3 Max = new Range3(
			Vector3.one * float.MinValue,
			Vector3.one * float.MaxValue
		);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Range3(Vector3 min, Vector3 max)
		{
			this.min = min;
			this.max = max;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Range3(float minX, float minY, float minZ, float maxX, float maxY, float maxZ)
		{
			this.min = new Vector3(minX, minY, minZ);
			this.max = new Vector3(maxX, maxY, maxZ);
		}

		public Vector3 Center
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get { return (max + min) * 0.5f; }
		}

		public Vector3 Extents
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get { return max - min; }
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Contains(Vector3 v)
		{
			return (
				Mathx.AreLesserOrEqual(min, v) &&
				Mathx.AreLesserOrEqual(v, max)
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Contains(Range3 other)
		{
			return (
				Mathx.AreLesserOrEqual(min, other.min) &&
				Mathx.AreLesserOrEqual(other.max, max)
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Overlaps(Range3 other)
		{
			return (
				Mathx.AreLesserOrEqual(min, other.max) &&
				Mathx.AreLesserOrEqual(other.min, max)
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Range3 Intersection(Range3 other)
		{
			return new Range3(
				Mathx.Max(min, other.min),
				Mathx.Min(max, other.max)
			);
		}

		public bool Equals(Range3 other)
		{
			return (
				Mathx.AreEqual(min, other.min) &&
				Mathx.AreEqual(max, other.max)
			);
		}

		public override bool Equals(object obj)
		{
			return obj is Range3 && Equals((Range3)obj);
		}

		public override int GetHashCode()
		{
			return min.GetHashCode() ^ (max.GetHashCode() << 2);
		}

		public override string ToString()
		{
			return string.Format("Range3({0}, {1})", min, max);
		}
	}
}