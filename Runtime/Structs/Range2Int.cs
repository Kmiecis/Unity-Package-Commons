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
        public static readonly Range2Int One = new Range2Int(Vector2Int.zero, Vector2Int.one);
        public static readonly Range2Int Max = new Range2Int(Vector2Int.one * int.MinValue, Vector2Int.one * int.MaxValue);
        public static readonly Range2Int Empty = new Range2Int(Vector2Int.one * int.MaxValue, Vector2Int.one * int.MinValue);

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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Range2(Range2Int r)
        {
            return new Range2(r.min, r.max);
        }

        public readonly Vector2 Center
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => max.Add(min).Mul(0.5f);
        }

        public readonly Vector2Int Size
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => max.Sub(min);
        }

        public readonly int Width
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => max.x - min.x;
        }

        public readonly int Height
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => max.y - min.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Include(int x, int y)
        {
            min.x = Math.Min(min.x, x);
            min.y = Math.Min(min.y, y);

            max.x = Math.Max(max.x, x);
            max.y = Math.Max(max.y, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Include(Vector2Int v)
        {
            Include(v.x, v.y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Include(Vector2Int otherMin, Vector2Int otherMax)
        {
            min = Mathx.Min(min, otherMin);
            max = Mathx.Max(max, otherMax);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Include(Range2Int other)
        {
            Include(other.min, other.max);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Contains(int x, int y)
        {
            return (
                min.x <= x && x <= max.x &&
                min.y <= y && y <= max.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Contains(Vector2Int v)
        {
            return Contains(v.x, v.y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Contains(Vector2Int otherMin, Vector2Int otherMax)
        {
            return (
                Mathx.IsLesserOrEqual(min, otherMin) &&
                Mathx.IsLesserOrEqual(otherMax, max)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Contains(Range2Int other)
        {
            return Contains(other.min, other.max);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Overlaps(Vector2Int otherMin, Vector2Int otherMax)
        {
            return (
                Mathx.IsLesserOrEqual(min, otherMax) &&
                Mathx.IsLesserOrEqual(otherMin, max)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Overlaps(Range2Int other)
        {
            return Overlaps(other.min, other.max);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Range2Int Intersection(Range2Int other)
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
        public static bool operator ==(Range2Int l, Range2Int r)
        {
            return (
                l.min == r.min &&
                l.max == r.max
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Range2Int l, Range2Int r)
        {
            return !(l == r);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Range2Int other)
        {
            return (
                Mathx.IsEqual(min, other.min) &&
                Mathx.IsEqual(max, other.max)
            );
        }

        public override readonly bool Equals(object obj)
        {
            return obj is Range2Int other && Equals(other);
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
