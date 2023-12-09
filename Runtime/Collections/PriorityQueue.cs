using System;
using System.Collections.Generic;

namespace Common
{
    public class PriorityQueue<T>
        where T : IComparable<T>
    {
        private readonly List<T> _heap;

        public PriorityQueue()
        {
            _heap = new List<T>();
        }

        public int Count
        {
            get => _heap.Count;
        }

        public T Find(Predicate<T> predicate)
        {
            return _heap.Find(predicate);
        }

        public void Remove(T item)
        {
            _heap.Remove(item);
            _heap.Sort();
        }

        public void Enqueue(T item)
        {
            _heap.Add(item);

            int index = _heap.Count - 1;
            while (index > 0)
            {
                int parentIndex = (index - 1) / 2;

                if (_heap[parentIndex].CompareTo(item) <= 0)
                    break;

                _heap[index] = _heap[parentIndex];
                index = parentIndex;
            }

            _heap[index] = item;
        }

        public bool TryDequeue(out T item)
        {
            if (_heap.Count > 0)
            {
                item = Dequeue();
                return true;
            }

            item = default;
            return false;
        }

        public T Dequeue()
        {
            int lastIndex = _heap.Count - 1;
            T firstItem = _heap[0];
            _heap[0] = _heap[lastIndex];
            _heap.RemoveAt(lastIndex);

            lastIndex--;

            int i = 0;
            while (true)
            {
                int left = 2 * i + 1;
                int right = 2 * i + 2;

                if (left > lastIndex)
                    break;

                int smallest = left;

                if (right <= lastIndex && _heap[right].CompareTo(_heap[left]) < 0)
                    smallest = right;

                if (_heap[i].CompareTo(_heap[smallest]) <= 0)
                    break;

                var temp = _heap[i];
                _heap[i] = _heap[smallest];
                _heap[smallest] = temp;

                i = smallest;
            }

            return firstItem;
        }
    }
}
