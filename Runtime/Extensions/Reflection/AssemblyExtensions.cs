using System;
using System.Collections.Generic;
using System.Reflection;

namespace Common
{
    public static class AssemblyExtensions
    {
        public static Type FindType(this Assembly self, string name, StringComparison stringComp = StringComparison.Ordinal)
        {
            var typeName = name.RemoveSuffix("[]");
            var isArray = typeName != name;

            var types = self.GetTypes();
            foreach (var type in types)
            {
                if (string.Equals(typeName, type.Name, stringComp) ||
                    string.Equals(typeName, type.FullName, stringComp))
                {
                    if (isArray)
                    {
                        return type.MakeArrayType();
                    }
                    else
                    {
                        return type;
                    }
                }
            }

            return null;
        }

        public static IEnumerable<Type> FindTypes(this Assembly self, Predicate<Type> match)
        {
            var types = self.GetTypes();
            foreach (var type in types)
            {
                if (match(type))
                {
                    yield return type;
                }
            }
        }
    }
}