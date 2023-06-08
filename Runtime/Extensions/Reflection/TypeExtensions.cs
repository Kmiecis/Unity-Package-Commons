using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Common.Extensions
{
    public static class TypeExtensions
    {
        public static bool TryGetCustomAttribute<T>(this Type self, out T attribute)
            where T : Attribute
        {
            attribute = self.GetCustomAttribute<T>();
            return attribute != null;
        }

        public static bool IsGenericTypeOf(this Type self, Type type)
        {
            while (self != null)
            {
                if (
                    self.IsGenericType &&
                    self.GetGenericTypeDefinition() == type
                )
                {
                    return true;
                }
                self = self.BaseType;
            }
            return false;
        }

        public static IEnumerable<FieldInfo> GetAllFields(this Type self, BindingFlags bindingAttr)
        {
            if (self != null)
            {
                return self.GetFields(bindingAttr | BindingFlags.DeclaredOnly)
                    .Concat(self.BaseType.GetAllFields(bindingAttr));
            }
            return Enumerable.Empty<FieldInfo>();
        }
    }
}
