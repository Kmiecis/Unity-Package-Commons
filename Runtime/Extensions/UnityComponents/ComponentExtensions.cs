using System;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Common
{
    public static class ComponentExtensions
    {
        public static bool HasComponent<T>(this Component self)
            where T : Component
        {
            return self.GetComponent<T>() != null;
        }

        public static bool HasComponent(this Component self, Type type)
        {
            return self.GetComponent(type) != null;
        }

        public static bool HasComponentInChildren<T>(this Component self)
            where T : Component
        {
            return self.GetComponentInChildren<T>() != null;
        }

        public static bool HasComponentInChildren(this Component self, Type type)
        {
            return self.GetComponentInChildren(type) != null;
        }

        public static bool HasComponentInParent<T>(this Component self)
            where T : Component
        {
            return self.GetComponentInParent<T>() != null;
        }

        public static bool HasComponentInParent(this Component self, Type type)
        {
            return self.GetComponentInParent(type) != null;
        }

        public static T AddComponent<T>(this Component self)
            where T : Component
        {
            return self.gameObject.AddComponent<T>();
        }

        public static T EnsureComponent<T>(this Component self)
            where T : Component
        {
            if (!self.TryGetComponent<T>(out T component))
                component = self.AddComponent<T>();
            return component;
        }

        public static void RemoveComponent<T>(this Component self)
            where T : Component
        {
            if (self.TryGetComponent<T>(out var component))
                Object.Destroy(component);
        }

        public static T RequireComponent<T>(this Component self)
            where T : Component
        {
            var result = self.GetComponent<T>();
            if (result == null)
                throw new NullReferenceException($"Required {typeof(T)} Component not found at {self.GetHierarchyPath()}");
            return result;
        }

        public static string GetHierarchyPath(this Component self, char delimiter = '/')
        {
            return self.transform.GetHierarchyPath(delimiter);
        }

        public static bool TryGetComponentInChildren<T>(this Component self, out T component, bool includeInactive = false)
            where T : Component
        {
            component = self.GetComponentInChildren<T>(includeInactive);
            return component != null;
        }

        public static bool TryGetComponentInChildren(this Component self, Type type, out Component component, bool includeInactive = false)
        {
            component = self.GetComponentInChildren(type, includeInactive);
            return component != null;
        }

        public static bool TryGetComponentInParent<T>(this Component self, out T component, bool includeInactive = false)
            where T : Component
        {
            component = self.GetComponentInParent<T>(includeInactive);
            return component != null;
        }

        public static bool TryGetComponentInParent(this Component self, Type type, out Component component, bool includeInactive = false)
        {
            component = self.GetComponentInParent(type, includeInactive);
            return component != null;
        }

        public static bool TryGetComponents<T>(this Component self, out T[] components)
            where T : Component
        {
            components = self.GetComponents<T>();
            return !components.IsNullOrEmpty();
        }

        public static bool TryGetComponents(this Component self, Type type, out Component[] components)
        {
            components = self.GetComponents(type);
            return !components.IsNullOrEmpty();
        }

        public static bool TryGetComponentsInChildren<T>(this Component self, out T[] components, bool includeInactive = false)
            where T : Component
        {
            components = self.GetComponentsInChildren<T>(includeInactive);
            return !components.IsNullOrEmpty();
        }

        public static bool TryGetComponentsInChildren(this Component self, Type type, out Component[] components, bool includeInactive = false)
        {
            components = self.GetComponentsInChildren(type, includeInactive);
            return !components.IsNullOrEmpty();
        }

        public static bool TryGetComponentsInParent<T>(this Component self, out T[] components, bool includeInactive = false)
            where T : Component
        {
            components = self.GetComponentsInParent<T>(includeInactive);
            return !components.IsNullOrEmpty();
        }

        public static bool TryGetComponentsInParent(this Component self, Type type, out Component[] components, bool includeInactive = false)
        {
            components = self.GetComponentsInParent(type, includeInactive);
            return !components.IsNullOrEmpty();
        }

        public static void Remove(this Component self)
        {
            UObject.Destroy(self);
        }

        public static void Remove(this Component self, float t)
        {
            Object.Destroy(self, t);
        }

        public static void Destroy(this Component self)
        {
            UObject.Destroy(self.gameObject);
        }

        public static void Destroy(this Component self, float t)
        {
            Object.Destroy(self.gameObject, t);
        }
    }
}
