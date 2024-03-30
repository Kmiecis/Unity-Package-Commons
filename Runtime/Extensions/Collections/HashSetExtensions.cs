using System.Collections.Generic;

namespace Common.Extensions
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

        public static bool Contains<T>(this HashSet<T> self, IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                if (!self.Contains(item))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool Remove<T>(this HashSet<T> self, IEnumerable<T> items)
        {
            var result = true;
            foreach (var item in items)
            {
                result &= self.Remove(item);
            }
            return result;
        }
    }
}
