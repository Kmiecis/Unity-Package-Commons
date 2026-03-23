using System;
using System.Collections.Generic;
using UnityEngine;

namespace Common.Collections
{
    [Serializable]
    public class SerializedDictionary<TKey, TValue> : Dictionary<TKey, TValue>, ISerializationCallbackReceiver
    {
        [SerializeField, Unfolded(false)] private List<SerializedKeyValuePair<TKey, TValue>> _entries;

        public SerializedDictionary()
        {
            _entries = new List<SerializedKeyValuePair<TKey, TValue>>();
        }

        public void OnBeforeSerialize()
        {
            // no-op
        }

        public void OnAfterDeserialize()
        {
            this.Clear();

            foreach (var entry in _entries)
            {
                this[entry.key] = entry.value;
            }

#if !UNITY_EDITOR
            _entries.Clear();
#endif
        }
    }
}