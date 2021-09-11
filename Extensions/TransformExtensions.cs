using UnityEngine;

namespace Common.Extensions
{
    public static class TransformExtensions
    {
        public static void DestroyChildren(this Transform transform)
        {
            int childCount = transform.childCount;
            for (int i = childCount - 1; i > -1; i--)
            {
                var child = transform.GetChild(i);
                ObjectUtility.DestroySafely(child.gameObject);
            }
        }
    }
}
