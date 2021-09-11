using System.Collections.Generic;

namespace Common.Extensions
{
    public static class QueueExtensions
    {
        public static bool IsNull<T>(this Queue<T> self)
        {
            return self == null;
        }

        public static bool IsEmpty<T>(this Queue<T> self)
        {
            return self.Count == 0;
        }

        public static bool IsNullOrEmpty<T>(this Queue<T> self)
        {
            return self.IsNull() || self.IsEmpty();
        }
    }
}
