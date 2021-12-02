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
            {
                Object.Destroy(component);
            }
        }
    }
}
