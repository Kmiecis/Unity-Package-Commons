using System;
using System.Collections.Generic;

namespace Common
{
    public class PriorityQueue<T>
        where T : IComparable<T>
    {
        private const int DefaultCapacity = 4;

        private T[] _array;
        private int _count;

        public PriorityQueue(int capacity)
        {
            _array = new T[capacity];
            _count = 0;
        }

        public PriorityQueue(IEnumerable<T> collection)
        {
            _array = new T[DefaultCapacity];
            _count = 0;

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

            SiftUp(_count, ref value, 0);

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
            var x = _array[_count];
            int i = SiftDown(index);
            SiftUp(i, ref x, index);
            _array[_count] = default;
        }

        private int SiftDown(int index)
        {
            int parent = index;
            int leftChild = HeapLeftChild(parent);

            while (leftChild < _count)
            {
                int rightChild = HeapRightFromLeft(leftChild);
                int bestChild =
                    (rightChild < _count && _array[rightChild].CompareTo(_array[leftChild]) < 0) ?
                    rightChild : leftChild;

                _array[parent] = _array[bestChild];

                parent = bestChild;
                leftChild = HeapLeftChild(parent);
            }

            return parent;
        }

        private void SiftUp(int index, ref T x, int boundary)
        {
            while (index > boundary)
            {
                int parent = HeapParent(index);
                if (_array[parent].CompareTo(x) > 0)
                {
                    _array[index] = _array[parent];
                    index = parent;
                }
                else
                {
                    break;
                }
            }
            _array[index] = x;
        }

        private static int HeapParent(int i)
        {
            return (i - 1) / 2;
        }

        private static int HeapLeftChild(int i)
        {
            return (i * 2) + 1;
        }

        private static int HeapRightFromLeft(int i)
        {
            return i + 1;
        }
    }
}
