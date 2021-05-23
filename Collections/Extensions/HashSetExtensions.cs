using System.Collections.Generic;

namespace Common
{
    public static class HashSetExtensions
    {
        public static bool IsNull<T>(this HashSet<T> self)
        {
            return self == null;
        }

        public static bool IsEmpty<T>(this HashSet<T> self)
        {
            return self.Count == 0;
        }

        public static bool IsNullOrEmpty<T>(this HashSet<T> self)
        {
            return self.IsNull() || self.IsEmpty();
        }
    }
}