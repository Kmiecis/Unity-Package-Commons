using UnityEngine;

namespace Common.Extensions
{
    public static class ObjectExtensions
    {
        public static bool IsPrefab(this Object self)
        {
            return self is GameObject gameObject && gameObject.IsPrefab();
        }

        public static bool IsAsset(this Object self)
        {
            return (
                self is not GameObject &&
                self is not Component
            );
        }

        public static void Destroy(this Object self)
        {
            UObject.Destroy(self);
        }

        public static void Destroy(this Object self, float t)
        {
            Object.Destroy(self, t);
        }

        public static void DontDestroyOnLoad(this Object self)
        {
            Object.DontDestroyOnLoad(self);
        }
    }
}
