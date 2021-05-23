using System.Collections.Generic;

namespace Common
{
    public static class HashSet
    {
        public static HashSet<T> Of<T>()
        {
            return new HashSet<T>();
        }

        public static HashSet<T> Of<T>(params T[] args)
        {
            return new HashSet<T>(args);
        }
    }
}
