using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common
{
    public struct Triangle : IEquatable<Triangle>
    {
        public const int VERTEX_COUNT = 3;

        public Vector3 v0;
        public Vector3 v1;
        public Vector3 v2;

        public static readonly Triangle Zero;

        public int VertexCount
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return VERTEX_COUNT; }
        }

#if UNSAFE
        unsafe
#endif
        public Vector3 this[int index]
        {
            get
            {
#if UNSAFE
                fixed (Triangle* array = &this)
                {
                    return ((Vector3*)array)[index];
                }
#else
                switch (index)
                {
                    case 0: return v0;
                    case 1: return v1;
                    case 2: return v2;
                }
                throw new IndexOutOfRangeException($"Invalid Triangle index {index}");
#endif
            }
            set
            {
#if UNSAFE
                fixed (Vector3* array = &v0)
                {
                    array[index] = value;
                }
#else
                switch (index)
                {
                    case 0: v0 = value; break;
                    case 1: v1 = value; break;
                    case 2: v2 = value; break;
                }
                throw new IndexOutOfRangeException($"Invalid Triangle index {index}");
#endif
            }
        }

        public float Area
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                var a = Vector3.Distance(v0, v1);
                var b = Vector3.Distance(v1, v2);
                var c = Vector3.Distance(v2, v0);
                var s = (a + b + c) * 0.5f;
                return Mathf.Sqrt(s * (s - a) * (s - b) * (s - c));
            }
        }

        public float Perimeter
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return Vector3.Distance(v1, v0) + Vector3.Distance(v2, v1) + Vector3.Distance(v0, v2); }
        }

        public Vector3 Normal
        {
            get { return Vector3.Cross(v1 - v0, v2 - v1); }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3 GetWeights(Vector3 p)
        {
            var a = v1 - v0;
            var b = v2 - v0;
            var c = p - v0;

            var d00 = Vector3.Dot(a, a);
            var d01 = Vector3.Dot(a, b);
            var d11 = Vector3.Dot(b, b);
            var d20 = Vector3.Dot(c, a);
            var d21 = Vector3.Dot(c, b);
            var d = d00 * d11 - d01 * d01;

            var v = (d11 * d20 - d01 * d21) / d;
            var w = (d00 * d21 - d01 * d20) / d;
            var u = 1.0f - v - w;

            return new Vector3(v, w, u);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Contains(Vector3 p)
        {
            var weights = GetWeights(p);
            return
                Mathx.AreEqual(weights.x + weights.y + weights.z, 1.0f) &&
                0.0f <= weights.x && weights.x <= 1.0f &&
                0.0f <= weights.y && weights.y <= 1.0f &&
                0.0f <= weights.z && weights.z <= 1.0f;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Triangle other)
        {
            return
                Mathx.AreEqual(v0, other.v0) &&
                Mathx.AreEqual(v1, other.v1) &&
                Mathx.AreEqual(v2, other.v2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object obj)
        {
            return obj is Triangle converted && Equals(converted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode()
        {
            return v0.GetHashCode() ^ (v1.GetHashCode() << 2) ^ (v2.GetHashCode() << 4);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("Triangle({0}, {1}, {2})", v0, v1, v2);
        }
    }
}