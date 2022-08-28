using Common.Mathematics;
using System.Runtime.CompilerServices;

namespace Common.Collections
{
    /// <summary> Array wrapper for three-dimensional grids </summary>
    public sealed class Array3<T>
    {
        private T[] _array;
        private int _width;
        private int _height;
        private int _depth;

        public Array3(T[] array, int width, int height, int depth)
        {
            _array = array;
            _width = width;
            _height = height;
            _depth = depth;
        }

        public Array3(int width, int height, int depth) :
            this(new T[width * height * depth], width, height, depth)
        {
        }

        public T[] Raw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => _array;
        }

        public int Length
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => _array.Length;
        }

        public int Width
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => _width;
        }

        public int Height
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => _height;
        }

        public int Depth
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => _depth;
        }

        /// <summary> Resizes array and returns its previous buffer </summary>
        public T[] Resize(int width, int height, int depth)
        {
            var array = _array;
            _array = new T[width * height * depth];
            _width = width;
            _height = height;
            _depth = depth;
            return array;
        }

        public T this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => _array[index];
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _array[index] = value;
        }

        public T this[int x, int y, int z]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => this[Mathx.ToIndex(x, y, z, _width, _height)];
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[Mathx.ToIndex(x, y, z, _width, _height)] = value;
        }
    }
}
