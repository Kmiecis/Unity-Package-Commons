using System;

namespace Common
{
    public static class Utility
    {
        public static void AssignOrThrow<T>(ref T target, T value)
        {
            if (target != null)
            {
                throw new Exception(string.Format("Target {0} already assigned", typeof(T).Name));
            }
            target = value;
        }

        public static bool EqualsSafely(object left, object right)
        {
            return left != null ? left.Equals(right) : right != null ? right.Equals(left) : true;
        }

        public static void Swap<T>(ref T a, ref T b)
        {
            T t = a;
            a = b;
            b = t;
        }
        
        public static bool TryUpdate<T>(ref T value, T item)
        {
            if (!EqualsSafely(value, item))
            {
                value = item;
                return true;
            }
            return false;
        }

        public static bool TryCast<T>(object obj, out T cast)
        {
            if (obj is T)
            {
                cast = (T)obj;
                return true;
            }
            cast = default;
            return false;
        }
    }
}