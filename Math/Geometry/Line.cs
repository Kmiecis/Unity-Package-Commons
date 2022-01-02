using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common.Mathematics
{
    [Serializable]
    public struct Line : IEquatable<Line>
    {
        public Vector3 v0;
        public Vector3 v1;

        public static readonly Line Zero;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Line(Vector3 v0, Vector3 v1)
        {
            this.v0 = v0;
            this.v1 = v1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Line(Line other) :
            this(other.v0, other.v1)
        {
        }

#if UNSAFE
        unsafe
#endif
        public Vector3 this[int index]
        {
            get
            {
#if UNSAFE
                fixed (Line* array = &this)
                {
                    return ((Vector3*)array)[index];
                }
#else
                switch (index)
                {
                    case 0: return v0;
                    case 1: return v1;
                }
                throw new IndexOutOfRangeException($"Invalid index {index} out of range [0, 1]");
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
                }
                throw new IndexOutOfRangeException($"Invalid index {index} out of range [0, 1]");
#endif
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Line other)
        {
            return (
                Mathx.IsEqual(v0, other.v0) &&
                Mathx.IsEqual(v1, other.v1)
            );
        }

        public override bool Equals(object obj)
        {
            return obj is Line && Equals((Line)obj);
        }

        public override int GetHashCode()
        {
            return (
                v0.GetHashCode() ^
                (v1.GetHashCode() << 2)
            );
        }

        public override string ToString()
        {
            return ToString("F2");
        }

        public string ToString(string format)
        {
            return string.Format("({0}, {1})", v0.ToString(format), v1.ToString(format));
        }
    }
}
