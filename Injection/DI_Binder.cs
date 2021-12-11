using Common.Extensions;
using System;
using System.Collections.Generic;
using System.Reflection;
#if UNITY_EDITOR
using UnityEditor;
using UnityEditor.Callbacks;
#endif
using UnityEngine;

namespace Common.Injection
{
    /// <summary>
    /// Handles class fields marked by <see cref="DI_Inject"/> and <see cref="DI_Install"/> dependency binding
    /// </summary>
    public static class DI_Binder
    {
        private class Listener
        {
            public object target;
            public Action<object> callback;
        }

        private class ListenerList : List<Listener>
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

        private static void DebugWarning(string message)
        {
            Debug.LogWarning($"[{nameof(DI_Binder)}] {message}");
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
                var dependency = dependencies.LastOrDefault();
                listeners.Call(dependency);
            }
        }

        private static void Inject(FieldInfo field, object target, DI_Inject attribute)
        {
            var type = attribute.type ?? field.FieldType;

            void Update(object value)
            {
                var callback = $"On{type.Name}Inject";
                if (value != null)
                {
                    var targetType = target.GetType();
                    var method = targetType.GetMethod(callback, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                    if (method != null)
                    {
                        method.Invoke(target, new object[] { value });
                    }
                }

                field.SetValue(target, value);
            }

            AddListener(type, Update, target);

            var dependencies = GetDependencies(type);
            var dependency = dependencies.LastOrDefault();
            Update(dependency);
        }

        private static void Uninject(FieldInfo field, object target, DI_Inject attribute)
        {
            var type = attribute.type ?? field.FieldType;

            RemoveListeners(type, target);

            field.SetValue(target, null);
        }

        private static void Install(FieldInfo field, object target, DI_Install attribute)
        {
            var type = attribute.type ?? field.FieldType;

            var dependency = field.GetValue(target);
            if (dependency != null)
            {
                if (
                    dependency is Component component &&
                    component.gameObject.IsPrefab()
                )
                {
                    dependency = UnityEngine.Object.Instantiate(component);
                }
            }
            else
            {
                if (type.IsSubclassOf(typeof(Component)))
                {
                    dependency = UnityEngine.Object.FindObjectOfType(type);

                    if (dependency == null)
                    {
                        var gameObject = new GameObject($"{type.Name}(Clone)");
                        dependency = gameObject.AddComponent(type);
                    }
                }
                else
                {
                    var args = attribute.args;
                    dependency = args != null ? Activator.CreateInstance(type, args) : Activator.CreateInstance(type);
                }
            }

            if (dependency != null)
            {
                AddDependency(type, dependency);
            }
            else
            {
                DebugWarning($"Couldn't install dependency from {target.GetType().Name}.{field.Name}");
            }

            field.SetValue(target, dependency);
        }

        private static void Uninstall(FieldInfo field, object target, DI_Install attribute)
        {
            var type = attribute.type ?? field.FieldType;

            var dependency = field.GetValue(target);

            if (dependency != null)
            {
                RemoveDependency(type, dependency);
            }

            field.SetValue(target, null);
        }

        public static void Bind(object target)
        {
            var type = target.GetType();
            var fields = type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            foreach (var field in fields)
            {
                if (field.TryGetCustomAttribute<DI_Install>(out var attributeInstall))
                {
                    Install(field, target, attributeInstall);
                }
                else if (field.TryGetCustomAttribute<DI_Inject>(out var attributeInject))
                {
                    Inject(field, target, attributeInject);
                }
            }
        }

        public static void Unbind(object target)
        {
            var type = target.GetType();
            var fields = type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            foreach (var field in fields)
            {
                if (field.TryGetCustomAttribute<DI_Inject>(out var attributeInject))
                {
                    Uninject(field, target, attributeInject);
                }
                else if (field.TryGetCustomAttribute<DI_Install>(out var attributeInstall))
                {
                    Uninstall(field, target, attributeInstall);
                }
            }
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
