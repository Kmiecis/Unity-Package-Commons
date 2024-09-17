using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common.Mathematics
{
    [Serializable]
    public struct Range3Int : IEquatable<Range3Int>
    {
        public Vector3Int min;
        public Vector3Int max;

        public static readonly Range3Int Zero;
        public static readonly Range3Int One = new Range3Int(Vector3Int.zero, Vector3Int.one);
        public static readonly Range3Int Max = new Range3Int(Vector3Int.one * int.MinValue, Vector3Int.one * int.MaxValue);
        public static readonly Range3Int Empty = new Range3Int(Vector3Int.one * int.MaxValue, Vector3Int.one * int.MinValue);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Range3Int(Vector3Int min, Vector3Int max)
        {
            this.min = min;
            this.max = max;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Range3Int(int minX, int minY, int minZ, int maxX, int maxY, int maxZ)
        {
            this.min = new Vector3Int(minX, minY, minZ);
            this.max = new Vector3Int(maxX, maxY, maxZ);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Range3(Range3Int r)
        {
            return new Range3(r.min, r.max);
        }

        public Vector3 Center
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return Mathx.Mul((max + min), 0.5f); }
        }

        public Vector3Int Extents
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return max - min; }
        }

        public int Width
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return max.x - min.x; }
        }

        public int Height
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return max.y - min.y; }
        }

        public int Depth
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return max.z - min.z; }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Include(int x, int y, int z)
        {
            min.x = Math.Min(min.x, x);
            min.y = Math.Min(min.y, y);
            min.z = Math.Min(min.z, z);

            max.x = Math.Max(max.x, x);
            max.y = Math.Max(max.y, y);
            max.z = Math.Max(max.z, z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Include(Vector3Int v)
        {
            Include(v.x, v.y, v.z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Include(Vector3Int otherMin, Vector3Int otherMax)
        {
            min = Mathx.Min(min, otherMin);
            max = Mathx.Max(max, otherMax);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Include(Range3Int other)
        {
            Include(other.min, other.max);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Contains(int x, int y, int z)
        {
            return (
                min.x <= x && x <= max.x &&
                min.y <= y && y <= max.y &&
                min.z <= z && z <= max.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Contains(Vector3Int v)
        {
            return Contains(v.x, v.y, v.z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Contains(Vector3Int otherMin, Vector3Int otherMax)
        {
            return (
                Mathx.IsLesserOrEqual(min, otherMin) &&
                Mathx.IsLesserOrEqual(otherMax, max)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Contains(Range3Int other)
        {
            return Contains(other.min, other.max);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Overlaps(Vector3Int otherMin, Vector3Int otherMax)
        {
            return (
                Mathx.IsLesserOrEqual(min, otherMax) &&
                Mathx.IsLesserOrEqual(otherMin, max)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Overlaps(Range3Int other)
        {
            return Overlaps(other.min, other.max);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Range3Int Intersection(Range3Int other)
        {
            return new Range3Int(
                Mathx.Max(min, other.min),
                Mathx.Min(max, other.max)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Range3Int other)
        {
            return (
                Mathx.IsEqual(min, other.min) &&
                Mathx.IsEqual(max, other.max)
            );
        }

        public override bool Equals(object obj)
        {
            return obj is Range3Int && Equals((Range3Int)obj);
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
