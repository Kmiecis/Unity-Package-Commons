using System.Reflection;

namespace Common.Extensions
{
    public static class MethodInfoExtensions
    {
        public static void Invoke(this MethodInfo self, object obj, params object[] parameters)
        {
            self.Invoke(obj, parameters);
        }
    }
}
