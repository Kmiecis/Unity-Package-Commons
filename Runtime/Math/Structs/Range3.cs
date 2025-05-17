using Common.Extensions;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common.Mathematics
{
    [Serializable]
    public struct Range3 : IEquatable<Range3>
    {
        public Vector3 min;
        public Vector3 max;

        public static readonly Range3 Zero;
        public static readonly Range3 One = new Range3(Vector3.zero, Vector3.one);
        public static readonly Range3 Max = new Range3(Vector3.one * float.MinValue, Vector3.one * float.MaxValue);
        public static readonly Range3 Empty = new Range3(Vector3.one * float.MaxValue, Vector3.one * float.MinValue);
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Range3(Vector3 min, Vector3 max)
        {
            this.min = min;
            this.max = max;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Range3(float minX, float minY, float minZ, float maxX, float maxY, float maxZ) :
            this(new Vector3(minX, minY, minZ), new Vector3(maxX, maxY, maxZ))
        {
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Range3Int(Range3 r)
        {
            Range3Int ri;
            ri.min = Mathx.RoundToInt(r.min);
            ri.max = Mathx.RoundToInt(r.max);
            return ri;
        }

        public Vector3 Center
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return max.Add(min).Mul(0.5f); }
        }

        public Vector3 Extents
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return max.Sub(min); }
        }

        public float Width
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return max.x - min.x; }
        }

        public float Height
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return max.y - min.y; }
        }

        public float Depth
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return max.z - min.z; }
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
                min.x <= x && x <= max.x &&
                min.y <= y && y <= max.y &&
                min.z <= z && z <= max.z
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
                Mathx.IsLesserOrEqual(min, otherMin) &&
                Mathx.IsLesserOrEqual(otherMax, max)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Contains(Range3 other)
        {
            return Contains(other.min, other.max);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Overlaps(Vector3 otherMin, Vector3 otherMax)
        {
            return (
                Mathx.IsLesserOrEqual(min, otherMax) &&
                Mathx.IsLesserOrEqual(otherMin, max)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Overlaps(Range3 other)
        {
            return Overlaps(other.min, other.max);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Range3 Intersection(Range3 other)
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
        public bool Equals(Range3 other)
        {
            return (
                Mathx.IsEqual(min, other.min) &&
                Mathx.IsEqual(max, other.max)
            );
        }

        public override bool Equals(object obj)
        {
            return obj is Range3 && Equals((Range3)obj);
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
