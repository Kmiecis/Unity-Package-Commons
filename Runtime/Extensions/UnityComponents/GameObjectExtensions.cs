using System;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Common.Extensions
{
    public static class GameObjectExtensions
    {
        public static bool IsPrefab(this GameObject self)
        {
            return self.scene.IsValid();
        }

        public static bool HasComponent<T>(this GameObject self)
        {
            return self.GetComponent<T>() != null;
        }

        public static bool HasComponent(this GameObject self, Type type)
        {
            return self.GetComponent(type) != null;
        }

        public static bool HasComponentInChildren<T>(this GameObject self)
        {
            return self.GetComponentInChildren<T>() != null;
        }

        public static bool HasComponentInChildren(this GameObject self, Type type)
        {
            return self.GetComponentInChildren(type) != null;
        }

        public static bool HasComponentInParent<T>(this GameObject self)
        {
            return self.GetComponentInParent<T>() != null;
        }

        public static bool HasComponentInParent(this GameObject self, Type type)
        {
            return self.GetComponentInParent(type) != null;
        }

        public static T EnsureComponent<T>(this GameObject self)
            where T : Component
        {
            if (!self.TryGetComponent<T>(out T component))
                component = self.AddComponent<T>();
            return component;
        }

        public static void RemoveComponent<T>(this GameObject self)
            where T : Component
        {
            if (self.TryGetComponent<T>(out var component))
                Object.Destroy(component);
        }

        public static T RequireComponent<T>(this GameObject self)
        {
            var result = self.GetComponent<T>();
            if (result == null)
                throw new NullReferenceException($"Required {typeof(T)} Component not found at {self.GetHierarchyPath()}");
            return result;
        }

        public static string GetHierarchyPath(this GameObject self, char delimiter = '/')
        {
            return self.transform.GetHierarchyPath(delimiter);
        }

        public static bool TryGetComponentInChildren<T>(this GameObject self, out T component, bool includeInactive = false)
        {
            component = self.GetComponentInChildren<T>(includeInactive);
            return component != null;
        }

        public static bool TryGetComponentInChildren(this GameObject self, Type type, out Component component, bool includeInactive = false)
        {
            component = self.GetComponentInChildren(type, includeInactive);
            return component != null;
        }

        public static bool TryGetComponentInParent<T>(this GameObject self, out T component, bool includeInactive = false)
        {
            component = self.GetComponentInParent<T>(includeInactive);
            return component != null;
        }

        public static bool TryGetComponentInParent(this GameObject self, Type type, out Component component, bool includeInactive = false)
        {
            component = self.GetComponentInParent(type, includeInactive);
            return component != null;
        }

        public static bool TryGetComponents<T>(this GameObject self, out T[] components)
        {
            components = self.GetComponents<T>();
            return !components.IsNullOrEmpty();
        }

        public static bool TryGetComponents(this GameObject self, Type type, out Component[] components)
        {
            components = self.GetComponents(type);
            return !components.IsNullOrEmpty();
        }

        public static bool TryGetComponentsInChildren<T>(this GameObject self, out T[] components, bool includeInactive = false)
        {
            components = self.GetComponentsInChildren<T>(includeInactive);
            return !components.IsNullOrEmpty();
        }

        public static bool TryGetComponentsInChildren(this GameObject self, Type type, out Component[] components, bool includeInactive = false)
        {
            components = self.GetComponentsInChildren(type, includeInactive);
            return !components.IsNullOrEmpty();
        }

        public static bool TryGetComponentsInParent<T>(this GameObject self, out T[] components, bool includeInactive = false)
        {
            components = self.GetComponentsInParent<T>(includeInactive);
            return !components.IsNullOrEmpty();
        }

        public static bool TryGetComponentsInParent(this GameObject self, Type type, out Component[] components, bool includeInactive = false)
        {
            components = self.GetComponentsInParent(type, includeInactive);
            return !components.IsNullOrEmpty();
        }

        public static void SetLayerRecursively(this GameObject self, int layer)
        {
            foreach (var child in self.transform.GetDownwardEnumerator())
            {
                child.gameObject.layer = layer;
            }
        }
    }
}
