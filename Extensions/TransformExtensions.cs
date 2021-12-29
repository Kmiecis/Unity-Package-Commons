using System.Collections.Generic;
using UnityEngine;

namespace Common.Extensions
{
    public static class TransformExtensions
    {
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

        /// <summary> Get enumerator going down in hierarchy, including self </summary>
        public static IEnumerable<Transform> GetDownwardEnumerator(this Transform self)
        {
            var queue = new Queue<Transform>();
            queue.Enqueue(self);

            while (queue.TryDequeue(out var item))
            {
                for (int i = 0; i < item.childCount; ++i)
                {
                    var child = item.GetChild(i);
                    queue.Enqueue(child);
                }

                yield return item;
            }
        }

        /// <summary> Get enumerator going up in hierarchy, including self </summary>
        public static IEnumerable<Transform> GetUpwardEnumerator(this Transform self)
        {
            for (var transform = self; transform != null; self = transform.parent)
            {
                yield return transform;
            }
        }

        /// <summary> Is this transform a parent of child? </summary>
        public static bool IsParentOf(this Transform self, Transform child)
        {
            return child.IsChildOf(self);
        }

        /// <summary> Is this transform related in any way to the other? </summary>
        public static bool IsRelatedTo(this Transform self, Transform other)
        {
            return (
                self.IsChildOf(other) ||
                other.IsChildOf(self)
            );
        }

        public static string GetHierarchyPath(this Transform self, char delimiter = '/')
        {
            var parent = self.parent;
            return (parent == null ? "" : GetHierarchyPath(parent, delimiter) + delimiter) + self.name;
        }
    }
}
