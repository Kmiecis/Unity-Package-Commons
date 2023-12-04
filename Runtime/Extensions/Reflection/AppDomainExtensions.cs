using System;
using System.Collections.Generic;

namespace Common.Extensions
{
    public static class AppDomainExtensions
    {
        public static Type FindType(this AppDomain self, string name, StringComparison stringComp = StringComparison.Ordinal)
        {
            var typeName = name.RemoveSuffix("[]");
            var isArray = typeName != name;

            var assemblies = self.GetAssemblies();
            foreach (var assembly in assemblies)
            {
                var types = assembly.GetTypes();
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
            }

            return null;
        }

        public static IEnumerable<Type> GetTypes(this AppDomain self, Predicate<Type> match)
        {
            var assemblies = self.GetAssemblies();
            foreach (var assembly in assemblies)
            {
                var types = assembly.GetTypes();
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
}