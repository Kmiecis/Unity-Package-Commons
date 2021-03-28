using UnityEngine;

namespace Common
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
            var component = self.GetComponent<T>();
            if (component != null)
                Object.Destroy(component);
        }
    }
}