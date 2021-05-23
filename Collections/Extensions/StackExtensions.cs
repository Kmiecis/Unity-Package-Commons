using System.Collections.Generic;

namespace Common
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
    }
}