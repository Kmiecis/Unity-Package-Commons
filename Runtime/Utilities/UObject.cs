using Common.Extensions;
using UnityEngine;

namespace Common
{
    public class UObject
    {
        public static void Destroy<T>(T obj)
            where T : Object
        {
            if (obj != null)
            {
                obj.Destroy();
            }
        }

        public static void Destroy<T>(ref T obj)
            where T : Object
        {
            if (obj != null)
            {
                obj.Destroy();
                obj = null;
            }
        }

        public static void DestroyObject<T>(T comp)
            where T : Component
        {
            if (comp != null)
            {
                comp.DestroyObject();
            }
        }

        public static void DestroyObject<T>(ref T comp)
            where T : Component
        {
            if (comp != null)
            {
                comp.DestroyObject();
                comp = null;
            }
        }

        public static T Create<T>(string name)
            where T : Component
        {
            var instance = new GameObject(name);
            return instance.AddComponent<T>();
        }

        public static T Create<T>()
            where T : Component
        {
            string name = $"{typeof(T).Name}(New)";
            return Create<T>(name);
        }
    }
}
