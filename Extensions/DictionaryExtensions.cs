using System.Collections.Generic;
using System;
using System.Runtime.CompilerServices;

namespace Common.Extensions
{
    public static class DictionaryExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNull<TKey, TValue>(this Dictionary<TKey, TValue> self)
        {
            return self == null;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEmpty<TKey, TValue>(this Dictionary<TKey, TValue> self)
        {
            return self.Count == 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNullOrEmpty<TKey, TValue>(this Dictionary<TKey, TValue> self)
        {
            return self.IsNull() || self.IsEmpty();
        }

        public static TValue GetOrDefault<TKey, TValue>(this Dictionary<TKey, TValue> self, TKey key, TValue value = default)
        {
            return self.TryGetValue(key, out var result) ? result : value;
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
