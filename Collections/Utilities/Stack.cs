using System.Collections.Generic;

namespace Common
{
    public static class Stack
    {
        public static Stack<T> Of<T>()
        {
            return new Stack<T>();
        }

        public static Stack<T> Of<T>(params T[] args)
        {
            return new Stack<T>(args);
        }
    }
}
