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
        public void Include(int i)
        {
            min = Math.Min(min, i);
            max = Math.Max(max, i);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Include(int otherMin, int otherMax)
        {
            min = Math.Min(min, otherMin);
            max = Math.Max(max, otherMax);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Include(RangeInt other)
        {
            Include(other.min, other.max);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Contains(int i)
        {
            return min <= i && i <= max;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Contains(int otherMin, int otherMax)
        {
            return min <= otherMin && otherMax <= max;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Contains(RangeInt other)
        {
            return Contains(other.min, other.max);
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(RangeInt other)
        {
            return (
                min == other.min &&
                max == other.max
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object obj)
        {
            return obj is RangeInt converted && Equals(converted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode()
        {
            return min.GetHashCode() ^ (max.GetHashCode() << 2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("RangeInt({0}, {1})", min, max);
        }
    }
}