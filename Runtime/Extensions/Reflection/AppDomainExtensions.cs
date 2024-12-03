using System;
using System.Collections.Generic;

namespace Common.Extensions
{
    public static class AppDomainExtensions
    {
        public static Type FindType(this AppDomain self, string name, StringComparison stringComp = StringComparison.Ordinal)
        {
            var assemblies = self.GetAssemblies();
            foreach (var assembly in assemblies)
            {
                var type = assembly.FindType(name, stringComp);
                if (type != null)
                {
                    return type;
                }
            }

            return null;
        }

        public static IEnumerable<Type> FindTypes(this AppDomain self, Predicate<Type> match)
        {
            foreach (var assembly in self.GetAssemblies())
            {
                foreach (var type in assembly.FindTypes(match))
                {
                    yield return type;
                }
            }
        }

        public static IEnumerable<Type> GetTypes(this AppDomain self, Predicate<Type> match)
        {
            var assemblies = self.GetAssemblies();
            foreach (var assembly in assemblies)
            {
                foreach (var type in assembly.GetTypes(match))
                {
                    yield return type;
                }
            }
        }
    }
}