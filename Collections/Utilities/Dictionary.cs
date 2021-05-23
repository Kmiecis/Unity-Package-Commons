using System.Collections.Generic;

namespace Common
{
    public static class Dictionary
    {
        public static Dictionary<TKey, TValue> Of<TKey, TValue>()
        {
            return new Dictionary<TKey, TValue>();
        }

        public static Dictionary<TKey, TValue> Of<TKey, TValue>(params (TKey, TValue)[] args)
        {
            var result = new Dictionary<TKey, TValue>();
            foreach (var arg in args)
                result.Add(arg.Item1, arg.Item2);
            return result;
        }
    }
}
