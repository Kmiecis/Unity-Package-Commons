using System;
using System.Collections.Generic;
using System.Reflection;

namespace Common
{
    public static class ListExtensions
    {
        public static bool IsNull<T>(this List<T> list)
        {
            return list == null;
        }

        public static bool IsEmpty<T>(this List<T> list)
        {
            return list.Count == 0;
        }

        public static bool IsNullOrEmpty<T>(this List<T> list)
        {
            return list.IsNull() || list.IsEmpty();
        }

        public static int GetCountSafely<T>(this List<T> list)
        {
            return list.IsNull() ? 0 : list.Count;
        }

        public static T First<T>(this List<T> list)
        {
            return list[0];
        }

        public static T FirstOrNull<T>(this List<T> list)
        {
            return list.IsNullOrEmpty() ? default : list.First();
        }

        public static T Last<T>(this List<T> list)
        {
            return list[list.Count - 1];
        }

        public static T LastOrNull<T>(this List<T> list)
        {
            return list.IsNullOrEmpty() ? default : list.Last();
        }

        public static bool TryGet<T>(this List<T> list, int index, out T item)
        {
            if (0 > index || index > list.Count - 1)
            {
                item = default;
                return false;
            }
            item = list[index];
            return true;
        }

        public static bool TryGetFirst<T>(this List<T> list, out T item)
        {
            return list.TryGet(0, out item);
        }

        public static bool TryGetLast<T>(this List<T> list, out T item)
        {
            return list.TryGet(list.Count - 1, out item);
        }

        public static bool TryIndexOf<T>(this List<T> list, T item, out int index)
        {
            index = list.IndexOf(item);
            return index != -1;
        }

        public static bool TryFind<T>(this List<T> list, Predicate<T> match, out T value)
        {
            value = list.Find(match);
            return value != default;
        }

        public static void Swap<T>(this List<T> list, int i, int j)
        {
            var t = list[i];
            list[i] = list[j];
            list[j] = t;
        }

        public static void SwapLast<T>(this List<T> list, int index)
        {
            list.Swap(index, list.Count - 1);
        }

        public static List<T> Populate<T>(this List<T> list, T value)
        {
            return list.Populate(value, list.Capacity);
        }

        public static List<T> Populate<T>(this List<T> list, T value, int count)
        {
            for (int i = 0; i < count; ++i)
                list.Add(value);
            return list;
        }

        public static bool AddUnique<T>(this List<T> list, T item)
        {
            if (!list.Contains(item))
            {
                list.Add(item);
                return true;
            }
            return false;
        }
        
        public static void RemoveLast<T>(this List<T> list)
        {
            list.RemoveAt(list.Count - 1);
        }

        public static void RemoveLast<T>(this List<T> list, int count)
        {
            list.RemoveRange(list.Count - 1 - count, count);
        }

        public static T Revoke<T>(this List<T> list, int index)
        {
            var result = list[index];
            list.RemoveAt(index);
            return result;
        }

        public static T RevokeLast<T>(this List<T> list)
        {
            var last = list.Last();
            list.RemoveLast();
            return last;
        }

        public static T[] RevokeLast<T>(this List<T> list, int count)
        {
            var last = new T[count];
            list.CopyTo(list.Count - 1 - count, last, 0, count);
            list.RemoveLast(count);
            return last;
        }

        public static T[] GetArray<T>(this List<T> list)
        {
            var type = list.GetType();
            var field = type.GetField("_items", BindingFlags.Instance | BindingFlags.NonPublic);
            return (T[])field.GetValue(list);
        }
    }
}