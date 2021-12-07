using System;
using System.Collections.Generic;
using System.Reflection;

namespace Common.Extensions
{
    public static class ListExtensions
    {
        public static bool IsNull<T>(this List<T> self)
        {
            return self == null;
        }

        public static bool IsEmpty<T>(this List<T> self)
        {
            return self.Count == 0;
        }

        public static bool IsNullOrEmpty<T>(this List<T> self)
        {
            return self.IsNull() || self.IsEmpty();
        }

        public static int GetCountSafely<T>(this List<T> self)
        {
            return self.IsNull() ? 0 : self.Count;
        }

        public static T First<T>(this List<T> self)
        {
            return self[0];
        }

        public static T FirstOrDefault<T>(this List<T> self, T value = default)
        {
            return self.IsNullOrEmpty() ? value : self.First();
        }

        public static T Last<T>(this List<T> self)
        {
            return self[self.Count - 1];
        }

        public static T LastOrDefault<T>(this List<T> self, T value = default)
        {
            return self.IsNullOrEmpty() ? value : self.Last();
        }

        public static bool TryGet<T>(this List<T> self, int index, out T item)
        {
            if (0 > index || index > self.Count - 1)
            {
                item = default;
                return false;
            }
            item = self[index];
            return true;
        }

        public static bool TryGetFirst<T>(this List<T> self, out T item)
        {
            return self.TryGet(0, out item);
        }

        public static bool TryGetLast<T>(this List<T> self, out T item)
        {
            return self.TryGet(self.Count - 1, out item);
        }

        public static bool TryIndexOf<T>(this List<T> self, T item, out int index)
        {
            index = self.IndexOf(item);
            return index != -1;
        }

        public static bool TryIndexOf<T>(this List<T> self, T item, int startIndex, out int index)
        {
            index = self.IndexOf(item, startIndex);
            return index != -1;
        }

        public static bool TryIndexOf<T>(this List<T> self, T item, int startIndex, int count, out int index)
        {
            index = self.IndexOf(item, startIndex, count);
            return index != -1;
        }

        public static bool TryFind<T>(this List<T> self, Predicate<T> match, out T value)
        {
            value = self.Find(match);
            return value != default;
        }

        public static bool TryFindLast<T>(this List<T> self, Predicate<T> match, out T value)
        {
            value = self.FindLast(match);
            return value != default;
        }

        public static bool TryFindAll<T>(this List<T> self, Predicate<T> match, out List<T> value)
        {
            value = self.FindAll(match);
            return value != default;
        }

        public static bool TryFindIndex<T>(this List<T> self, Predicate<T> match, out int index)
        {
            index = self.FindIndex(match);
            return index != -1;
        }

        public static bool TryFindIndex<T>(this List<T> self, int startIndex, Predicate<T> match, out int index)
        {
            index = self.FindIndex(startIndex, match);
            return index != -1;
        }

        public static bool TryFindIndex<T>(this List<T> self, int startIndex, int count, Predicate<T> match, out int index)
        {
            index = self.FindIndex(startIndex, count, match);
            return index != -1;
        }

        public static bool TryFindLastIndex<T>(this List<T> self, Predicate<T> match, out int index)
        {
            index = self.FindLastIndex(match);
            return index != -1;
        }

        public static bool TryFindLastIndex<T>(this List<T> self, int startIndex, Predicate<T> match, out int index)
        {
            index = self.FindLastIndex(startIndex, match);
            return index != -1;
        }

        public static bool TryFindLastIndex<T>(this List<T> self, int startIndex, int count, Predicate<T> match, out int index)
        {
            index = self.FindLastIndex(startIndex, count, match);
            return index != -1;
        }

        public static void Swap<T>(this List<T> self, int i, int j)
        {
            var t = self[i];
            self[i] = self[j];
            self[j] = t;
        }

        public static void SwapLast<T>(this List<T> self, int index)
        {
            self.Swap(index, self.Count - 1);
        }

        public static List<T> Populate<T>(this List<T> self, T value)
        {
            return self.Populate(value, self.Capacity);
        }

        public static List<T> Populate<T>(this List<T> self, T value, int count)
        {
            for (int i = 0; i < count; ++i)
                self.Add(value);
            return self;
        }

        public static bool AddUnique<T>(this List<T> self, T item)
        {
            if (!self.Contains(item))
            {
                self.Add(item);
                return true;
            }
            return false;
        }

        public static void RemoveLast<T>(this List<T> self)
        {
            self.RemoveAt(self.Count - 1);
        }

        public static void RemoveLast<T>(this List<T> self, int count)
        {
            self.RemoveRange(self.Count - 1 - count, count);
        }

        public static T Revoke<T>(this List<T> self, int index)
        {
            var result = self[index];
            self.RemoveAt(index);
            return result;
        }

        public static T RevokeLast<T>(this List<T> self)
        {
            var last = self.Last();
            self.RemoveLast();
            return last;
        }

        public static T[] RevokeLast<T>(this List<T> self, int count)
        {
            var last = new T[count];
            self.CopyTo(self.Count - 1 - count, last, 0, count);
            self.RemoveLast(count);
            return last;
        }

        public static T[] GetArray<T>(this List<T> self)
        {
            var type = self.GetType();
            var field = type.GetField("_items", BindingFlags.Instance | BindingFlags.NonPublic);
            return (T[])field.GetValue(self);
        }
    }
}
