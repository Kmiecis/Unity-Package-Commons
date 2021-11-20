using System.Collections.Generic;

namespace Common.Collections
{
    public static class Lists
    {
        public static List<T> New<T>()
        {
            return new List<T>();
        }
    }
}
