using System;

namespace Common.Extensions
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
        
        public static T First<T>(this T[] self)
        {
            return self[0];
        }

        public static T FirstOrDefault<T>(this T[] self, T value = default)
        {
            return self.IsNullOrEmpty() ? value : self.First();
        }

        public static T Last<T>(this T[] self)
        {
            return self[self.Length - 1];
        }

        public static T LastOrDefault<T>(this T[] self, T value = default)
        {
            return self.IsNullOrEmpty() ? value : self.Last();
        }

        public static bool ContainsIndex<T>(this T[] self, int index)
        {
            return -1 < index && index < self.Length;
        }

        public static bool TryGet<T>(this T[] self, int index, out T item)
        {
            item = self.ContainsIndex(index) ? self[index] : default;
            return item != default;
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

        public static bool TryIndexOf<T>(this T[] self, T value, int startIndex, out int index)
        {
            index = Array.IndexOf(self, value, startIndex);
            return index != -1;
        }

        public static bool TryIndexOf<T>(this T[] self, T value, int startIndex, int count, out int index)
        {
            index = Array.IndexOf(self, value, startIndex, count);
            return index != -1;
        }

        public static bool TryFind<T>(this T[] self, Predicate<T> match, out T value)
        {
            value = Array.Find(self, match);
            return value != default;
        }

        public static bool TryFindLast<T>(this T[] self, Predicate<T> match, out T value)
        {
            value = Array.FindLast(self, match);
            return value != default;
        }

        public static bool TryFindAll<T>(this T[] self, Predicate<T> match, out T[] value)
        {
            value = Array.FindAll(self, match);
            return value != default;
        }

        public static bool TryFindIndex<T>(this T[] self, Predicate<T> match, out int index)
        {
            index = Array.FindIndex(self, match);
            return index != -1;
        }

        public static bool TryFindIndex<T>(this T[] self, int startIndex, Predicate<T> match, out int index)
        {
            index = Array.FindIndex(self, startIndex, match);
            return index != -1;
        }

        public static bool TryFindIndex<T>(this T[] self, int startIndex, int count, Predicate<T> match, out int index)
        {
            index = Array.FindIndex(self, startIndex, count, match);
            return index != -1;
        }

        public static bool TryFindLastIndex<T>(this T[] self, Predicate<T> match, out int index)
        {
            index = Array.FindLastIndex(self, match);
            return index != -1;
        }

        public static bool TryFindLastIndex<T>(this T[] self, int startIndex, Predicate<T> match, out int index)
        {
            index = Array.FindLastIndex(self, startIndex, match);
            return index != -1;
        }

        public static bool TryFindLastIndex<T>(this T[] self, int startIndex, int count, Predicate<T> match, out int index)
        {
            index = Array.FindLastIndex(self, startIndex, count, match);
            return index != -1;
        }

        public static void Swap<T>(this T[] self, int a, int b)
        {
            var t = self[a];
            self[a] = self[b];
            self[b] = t;
        }

        public static T[] Populate<T>(this T[] self, T value)
        {
            for (int i = 0; i < self.Length; ++i)
            {
                self[i] = value;
            }
            return self;
        }

        public static T[] Populate<T>(this T[] self, Func<T> generator)
        {
            for (int i = 0; i < self.Length; ++i)
            {
                self[i] = generator();
            }
            return self;
        }

        public static bool Contains<T>(this T[] self, T value)
        {
            return Array.IndexOf(self, value) != -1;
        }

        public static void ForEach<T>(this T[] self, Action<T> action)
        {
            for (int i = 0; i < self.Length; ++i)
            {
                action(self[i]);
            }
        }
    }
}
