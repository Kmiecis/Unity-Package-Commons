using System;
using System.Collections.Generic;
using UnityEngine;

namespace Common.Collections
{
    [Serializable]
    public class SerializableHashSet<T> : HashSet<T>, ISerializationCallbackReceiver
    {
        [SerializeField]
        private List<T> _items = new List<T>();

        public void OnBeforeSerialize()
        {
            _items.Clear();

            foreach (var item in this)
            {
                _items.Add(item);
            }
        }

        public void OnAfterDeserialize()
        {
            this.Clear();

            for (int i = 0; i < _items.Count; ++i)
            {
                this.Add(_items[i]);
            }
        }
    }
}