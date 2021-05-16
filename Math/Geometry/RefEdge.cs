using System;
using System.Runtime.CompilerServices;

namespace Common
{
    public struct RefEdge : IEquatable<RefEdge>
    {
        public const int VERTEX_COUNT = 2;

        public int i0;
        public int i1;

        public static readonly RefEdge Zero;

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
                fixed (RefEdge* array = &this)
                {
                    return ((int*)array)[index];
                }
#else
                switch (index)
                {
                    case 0: return i0;
                    case 1: return i1;
                }
                throw new IndexOutOfRangeException($"Invalid RefEdge index {index}");
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
                }
                throw new IndexOutOfRangeException($"Invalid RefEdge index {index}");
#endif
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(RefEdge other)
        {
            return
                this.i0 == other.i0 &&
                this.i1 == other.i1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object obj)
        {
            return obj is RefEdge converted && Equals(converted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode()
        {
            return i0.GetHashCode() ^ (i1.GetHashCode() << 2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("RefEdge({0}, {1})", i0, i1);
        }
    }
}