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
        public void Include(float x, float y, float z)
        {
            min.x = Math.Min(min.x, x);
            min.y = Math.Min(min.y, y);
            min.z = Math.Min(min.z, z);

            max.x = Math.Max(max.x, x);
            max.y = Math.Max(max.y, y);
            max.z = Math.Max(max.z, z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Include(Vector3 v)
        {
            Include(v.x, v.y, v.z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Include(Vector3 otherMin, Vector3 otherMax)
        {
            min = Mathx.Min(min, otherMin);
            max = Mathx.Max(max, otherMax);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Include(Range3 other)
        {
            Include(other.min, other.max);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Contains(float x, float y, float z)
        {
            return (
                min.x <= x &&
                min.y <= y &&
                min.z <= z &&
                x <= max.x &&
                y <= max.y &&
                z <= max.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Contains(Vector3 v)
        {
            return Contains(v.x, v.y, v.z);
        }

        public bool Contains(Vector3 otherMin, Vector3 otherMax)
        {
            return (
                Mathx.AreLesserOrEqual(min, otherMin) &&
                Mathx.AreLesserOrEqual(otherMax, max)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Contains(Range3 other)
        {
            return Contains(other.min, other.max);
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Range3 other)
        {
            return (
                Mathx.AreEqual(min, other.min) &&
                Mathx.AreEqual(max, other.max)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object obj)
        {
            return obj is Range3 converted && Equals(converted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode()
        {
            return min.GetHashCode() ^ (max.GetHashCode() << 2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("Range3({0}, {1})", min, max);
        }
    }
}