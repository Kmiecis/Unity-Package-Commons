using System;
using System.Runtime.CompilerServices;

namespace Common.Mathematics
{
    [Serializable]
    public struct RangeInt : IEquatable<RangeInt>
    {
        public int min;
        public int max;

        public static readonly RangeInt Zero;
        public static readonly RangeInt One = new RangeInt(0, 1);
        public static readonly RangeInt Max = new RangeInt(int.MinValue, int.MaxValue);
        public static readonly RangeInt Empty = new RangeInt(int.MaxValue, int.MinValue);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RangeInt(int min, int max)
        {
            this.min = min;
            this.max = max;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Range(RangeInt ri)
        {
            Range r;
            r.min = ri.min;
            r.max = ri.max;
            return r;
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
        public bool Overlaps(int otherMin, int otherMax)
        {
            return min <= otherMax && otherMin <= max;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Overlaps(RangeInt other)
        {
            return Overlaps(other.min, other.max);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RangeInt Intersection(RangeInt other)
        {
            RangeInt r;
            r.min = Math.Max(min, other.min);
            r.max = Math.Min(max, other.max);
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Validate()
        {
            min = Math.Min(min, max);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(RangeInt other)
        {
            return (
                min == other.min &&
                max == other.max
            );
        }

        public override bool Equals(object obj)
        {
            return obj is RangeInt other && Equals(other);
        }

        public override int GetHashCode()
        {
            return (
                min.GetHashCode() ^
                (max.GetHashCode() << 2)
            );
        }

        public override string ToString()
        {
            return string.Format("({0}, {1})", min, max);
        }
    }
}
