using System;
using System.Reflection;

namespace Common.Extensions
{
    public static class FieldInfoExtensions
    {
        public static bool TryGetCustomAttribute<T>(this FieldInfo self, out T attribute)
            where T : Attribute
        {
            attribute = self.GetCustomAttribute<T>();
            return attribute != null;
        }

        public static T GetValue<T>(this FieldInfo self, object target)
        {
            return (T)self.GetValue(target);
        }

        public static object GetValueAt(this FieldInfo self, object target, int index)
        {
            var enumerable = self.GetValue(target) as System.Collections.IEnumerable;
            if (enumerable != null)
            {
                var enumerator = enumerable.GetEnumerator();
                for (int i = 0; i <= index; ++i)
                {
                    if (!enumerator.MoveNext())
                    {
                        return null;
                    }
                }
                return enumerator.Current;
            }
            return null;
        }

        public static T GetValueAt<T>(this FieldInfo self, object target, int index)
        {
            return (T)self.GetValueAt(target, index);
        }

        public static bool TryGetValue(this FieldInfo self, object target, out object value)
        {
            value = self.GetValue(target);
            return value != null;
        }

        public static bool TryGetValue<T>(this FieldInfo self, object target, out T value)
        {
            value = self.GetValue<T>(target);
            return value != null;
        }

        public static bool TryGetValueAt(this FieldInfo self, object target, int index, out object value)
        {
            value = self.GetValueAt(target, index);
            return value != null;
        }

        public static bool TryGetValueAt<T>(this FieldInfo self, object target, int index, out T value)
        {
            value = self.GetValueAt<T>(target, index);
            return value != null;
        }
    }
}
