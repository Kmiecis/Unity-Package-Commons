using System.Collections.Generic;

namespace Common.Extensions
{
    public static class StackExtensions
    {
        public static bool IsNull<T>(this Stack<T> self)
        {
            return self == null;
        }

        public static bool IsEmpty<T>(this Stack<T> self)
        {
            return self.Count == 0;
        }

        public static bool IsNullOrEmpty<T>(this Stack<T> self)
        {
            return self.IsNull() || self.IsEmpty();
        }

        public static bool TryPop<T>(this Stack<T> self, out T item)
        {
            if (self.Count > 0)
                return self.Pop().OutWithTrue(out item);
            return default(T).OutWithFalse(out item);
        }
    }
}
