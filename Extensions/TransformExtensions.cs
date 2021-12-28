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

        public static Vector3 TransformDirectionTo(this Transform self, Vector3 position, Transform target)
        {
            if (self != null)
                position = self.TransformDirection(position);
            if (target != null)
                position = target.InverseTransformDirection(position);
            return position;
        }

        public static Vector3 TransformPointTo(this Transform self, Vector3 position, Transform target)
        {
            if (self != null)
                position = self.TransformPoint(position);
            if (target != null)
                position = target.InverseTransformPoint(position);
            return position;
        }

        public static Vector3 TransformVectorTo(this Transform self, Vector3 position, Transform target)
        {
            if (self != null)
                position = self.TransformVector(position);
            if (target != null)
                position = target.InverseTransformVector(position);
            return position;
        }
    }
}
