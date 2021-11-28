using System.Collections.Generic;
using System;

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

        public static TValue GetOrDefault<TKey, TValue>(this Dictionary<TKey, TValue> self, TKey key, TValue value = default)
        {
            if (self.TryGetValue(key, out var result))
            {
                return result;
            }
            return value;
        }

        public static TValue GetOrCompute<TKey, TValue>(this Dictionary<TKey, TValue> self, TKey key, Func<TValue> computor)
        {
            if (self.TryGetValue(key, out var result))
            {
                return result;
            }
            var value = computor();
            self.Add(key, value);
            return value;
        }
    }
}
