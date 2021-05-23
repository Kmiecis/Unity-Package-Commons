using System.Collections.Generic;

namespace Common
{
    public static class Queue
    {
        public static Queue<T> Of<T>()
        {
            return new Queue<T>();
        }

        public static Queue<T> Of<T>(params T[] args)
        {
            return new Queue<T>(args);
        }
    }
}
