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

        public static void Remove<T>(ref T component)
            where T : Component
        {
            if (component != null)
            {
                Remove(component);
                component = null;
            }
        }

        public static void Destroy<T>(T component)
            where T : Component
        {
            UObject.Destroy(component.gameObject);
        }

        public static void Destroy<T>(ref T component)
            where T : Component
        {
            if (component != null)
            {
                Destroy(component);
                component = null;
            }
        }
    }
}