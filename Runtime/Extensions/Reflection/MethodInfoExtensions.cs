using System;
using System.Reflection;

namespace Common
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

        public static T AsDelegate<T>(this MethodInfo self)
            where T : Delegate
        {
            return (T)self.CreateDelegate(typeof(T));
        }

        public static Action AsAction(this MethodInfo self)
        {
            return self.AsDelegate<Action>();
        }

        public static Action<T> AsAction<T>(this MethodInfo self)
        {
            return self.AsDelegate<Action<T>>();
        }

        public static Action<T1, T2> AsAction<T1, T2>(this MethodInfo self)
        {
            return self.AsDelegate<Action<T1, T2>>();
        }

        public static Func<TResult> AsFunc<TResult>(this MethodInfo self)
        {
            return self.AsDelegate<Func<TResult>>();
        }

        public static Func<T, TResult> AsFunc<T, TResult>(this MethodInfo self)
        {
            return self.AsDelegate<Func<T, TResult>>();
        }

        public static Func<T1, T2, TResult> AsFunc<T1, T2, TResult>(this MethodInfo self)
        {
            return self.AsDelegate<Func<T1, T2, TResult>>();
        }
    }
}
