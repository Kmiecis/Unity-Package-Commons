using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common.Collections
{
    public class Array2<T>
    {
        private Vector2Int m_Extents;
        private T[] m_Array;

        public Vector2Int Extents
            => m_Extents;

        public T[] Array
            => m_Array;

        public int Width
            => Extents.x;

        public int Height
            => Extents.y;

        public int Length
            => Width * Height;

        public Array2(Vector2Int extents)
        {
            m_Extents = extents;
            m_Array = new T[extents.x * extents.y];
        }

        public Array2(int width, int height)
            : this(new Vector2Int(width, height))
        {
        }

        public T this[int x, int y]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return m_Array[y * m_Extents.x + x]; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { m_Array[y * m_Extents.x + x] = value; }
        }

        public T this[Vector2Int xy]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return this[xy.x, xy.y]; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { this[xy.x, xy.y] = value; }
        }
    }
}