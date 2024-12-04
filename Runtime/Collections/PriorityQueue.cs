using System;
using System.Collections.Generic;

namespace Common.Collections
{
    public class PriorityQueue<T>
        where T : IComparable<T>
    {
        private const int DefaultCapacity = 4;

        private T[] _array;
        private int _count;

        public PriorityQueue() :
            this(DefaultCapacity)
        {
        }

        public PriorityQueue(int capacity)
        {
            _array = new T[capacity];
            _count = 0;
        }

        public PriorityQueue(IEnumerable<T> collection) :
            this(DefaultCapacity)
        {
            foreach (var item in collection)
            {
                Enqueue(item);
            }
        }

        public int Count
        {
            get => _count;
        }

        public T Peek()
        {
            return _array[0];
        }

        public void Clear()
        {
            Array.Clear(_array, 0, _count);

            _count = 0;
        }

        public bool Contains(T item)
        {
            var comparer = EqualityComparer<T>.Default;
            for (int i = 0; i < _count; ++i)
            {
                if (comparer.Equals(_array[i], item))
                {
                    return true;
                }
            }
            return false;
        }

        public void Enqueue(T value)
        {
            if (_count == _array.Length)
            {
                Array.Resize(ref _array, _count * 2);
            }

            var index = FindIndex(ref value);

            ShiftUpFrom(index);

            _array[index] = value;

            _count++;
        }

        public T Dequeue()
        {
            var result = _array[0];

            RemoveAt(0);

            return result;
        }

        public bool Remove(T item)
        {
            var index = Array.IndexOf(_array, item);
            if (index > 0)
            {
                RemoveAt(index);
                return true;
            }
            return false;
        }

        public int RemoveAll(Predicate<T> match)
        {
            var result = 0;
            while (RemoveSingle(match))
            {
                result++;
            }
            return result;
        }

        private bool RemoveSingle(Predicate<T> match)
        {
            for (int i = _count - 1; i > -1; --i)
            {
                var item = _array[i];
                if (match(item))
                {
                    RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        private void RemoveAt(int index)
        {
            --_count;

            ShiftDownTo(index);

            _array[_count] = default;
        }

        private int FindIndex(ref T value)
        {
            var index = _count - 1;
            while (index > -1 && value.CompareTo(_array[index]) < 0)
            {
                index -= 1;
            }
            return Math.Min(index + 1, _count);
        }

        private void ShiftDownTo(int target)
        {
            for (int i = target; i < _count; ++i)
            {
                _array[i] = _array[i + 1];
            }
        }

        private void ShiftUpFrom(int start)
        {
            for (int i = _count; i > start; --i)
            {
                _array[i] = _array[i - 1];
            }
        }
    }
}