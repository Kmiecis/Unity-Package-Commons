using UnityEngine;

namespace Common
{
    public static class UComponent
    {
        public static void Remove<T>(T component)
            where T : Component
        {
            UObject.Destroy(component);
        }

        public static void Destroy<T>(T component)
            where T : Component
        {
            UObject.Destroy(component.gameObject);
        }
    }
}