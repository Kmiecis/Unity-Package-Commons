using System;
using System.Collections.Generic;
using UnityEngine;

namespace Common.Collections
{
    [Serializable]
    public class SerializableDictionary<TKey, TValue> : Dictionary<TKey, TValue>, ISerializationCallbackReceiver
    {
        [SerializeField]
        private List<TKey> _keys = new List<TKey>();
        [SerializeField]
        private List<TValue> _values = new List<TValue>();

        public void OnBeforeSerialize()
        {
            _keys.Clear();
            _values.Clear();

            foreach (var kv in this)
            {
                _keys.Add(kv.Key);
                _values.Add(kv.Value);
            }
        }

        public void OnAfterDeserialize()
        {
            this.Clear();

            var count = Mathf.Min(_keys.Count, _values.Count);
            for (int i = 0; i < count; ++i)
            {
                this.Add(_keys[i], _values[i]);
            }
        }
    }
}