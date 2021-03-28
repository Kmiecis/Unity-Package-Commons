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

        public static readonly Range2 zero;
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Range2(Vector2 min, Vector2 max)
        {
            this.min = min;
            this.max = max;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Range2(float minX, float minY, float maxX, float maxY)
        {
            this.min = new Vector2(minX, minY);
            this.max = new Vector2(maxX, maxY);
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
                Mathx.AreLesserOrEqual(min, otherMin) &&
                Mathx.AreLesserOrEqual(otherMax, max)
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
                Mathx.AreLesserOrEqual(min, other.max) &&
                Mathx.AreLesserOrEqual(other.min, max)
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

        public bool Equals(Range2 other)
        {
            return (
                Mathx.AreEqual(min, other.min) &&
                Mathx.AreEqual(max, other.max)
            );
        }

        public override bool Equals(object obj)
        {
            return obj is Range2 && Equals((Range2)obj);
        }

        public override int GetHashCode()
        {
            return min.GetHashCode() ^ (max.GetHashCode() << 2);
        }

        public override string ToString()
        {
            return string.Format("Range2({0}, {1})", min, max);
        }
    }
}