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

        public static bool TryGetComponentInChildren<T>(this Component self, out T component, bool includeInactive = false)
        {
            component = self.GetComponentInChildren<T>(includeInactive);
            return component != null;
        }

        public static bool TryGetComponentInParent<T>(this Component self, out T component, bool includeInactive = false)
        {
            component = self.GetComponentInParent<T>(includeInactive);
            return component != null;
        }

        public static bool TryGetComponents<T>(this Component self, out T[] components)
        {
            components = self.GetComponents<T>();
            return !components.IsNullOrEmpty();
        }

        public static bool TryGetComponentsInChildren<T>(this Component self, out T[] components, bool includeInactive = false)
        {
            components = self.GetComponentsInChildren<T>(includeInactive);
            return !components.IsNullOrEmpty();
        }

        public static bool TryGetComponentsInParent<T>(this Component self, out T[] components, bool includeInactive = false)
        {
            components = self.GetComponentsInParent<T>(includeInactive);
            return !components.IsNullOrEmpty();
        }
    }
}
