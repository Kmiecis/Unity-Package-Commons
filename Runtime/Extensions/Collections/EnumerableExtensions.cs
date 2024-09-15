using System.Collections.Generic;

namespace Common.Extensions
{
    public static class EnumerableExtensions
    {
        public static bool IsEmpty<T>(this IEnumerable<T> self)
        {
            using var e = self.GetEnumerator();
            return !e.MoveNext();
        }
    }
}