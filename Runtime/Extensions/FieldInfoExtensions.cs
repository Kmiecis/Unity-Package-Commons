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
    }
}
