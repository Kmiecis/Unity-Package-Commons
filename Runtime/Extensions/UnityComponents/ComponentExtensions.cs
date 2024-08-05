using System;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Common.Extensions
{
    public static class ComponentExtensions
    {
        public static bool HasComponent<T>(this Component self)
        {
            return self.GetComponent<T>() != null;
        }

        public static bool HasComponent(this Component self, Type type)
        {
            return self.GetComponent(type) != null;
        }

        public static bool HasComponentInChildren<T>(this Component self)
        {
            return self.GetComponentInChildren<T>() != null;
        }

        public static bool HasComponentInChildren(this Component self, Type type)
        {
            return self.GetComponentInChildren(type) != null;
        }

        public static bool HasComponentInParent<T>(this Component self)
        {
            return self.GetComponentInParent<T>() != null;
        }

        public static bool HasComponentInParent(this Component self, Type type)
        {
            return self.GetComponentInParent(type) != null;
        }

        public static void RemoveComponent<T>(this Component self)
            where T : Component
        {
            if (self.TryGetComponent<T>(out var component))
                Object.Destroy(component);
        }

        public static string GetHierarchyPath(this Component self, char delimiter = '/')
        {
            return self.transform.GetHierarchyPath(delimiter);
        }

        public static bool TryGetComponentInChildren<T>(this Component self, out T component, bool includeInactive = false)
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
        {
            components = self.GetComponentsInParent<T>(includeInactive);
            return !components.IsNullOrEmpty();
        }

        public static bool TryGetComponentsInParent(this Component self, Type type, out Component[] components, bool includeInactive = false)
        {
            components = self.GetComponentsInParent(type, includeInactive);
            return !components.IsNullOrEmpty();
        }

        public static void DestroyObject(this Component self)
        {
            self.gameObject.Destroy();
        }

        public static void Destroy(this Component self, float t)
        {
            self.gameObject.Destroy(t);
        }
    }
}
