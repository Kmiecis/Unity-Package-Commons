using UnityEngine;

namespace Common.Extensions
{
    public static class ObjectExtensions
    {
        public static void Destroy(this Object self)
        {
            if (Application.isPlaying)
                Object.Destroy(self);
            else
                Object.DestroyImmediate(self);
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
