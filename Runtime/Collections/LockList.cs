using System;
using System.Collections;
using System.Collections.Generic;

namespace Common.Collections
{
    public class LockList<T>
    {
        private bool _isLocked;
        private List<T> _list = new List<T>();
        private List<T> _addedList = new List<T>();
        private List<T> _removedList = new List<T>();

        public int Count
        {
            get { return _list.Count; }
        }

        public T this[int index]
        {
            get { return _list[index]; }
            set { _list[index] = value; }
        }

        public void Add(T item)
        {
            if (_isLocked)
            {
                _addedList.Add(item);
            }
            else
            {
                _list.Add(item);
            }
        }

        public bool Remove(T item)
        {
            if (_isLocked)
            {
                _removedList.Add(item);
                return _list.Contains(item);
            }
            else
            {
                return _list.Remove(item);
            }
        }

        public int RemoveAll(Predicate<T> match)
        {
            if (_isLocked)
            {
                var result = 0;
                result += _addedList.RemoveAll(match);
                var removed = _list.FindAll(match);
                result += removed.Count;
                _removedList.AddRange(removed);
                return result;
            }
            else
            {
                return _list.RemoveAll(match);
            }
        }

        public bool IsValid(T item)
        {
            return (
                !_isLocked ||
                !_removedList.Contains(item)
            );
        }

        public void Lock()
        {
            _isLocked = true;
        }

        public void Unlock()
        {
            if (_isLocked)
            {
                foreach (var removed in _removedList)
                {
                    _list.Remove(removed);
                }
                foreach (var added in _addedList)
                {
                    _list.Add(added);
                }
                _removedList.Clear();
                _addedList.Clear();
            }
            _isLocked = false;
        }

        public void ForEach(Action<T> action)
        {
            Lock();
            foreach (var item in _list)
            {
                if (IsValid(item))
                {
                    action(item);
                }
            }
            Unlock();
        }

        public void Clear()
        {
            if (_isLocked)
            {
                _removedList.AddRange(_list);
            }
            else
            {
                _list.Clear();
            }
        }
    }
}
