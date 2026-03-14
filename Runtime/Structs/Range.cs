using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common
{
    [Serializable]
    public struct Range : IEquatable<Range>
    {
        public float min;
        public float max;

        public static readonly Range Zero;
        public static readonly Range One = new Range(0.0f, 1.0f);
        public static readonly Range Max = new Range(float.MinValue, float.MaxValue);
        public static readonly Range Empty = new Range(float.MaxValue, float.MinValue);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Range(float min, float max)
        {
            this.min = min;
            this.max = max;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator RangeInt(Range r)
        {
            RangeInt ri;
            ri.min = Mathf.RoundToInt(r.min);
            ri.max = Mathf.RoundToInt(r.max);
            return ri;
        }

        public readonly float Center
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (max + min) * 0.5f;
        }

        public readonly float Length
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => max - min;
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
        public readonly bool Contains(float f)
        {
            return min <= f && f <= max;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Contains(float otherMin, float otherMax)
        {
            return min <= otherMin && otherMax <= max;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Contains(Range other)
        {
            return Contains(other.min, other.max);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Overlaps(float otherMin, float otherMax)
        {
            return min <= otherMax && otherMin <= max;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Overlaps(Range other)
        {
            return Overlaps(other.min, other.max);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Range Intersection(Range other)
        {
            Range r;
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
        public static bool operator ==(Range l, Range r)
        {
            return (
                l.min == r.min &&
                l.max == r.max
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Range l, Range r)
        {
            return !(l == r);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Range other)
        {
            return (
                Mathf.Approximately(min, other.min) &&
                Mathf.Approximately(max, other.max)
            );
        }

        public override readonly bool Equals(object obj)
        {
            return obj is Range other && Equals(other);
        }

        public override readonly int GetHashCode()
        {
            return (
                min.GetHashCode() ^
                (max.GetHashCode() << 2)
            );
        }

        public override readonly string ToString()
        {
            return ToString("F2");
        }

        public readonly string ToString(string format)
        {
            return string.Format("({0}, {1})", min.ToString(format), max.ToString(format));
        }
    }
}
