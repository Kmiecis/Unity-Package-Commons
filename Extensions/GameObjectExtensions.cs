using UnityEngine;

namespace Common.Extensions
{
    public static class GameObjectExtensions
    {
        public static bool IsPrefab(this GameObject self)
        {
            return self.scene.rootCount == 0;
        }

        public static bool HasComponent<T>(this GameObject self)
        {
            return self.GetComponent<T>() != null;
        }

        public static void RemoveComponent<T>(this GameObject self)
            where T : Component
        {
            if (self.TryGetComponent<T>(out var component))
                Object.Destroy(component);
        }

        public static T EnsureComponent<T>(this GameObject self)
            where T : Component
        {
            if (!self.TryGetComponent<T>(out T component))
                component = self.AddComponent<T>();
            return component;
        }

        public static bool TryGetComponentInChildren<T>(this GameObject self, out T component)
        {
            component = self.GetComponentInChildren<T>();
            return component != null;
        }

        public static bool TryGetComponentInParent<T>(this GameObject self, out T component)
        {
            component = self.GetComponentInParent<T>();
            return component != null;
        }

        public static bool TryGetComponents<T>(this GameObject self, out T[] components)
        {
            components = self.GetComponents<T>();
            return !components.IsNullOrEmpty();
        }

        public static bool TryGetComponentsInChildren<T>(this GameObject self, out T[] components)
        {
            components = self.GetComponentsInChildren<T>();
            return !components.IsNullOrEmpty();
        }

        public static bool TryGetComponentsInParent<T>(this GameObject self, out T[] components)
        {
            components = self.GetComponentsInParent<T>();
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
