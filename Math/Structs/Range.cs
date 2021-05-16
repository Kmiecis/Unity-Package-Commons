using System;
using System.Runtime.CompilerServices;

namespace Common
{
    [Serializable]
    public struct Range : IEquatable<Range>
    {
        public float min;
        public float max;

        public static readonly Range Zero;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Range(float min, float max)
        {
            this.min = min;
            this.max = max;
        }

        public float Center
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return (max + min) * 0.5f; }
        }

        public float Length
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return max - min; }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Include(float f)
        {
            min = Math.Min(min, f);
            max = Math.Max(max, f);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Include(float otherMin, float otherMax)
        {
            min = Math.Min(min, otherMin);
            max = Math.Max(max, otherMax);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Include(Range other)
        {
            Include(other.min, other.max);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Contains(float f)
        {
            return min <= f && f <= max;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Contains(float otherMin, float otherMax)
        {
            return min <= otherMin && otherMax <= max;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Contains(Range other)
        {
            return Contains(other.min, other.max);
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Range other)
        {
            return (
                Mathx.AreEqual(min, other.min) &&
                Mathx.AreEqual(max, other.max)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object obj)
        {
            return obj is Range converted && Equals(converted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode()
        {
            return min.GetHashCode() ^ (max.GetHashCode() << 2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("Range({0}, {1})", min, max);
        }
    }
}