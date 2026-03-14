using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common
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

        public readonly Vector3 Center
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => max.Add(min).Mul(0.5f);
        }

        public readonly Vector3Int Extents
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

        public readonly int Depth
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => max.z - min.z;
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
        public readonly bool Contains(int x, int y, int z)
        {
            return (
                min.x <= x && x <= max.x &&
                min.y <= y && y <= max.y &&
                min.z <= z && z <= max.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Contains(Vector3Int v)
        {
            return Contains(v.x, v.y, v.z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Contains(Vector3Int otherMin, Vector3Int otherMax)
        {
            return (
                Mathx.IsLesserOrEqual(min, otherMin) &&
                Mathx.IsLesserOrEqual(otherMax, max)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Contains(Range3Int other)
        {
            return Contains(other.min, other.max);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Overlaps(Vector3Int otherMin, Vector3Int otherMax)
        {
            return (
                Mathx.IsLesserOrEqual(min, otherMax) &&
                Mathx.IsLesserOrEqual(otherMin, max)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Overlaps(Range3Int other)
        {
            return Overlaps(other.min, other.max);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly Range3Int Intersection(Range3Int other)
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
        public static bool operator ==(Range3Int l, Range3Int r)
        {
            return (
                l.min == r.min &&
                l.max == r.max
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Range3Int l, Range3Int r)
        {
            return !(l == r);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(Range3Int other)
        {
            return (
                Mathx.IsEqual(min, other.min) &&
                Mathx.IsEqual(max, other.max)
            );
        }

        public override readonly bool Equals(object obj)
        {
            return obj is Range3Int other && Equals(other);
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
