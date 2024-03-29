﻿using System;

namespace Common
{
    public static class Utility
    {
        public static void AssignOrThrow<T>(ref T target, T value)
        {
            if (target != null)
                throw new Exception(string.Format("Target {0} already assigned", typeof(T).Name));
            target = value;
        }

        public static void Swap<T>(ref T a, ref T b)
        {
            T t = a;
            a = b;
            b = t;
        }
        
        public static bool TryUpdate<T>(ref T target, T value)
        {
            if (!Equals(target, value))
            {
                target = value;
                return true;
            }
            return false;
        }

        public static bool TryCast<T>(object obj, out T cast)
            where T : class
        {   // Useful when unable to use: obj is T cast
            cast = obj as T;
            return cast != null;
        }
    }
}
