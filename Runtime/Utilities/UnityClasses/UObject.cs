using Common.Extensions;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

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

        public static IEnumerable<T> FindOfType<T>(bool includeInactive = false)
        {
            foreach (var found in FindOfType(typeof(T), includeInactive))
            {
                yield return (T)found;
            }
        }

        public static IEnumerable<object> FindOfType(System.Type type, bool includeInactive = false)
        {
            return SceneManager.GetActiveScene()
                .GetRootGameObjects()
                .SelectMany(go => go.GetComponentsInChildren(type, includeInactive));
        }
    }
}
