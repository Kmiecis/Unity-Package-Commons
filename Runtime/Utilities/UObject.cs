using Common.Extensions;
using UnityEngine;

namespace Common
{
    public class UObject
    {
        public static void Destroy<T>(ref T obj)
            where T : Object
        {
            if (obj != null)
            {
                obj.Destroy();
                obj = null;
            }
        }

        public T Create<T>(string name)
            where T : Component
        {
            var instance = new GameObject(name);
            return instance.AddComponent<T>();
        }

        public T Create<T>()
            where T : Component
        {
            string name = $"{typeof(T).Name}(New)";
            return Create<T>(name);
        }
    }
}
