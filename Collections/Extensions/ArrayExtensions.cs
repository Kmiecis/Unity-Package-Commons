using System;

namespace Common
{
    public static class ArrayExtensions
    {
        public static bool IsNull<T>(this T[] self)
        {
            return self == null;
        }

        public static bool IsEmpty<T>(this T[] self)
        {
            return self.Length == 0;
        }

        public static bool IsNullOrEmpty<T>(this T[] self)
        {
            return self.IsNull() || self.IsEmpty();
        }
        
        public static int GetLengthSafely<T>(this T[] self)
        {
            return self.IsNull() ? 0 : self.Length;
        }

        public static T First<T>(this T[] self)
        {
            return self[0];
        }

        public static T FirstOrNull<T>(this T[] self)
        {
            return self.IsNullOrEmpty() ? default : self.First();
        }

        public static T Last<T>(this T[] self)
        {
            return self[self.Length - 1];
        }

        public static T LastOrNull<T>(this T[] self)
        {
            return self.IsNullOrEmpty() ? default : self.Last();
        }

        public static bool TryGet<T>(this T[] self, int index, out T item)
        {
            if (0 > index || index > self.Length - 1)
            {
                item = default;
                return false;
            }
            item = self[index];
            return true;
        }

        public static bool TryGetFirst<T>(this T[] self, out T item)
        {
            return self.TryGet(0, out item);
        }

        public static bool TryGetLast<T>(this T[] self, out T item)
        {
            return self.TryGet(self.Length - 1, out item);
        }

        public static bool TryIndexOf<T>(this T[] self, T value, out int index)
        {
            index = Array.IndexOf(self, value);
            return index != -1;
        }

        public static bool TryFind<T>(this T[] self, Predicate<T> match, out T value)
        {
            value = Array.Find(self, match);
            return value != default;
        }

        public static void Swap<T>(this T[] self, int i, int j)
        {
            var t = self[i];
            self[i] = self[j];
            self[j] = t;
        }
        
        public static T[] Populate<T>(this T[] self, T value)
        {
            for (int i = 0; i < self.Length; ++i)
                self[i] = value;
            return self;
        }
        
        public static bool Contains<T>(this T[] self, T value)
        {
            return Array.IndexOf(self, value) != -1;
        }
    }
}