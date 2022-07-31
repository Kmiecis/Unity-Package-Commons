using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common.Mathematics
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
        public bool Contains(float x, float y)
        {
            return (
                min.x <= x &&
                min.y <= y &&
                x <= max.x &&
                y <= max.y
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Contains(Vector2 v)
        {
            return Contains(v.x, v.y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Contains(Vector2 otherMin, Vector2 otherMax)
        {
            return (
                Mathx.IsLesserOrEqual(min, otherMin) &&
                Mathx.IsLesserOrEqual(otherMax, max)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Contains(Range2 other)
        {
            return Contains(other.min, other.max);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Overlaps(Range2 other)
        {
            return (
                Mathx.IsLesserOrEqual(min, other.max) &&
                Mathx.IsLesserOrEqual(other.min, max)
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
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Range2 other)
        {
            return (
                Mathx.IsEqual(min, other.min) &&
                Mathx.IsEqual(max, other.max)
            );
        }

        public override bool Equals(object obj)
        {
            return obj is Range2 && Equals((Range2)obj);
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
