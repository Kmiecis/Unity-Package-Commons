using System;

namespace Common.Extensions
{
    public static class TypeExtensions
    {
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
    }
}
