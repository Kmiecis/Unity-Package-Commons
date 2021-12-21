using UnityEngine;

namespace Common.Extensions
{
    public static class TransformExtensions
    {
        public static void DestroyChildren(this Transform self)
        {
            int childCount = self.childCount;
            for (int i = childCount - 1; i > -1; i--)
            {
                var child = self.GetChild(i);
                child.Destroy();
            }
        }
    }
}
