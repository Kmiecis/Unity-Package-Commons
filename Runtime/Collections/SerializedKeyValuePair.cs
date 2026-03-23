using System;

namespace Common.Collections
{
    [Serializable]
    public class SerializedKeyValuePair<TKey, TValue>
    {
        public TKey key;
        public TValue value;
    }
}