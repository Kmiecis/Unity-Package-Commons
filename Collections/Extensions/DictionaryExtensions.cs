using System.Collections.Generic;
using System;

namespace Common
{
    public static class DictionaryExtensions
    {
        public static bool IsNull<TKey, TValue>(this Dictionary<TKey, TValue> self)
        {
            return self == null;
        }

        public static bool IsEmpty<TKey, TValue>(this Dictionary<TKey, TValue> self)
        {
            return self.Count == 0;
        }

        public static bool IsNullOrEmpty<TKey, TValue>(this Dictionary<TKey, TValue> self)
        {
            return self.IsNull() || self.IsEmpty();
        }

        public static TValue GetOrCompute<TKey, TValue>(this Dictionary<TKey, TValue> self, TKey key, Func<TKey, TValue> computor)
        {
            if (!self.ContainsKey(key))
                self.Add(key, computor(key));
            return self[key];
        }
    }
}