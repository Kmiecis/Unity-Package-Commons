using System;
using System.Runtime.CompilerServices;

namespace Common
{
    public struct RefTriangle : IEquatable<RefTriangle>
    {
        public const int VERTEX_COUNT = 3;

        public int i0;
        public int i1;
        public int i2;

        public static readonly RefTriangle Zero;

        public int VertexCount
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return VERTEX_COUNT; }
        }

#if UNSAFE
        unsafe
#endif
        public int this[int index]
        {
            get
            {
#if UNSAFE
                fixed (RefTriangle* array = &this)
                {
                    return ((int*)array)[index];
                }
#else
                switch (index)
                {
                    case 0: return i0;
                    case 1: return i1;
                    case 2: return i2;
                }
                throw new IndexOutOfRangeException($"Invalid RefTriangle index {index}");
#endif
            }
            set
            {
#if UNSAFE
                fixed (int* array = &i0)
                {
                    array[index] = value;
                }
#else
                switch (index)
                {
                    case 0: i0 = value; break;
                    case 1: i1 = value; break;
                    case 2: i2 = value; break;
                }
                throw new IndexOutOfRangeException($"Invalid RefTriangle index {index}");
#endif
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(RefTriangle other)
        {
            return
                this.i0 == other.i0 &&
                this.i1 == other.i1 &&
                this.i2 == other.i2;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object obj)
        {
            return obj is RefTriangle converted && Equals(converted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode()
        {
            return i0.GetHashCode() ^ (i1.GetHashCode() << 2) ^ (i2.GetHashCode() << 4);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("RefTriangle({0}, {1}, {2})", i0, i1, i2);
        }
    }
}