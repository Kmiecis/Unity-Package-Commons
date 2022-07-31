using UnityEngine;

namespace Common.Extensions
{
    public static class ComponentExtensions
    {
        public static bool HasComponent<T>(this Component self)
            where T : Component
        {
            return self.GetComponent<T>() != null;
        }

        public static void RemoveComponent<T>(this Component self)
            where T : Component
        {
            if (self.TryGetComponent<T>(out var component))
                Object.Destroy(component);
        }
        
        public static bool TryGetComponentInChildren<T>(this Component self, out T component)
        {
            component = self.GetComponentInChildren<T>();
            return component != null;
        }

        public static bool TryGetComponentInParent<T>(this Component self, out T component)
        {
            component = self.GetComponentInParent<T>();
            return component != null;
        }

        public static bool TryGetComponents<T>(this Component self, out T[] components)
        {
            components = self.GetComponents<T>();
            return !components.IsNullOrEmpty();
        }

        public static bool TryGetComponentsInChildren<T>(this Component self, out T[] components)
        {
            components = self.GetComponentsInChildren<T>();
            return !components.IsNullOrEmpty();
        }

        public static bool TryGetComponentsInParent<T>(this Component self, out T[] components)
        {
            components = self.GetComponentsInParent<T>();
            return !components.IsNullOrEmpty();
        }
    }
}
