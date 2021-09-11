using System;

namespace Common.Extensions
{
    public static class TypeExtensions
    {
        public static bool IsGenericTypeOf(this Type self, Type type)
        {
            return self.IsGenericType && self.GetGenericTypeDefinition() == type;
        }
    }
}
