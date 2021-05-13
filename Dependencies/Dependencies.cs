using System;
using System.Collections.Generic;
using System.Reflection;
#if UNITY_EDITOR
using UnityEditor;
using UnityEditor.Callbacks;
#endif
using UnityEngine;

namespace Common
{
    public static class Dependencies
    {
        private class Listener
        {
            public object target;
            public Action<object> callback;
        }
        
        private class ListenerList : LockList<Listener>
        {
            public void Call(object dependency)
            {
                this.ForEach(listener => listener.callback.Invoke(dependency));
            }

            public void Remove(object target)
            {
                this.RemoveAll(listener => listener.target == target);
            }
        }

        private class DependencyList : List<object>
        {
        }

        private static void DebugLog(string message)
        {
            Debug.Log($"[{typeof(Dependencies).Name}] {message}");
        }
        
        private static Dictionary<Type, ListenerList> s_ListenerLists = new Dictionary<Type, ListenerList>();
        private static Dictionary<Type, DependencyList> s_DependencyLists = new Dictionary<Type, DependencyList>();

        private static void Clear()
        {
            s_ListenerLists = new Dictionary<Type, ListenerList>();
            s_DependencyLists = new Dictionary<Type, DependencyList>();
        }

        private static ListenerList GetListeners(Type type)
        {
            if (!s_ListenerLists.TryGetValue(type, out var result))
                s_ListenerLists[type] = result = new ListenerList();
            return result;
        }
        
        private static void AddListener(Type type, Action<object> callback, object target)
        {
            var listeners = GetListeners(type);
            listeners.Add(new Listener { target = target, callback = callback });
        }
        
        private static void RemoveListeners(Type type, object target)
        {
            var listeners = GetListeners(type);
            listeners.Remove(target);
        }

        private static DependencyList GetDependencies(Type type)
        {
            if (!s_DependencyLists.TryGetValue(type, out var result))
                s_DependencyLists[type] = result = new DependencyList();
            return result;
        }

        private static void AddDependency(Type type, object target)
        {
            var dependencies = GetDependencies(type);
            dependencies.Add(target);
            var listeners = GetListeners(type);
            listeners.Call(target);
        }

        private static void RemoveDependency(Type type, object target)
        {
            var dependencies = GetDependencies(type);
            if (dependencies.Remove(target))
            {
                var listeners = GetListeners(type);
                var dependency = dependencies.LastOrNull();
                listeners.Call(dependency);
            }
        }

        private static object GetDependency(Type type)
        {
            return GetDependencies(type)
                .LastOrNull();
        }

        private static void Install(Type type, FieldInfo field, object target, Install attribute)
        {
            void Update(object value)
            {
                if (attribute.callback != null)
                {
                    var method = type.GetMethod(attribute.callback, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                    if (method != null)
                    {
                        method.Invoke(target, new object[] { value });
                    }
                }

                field.SetValue(target, value);
            }

            var fieldType = field.FieldType;
            AddListener(fieldType, Update, target);

            var dependencies = GetDependencies(fieldType);
            var dependency = dependencies.LastOrNull();
            Update(dependency);
        }

        private static void InstantiateNew(FieldInfo field, DependencyNew attribute)
        {
            var type = attribute.type ?? field.FieldType;
            var args = attribute.args;
            var instance = args != null ? Activator.CreateInstance(type, args) : Activator.CreateInstance(type);

            AddDependency(type, instance);
        }

        private static void InstantiateFromPrefab(FieldInfo field, object target, DependencyFromPrefab attribute)
        {
            var type = attribute.type ?? field.FieldType;
            var prefab = field.GetValue(target) as MonoBehaviour;
            var instance = UnityEngine.Object.Instantiate(prefab);

            AddDependency(type, instance);
        }

        private static void InstantiateFromScene(FieldInfo field, DependencyFromScene attribute)
        {
            var type = attribute.type ?? field.FieldType;
            var instance = UnityEngine.Object.FindObjectOfType(type);

            AddDependency(type, instance);
        }

        private static void InstantiateFromScriptableObject(FieldInfo field, object target, DependencyFromScriptableObject attribute)
        {
            var type = attribute.type ?? field.FieldType;
            var instance = field.GetValue(target);

            AddDependency(type, instance);
        }
        
        public static void Bind(Type type, object target)
        {
            var fields = type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            foreach (var field in fields)
            {
                if (field.TryGetCustomAttribute<Install>(out var install))
                {
                    Install(type, field, target, install);
                }
                else if (field.TryGetCustomAttribute<DependencyNew>(out var dependencyNew))
                {
                    InstantiateNew(field, dependencyNew);
                }
                else if (field.TryGetCustomAttribute<DependencyFromPrefab>(out var dependencyFromPrefab))
                {
                    InstantiateFromPrefab(field, target, dependencyFromPrefab);
                }
                else if (field.TryGetCustomAttribute<DependencyFromScene>(out var dependencyFromScene))
                {
                    InstantiateFromScene(field, dependencyFromScene);
                }
                else if (field.TryGetCustomAttribute<DependencyFromScriptableObject>(out var dependencyFromScriptableObject))
                {
                    InstantiateFromScriptableObject(field, target, dependencyFromScriptableObject);
                }
            }
        }
        
        public static void Bind(object target)
        {
            var type = target.GetType();

            Bind(type, target);
        }
        
        public static void Unbind(Type type, object target)
        {
            // TODO:
            // RemoveListeners(type, target);
            // RemoveDependency(type, target);
        }

#if UNITY_EDITOR
        [DidReloadScripts]
        private static void OnReloadScripts()
        {
            Clear();

            void OnPlayModeStateChanged(PlayModeStateChange change)
            {
                if (change == PlayModeStateChange.ExitingPlayMode)
                {
                    Clear();
                }
            }

            EditorApplication.playModeStateChanged += OnPlayModeStateChanged;
        }
#endif
    }
}