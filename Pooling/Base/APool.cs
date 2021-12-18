using Common.Extensions;
using System.Collections.Generic;

namespace Common.Pooling
{
    public abstract class APool<T> : IPool<T>
    {
        protected readonly int _capacity;
        protected readonly Queue<T> _pool;

        protected int _constructed;

        public APool(int capacity)
        {
            _capacity = capacity;
            _pool = new Queue<T>(capacity);
        }

        public abstract T Construct();

        public abstract void Destroy(T item);

        public abstract void OnBorrow(T item);

        public abstract void OnReturn(T item);

        protected T DoConstruct()
        {
            _constructed += 1;
            return Construct();
        }

        protected void DoDestroy(T item)
        {
            _constructed -= 1;
            Destroy(item);
        }

        protected T Get()
        {
            if (_pool.Count == 0)
            {
                return DoConstruct();
            }
            return _pool.Dequeue();
        }

        protected void Put(T item)
        {
            if (_pool.Count >= _capacity)
            {
                DoDestroy(item);
            }
            else
            {
                _pool.Enqueue(item);
            }
        }

        public void Initialize(int count)
        {
            for (int i = 0; i < count; ++i)
            {
                Return(DoConstruct());
            }
        }
        
        public T Borrow()
        {
            T item = Get();
            OnBorrow(item);
            return item;
        }

        public void Borrow(T[] items)
        {
            for (int i = 0; i < items.Length; ++i)
            {
                items[i] = Borrow();
            }
        }

        public void Return(T item)
        {
            OnReturn(item);
            Put(item);
        }

        public void Return(T[] items)
        {
            for (int i = 0; i < items.Length; ++i)
            {
                Return(items[i]);
            }
        }

        public void Clear()
        {
            while (_pool.TryDequeue(out var item))
            {
                DoDestroy(item);
            }
        }

        public int Count
        {
            get => _constructed;
        }

        public int ActiveCount
        {
            get => _constructed - _pool.Count;
        }

        public int InactiveCount
        {
            get => _pool.Count;
        }

        public void Dispose()
        {
            Clear();
        }
    }
}
