using System.Reflection;

namespace Common
{
    public static class MethodInfoExtensions
    {
        public static void Invoke(this MethodInfo self, object obj, object parameter)
        {
            self.Invoke(obj, new object[] { parameter });
        }
    }
}
