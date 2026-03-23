using System;
using System.Collections.Generic;
using UnityEngine;

namespace Common.Collections
{
    [Serializable]
    public class SerializedQueue<T> : Queue<T>, ISerializationCallbackReceiver
    {
        [SerializeField, HideLabel] private List<T> _entries;

        public SerializedQueue()
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
                this.Enqueue(_entries[i]);
            }

#if !UNITY_EDITOR
            _entries.Clear();
#endif
        }
    }
}