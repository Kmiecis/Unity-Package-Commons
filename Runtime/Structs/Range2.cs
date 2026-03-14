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
        public static readonly Range2 One = new Range2(Vector2.zero, Vector2.one);
        public static readonly Range2 Max = new Range2(Vector2.one * float.MinValue, Vector2.one * float.MaxValue);
        public static readonly Range2 Empty = new Range2(Vector2.one * float.MaxValue, Vector2.one * float.MinValue);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Range2(Vector2 min, Vector2 max)
        {
            this.min = min;
            this.max = max;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Range2(float minX, float minY, float maxX, float maxY) :
            this(new Vector2(minX, minY), new Vector2(maxX, maxY))
        {
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Range2Int(Range2 r)
        {
            return new Range2Int(
                Mathx.RoundToInt(r.min),
                Mathx.RoundToInt(r.max)
            );
        }

        public readonly Vector2 Center
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => max.Add(min).Mul(0.5f);
        }

        public readonly Vector2 Size
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => max.Sub(min);
        }

        public readonly float Width
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => max.x - min.x;
        }

        public readonly float Height
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => max.y - min.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Include(float x, float y)
        {
            min.x = Math.Min(min.x, x);
            min.y = Math.Min(min.y, y);

            max.x = Math.Max(max.x, x);
            max.y = Math.Max(max.y, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Include(Vector2 v)
        {
            Include(v.x, v.y);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Include(Vector2 otherMin, Vector2 otherMax)
        {
            min = Mathx.Min(min, otherMin);
            max = Mathx.Max(max, otherMax);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Include(Range2 other)
        {
            Include(other.min, other.max);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Contains(float x, float y)
        {
            return (
                min.x <= x && x <= max.x &&
                min.y <= y && y <= max.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Contains(Vector2 v)
        {
            return Contains(v.x, v.y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Contains(Vector2 otherMin, Vector2 otherMax)
        {
            return (
                Mathx.IsLesserOrEqual(min, otherMin) &&
                Mathx.IsLesserOrEqual(otherMax, max)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Contains(Range2 other)
        {
            return Contains(other.min, other.max);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Overlaps(Vector2 otherMin, Vector2 otherMax)
        {
            return (
                Mathx.IsLesserOrEqual(min, otherMax) &&
                Mathx.IsLesserOrEqual(otherMin, max)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Overlaps(Range2 other)
        {
            return Overlaps(other.min, other.max);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Range2 Intersection(Range2 other)
        {
            other.min = Mathx.Max(min, other.min);
            other.max = Mathx.Min(max, other.max);
            return other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Validate()
        {
            min = Mathx.Min(min, max);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Range2 l, Range2 r)
        {
            return (
                l.min == r.min &&
                l.max == r.max
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Range2 l, Range2 r)
        {
            return !(l == r);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Range2 other)
        {
            return (
                Mathx.IsEqual(min, other.min) &&
                Mathx.IsEqual(max, other.max)
            );
        }

        public override readonly bool Equals(object obj)
        {
            return obj is Range2 other && Equals(other);
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
            return string.Format("({0}, {1})", min, max);
        }
    }
}
