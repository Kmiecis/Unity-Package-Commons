using System.Runtime.CompilerServices;

namespace Common.Collections
{
    /// <summary> Array wrapper for two-dimensional grids </summary>
    public sealed class Array2<T>
    {
        private T[] _array;
        private int _width;
        private int _height;
        
        public Array2(T[] array, int width, int height)
        {
            _array = array;
            _width = width;
            _height = height;
        }

        public Array2(int width, int height) :
            this(new T[width * height], width, height)
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

        /// <summary> Resizes array and returns its previous buffer </summary>
        public T[] Resize(int width, int height)
        {
            var array = _array;
            _array = new T[width * height];
            _width = width;
            _height = height;
            return array;
        }

        public T this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => _array[index];
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _array[index] = value;
        }

        public T this[int x, int y]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => this[ToIndex(x, y)];
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this[ToIndex(x, y)] = value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int ToIndex(int x, int y)
        {
            return y * _width + x;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void FromIndex(int i, out int x, out int y)
        {
            x = i % _width;
            y = i / _width;
        }
    }
}
