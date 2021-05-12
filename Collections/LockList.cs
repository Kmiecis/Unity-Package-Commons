using System;
using System.Collections.Generic;

namespace Common
{
    public class LockList<T>
    {
        private bool m_IsLocked;
        private List<T> m_List = new List<T>();
        private List<T> m_AddedList = new List<T>();
        private List<T> m_RemovedList = new List<T>();

        public int Count
        {
            get { return m_List.Count; }
        }

        public T this[int index]
        {
            get { return m_List[index]; }
            set { m_List[index] = value; }
        }

        public void Add(T item)
        {
            if (m_IsLocked)
            {
                m_AddedList.Add(item);
            }
            else
            {
                m_List.Add(item);
            }
        }

        public bool Remove(T item)
        {
            if (m_IsLocked)
            {
                m_RemovedList.Add(item);
                return m_List.Contains(item);
            }
            else
            {
                return m_List.Remove(item);
            }
        }

        public int RemoveAll(Predicate<T> match)
        {
            if (m_IsLocked)
            {
                var result = 0;
                result += m_AddedList.RemoveAll(match);
                var removed = m_List.FindAll(match);
                result += removed.Count;
                m_RemovedList.AddRange(removed);
                return result;
            }
            else
            {
                return m_List.RemoveAll(match);
            }
        }

        public bool IsValid(T item)
        {
            return !m_IsLocked || !m_RemovedList.Contains(item);
        }

        public void Lock()
        {
            m_IsLocked = true;
        }

        public void Unlock()
        {
            if (m_IsLocked)
            {
                foreach (var removed in m_RemovedList)
                {
                    m_List.Remove(removed);
                }
                foreach (var added in m_AddedList)
                {
                    m_List.Add(added);
                }
                m_RemovedList.Clear();
                m_AddedList.Clear();
            }
            m_IsLocked = false;
        }

        public void ForEach(Action<T> action)
        {
            Lock();
            foreach (var item in m_List)
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
            if (m_IsLocked)
            {
                m_RemovedList.AddRange(m_List);
            }
            else
            {
                m_List.Clear();
            }
        }
    }
}