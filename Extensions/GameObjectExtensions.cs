using UnityEngine;

namespace Common.Extensions
{
    public static class GameObjectExtensions
    {
        public static bool IsPrefab(this GameObject self)
        {
            return self.scene.rootCount == 0;
        }

        public static T EnsureComponent<T>(this GameObject self)
            where T : Component
        {
            if (!self.TryGetComponent<T>(out T component))
                component = self.AddComponent<T>();
            return component;
        }
    }
}
