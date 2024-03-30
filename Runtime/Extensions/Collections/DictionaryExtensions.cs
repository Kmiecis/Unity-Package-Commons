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

        public static bool ContainsKeys<TKey, TValue>(this Dictionary<TKey, TValue> self, IEnumerable<TKey> keys)
        {
            foreach (var key in keys)
            {
                if (!self.ContainsKey(key))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool ContainsValues<TKey, TValue>(this Dictionary<TKey, TValue> self, IEnumerable<TValue> values)
        {
            foreach (var value in values)
            {
                if (!self.ContainsValue(value))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool Remove<TKey, TValue>(this Dictionary<TKey, TValue> self, IEnumerable<TKey> keys)
        {
            var result = true;
            foreach (var key in keys)
            {
                result &= self.Remove(key);
            }
            return result;
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
            if (!self.TryGetValue(key, out var result))
                self[key] = result = computor();
            return result;
        }
    }
}
