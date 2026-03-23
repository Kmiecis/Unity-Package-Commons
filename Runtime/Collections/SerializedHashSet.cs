using System;
using System.Collections.Generic;
using UnityEngine;

namespace Common.Collections
{
    [Serializable]
    public class SerializedHashSet<T> : HashSet<T>, ISerializationCallbackReceiver
    {
        [SerializeField, HideLabel] private List<T> _entries;

        public SerializedHashSet()
        {
            _entries = new List<T>();
        }

        public void OnBeforeSerialize()
        {
            // no-op
        }

        public void OnAfterDeserialize()
        {
            this.Clear();

            for (int i = 0; i < _entries.Count; ++i)
            {
                this.Add(_entries[i]);
            }

#if !UNITY_EDITOR
            _entries.Clear();
#endif
        }
    }
}