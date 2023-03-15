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
    }
}
