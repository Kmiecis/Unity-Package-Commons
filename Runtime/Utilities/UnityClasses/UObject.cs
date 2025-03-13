using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Common
{
    public class UObject
    {
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

        public static GameObject Instantiate(GameObject prefab, Transform parent = null)
        {
            if (Application.isPlaying)
            {
                return Object.Instantiate(prefab, parent);
            }
#if UNITY_EDITOR
            return (GameObject)UnityEditor.PrefabUtility.InstantiatePrefab(prefab, parent);
#else
            return null;
#endif
        }

        public static T Instantiate<T>(T prefab, Transform parent = null)
            where T : Component
        {
            if (Application.isPlaying)
            {
                return Object.Instantiate<T>(prefab, parent);
            }
#if UNITY_EDITOR
            return (T)UnityEditor.PrefabUtility.InstantiatePrefab(prefab, parent);
#else
            return null;
#endif
        }

        public static void Destroy<T>(T obj)
            where T : Object
        {
            if (Application.isPlaying)
            {
                Object.Destroy(obj);
            }
            else
            {
                Object.DestroyImmediate(obj);
            }
        }

        public static void Destroy<T>(ref T obj)
            where T : Object
        {
            if (obj != null)
            {
                Destroy(obj);
                obj = null;
            }
        }

        public static void Destroy<T>(IEnumerable<T> objs)
            where T : Object
        {
            foreach (var obj in objs)
            {
                Destroy(obj);
            }
        }

        public static void DestroyObject<T>(ref T comp)
            where T : Component
        {
            if (comp != null)
            {
                Destroy(comp.gameObject);
                comp = null;
            }
        }

        public static void DestroyObject<T>(IEnumerable<T> comps)
            where T : Component
        {
            foreach (var comp in comps)
            {
                Destroy(comp.gameObject);
            }
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
