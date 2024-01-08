using System;
using System.Reflection;

namespace Common.Extensions
{
    public static class MethodInfoExtensions
    {
        public static void Invoke(this MethodInfo self, object obj, params object[] parameters)
        {
            self.Invoke(obj, parameters);
        }

        public static bool HasMatchingParameters(this MethodInfo self, params Type[] types)
        {
            var parameters = self.GetParameters();
            if (parameters.Length == types.Length)
            {
                for (int i = 0; i < parameters.Length; ++i)
                {
                    var parameter = parameters[i];
                    var type = types[i];

                    if (parameter.ParameterType != type)
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
    }
}
