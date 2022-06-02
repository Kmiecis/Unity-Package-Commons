using System;
using System.Collections.Generic;

namespace Common.Extensions
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

        public static KeyValuePair<TKey, TValue> First<TKey, TValue>(this Dictionary<TKey, TValue> self)
        {
            foreach (var pairs in self)
                return pairs;
            return default;
        }

        public static TValue GetOrDefault<TKey, TValue>(this Dictionary<TKey, TValue> self, TKey key, TValue value = default)
        {
            return self.TryGetValue(key, out var result) ? result : value;
        }

        public static TValue GetOrCompute<TKey, TValue>(this Dictionary<TKey, TValue> self, TKey key, Func<TValue> computor)
        {
            TValue result;
            if (!self.TryGetValue(key, out result))
                self[key] = result = computor();
            return result;
        }

        public static TValue Revoke<TKey, TValue>(this Dictionary<TKey, TValue> self, TKey key)
        {
            var value = self[key];
            self.Remove(key);
            return value;
        }

        public static bool TryRevoke<TKey, TValue>(this Dictionary<TKey, TValue> self, TKey key, out TValue value)
        {
            var result = self.TryGetValue(key, out value);
            self.Remove(key);
            return result;
        }
    }
}
