using System;

namespace Common
{
    public static class TypeExtensions
    {
        public static bool IsGenericTypeOf(this Type self, Type type)
        {
            return self.IsGenericType && self.GetGenericTypeDefinition() == type;
        }
    }
}