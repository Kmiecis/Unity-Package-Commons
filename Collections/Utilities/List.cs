using System.Collections.Generic;

namespace Common
{
    public static class List
    {
        public static List<T> Of<T>()
        {
            return new List<T>();
        }

        public static List<T> Of<T>(params T[] args)
        {
            return new List<T>(args);
        }
    }
}
