using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Common.Extensions
{
    public static class TransformExtensions
    {
        public static void Reset(this Transform self)
        {
            self.localPosition = Vector3.zero;
            self.localRotation = Quaternion.identity;
            self.localScale = Vector3.one;
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

        /// <summary> Get <see cref="Transform"/> enumerator going down in hierarchy, including self </summary>
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

        /// <summary> Get <see cref="{T}"/> enumerator going down in hierarchy, including self </summary>
        public static IEnumerable<T> GetDownwardEnumerator<T>(this Transform self)
        {
            foreach (var transform in self.GetDownwardEnumerator())
            {
                if (transform.TryGetComponent<T>(out var component))
                {
                    yield return component;
                }
            }
        }

        /// <summary> Get <see cref="Transform"/> enumerator going up in hierarchy, including self </summary>
        public static IEnumerable<Transform> GetUpwardEnumerator(this Transform self)
        {
            for (var transform = self; transform != null; transform = transform.parent)
            {
                yield return transform;
            }
        }

        /// <summary> Get <see cref="{T}"/> enumerator going up in hierarchy, including self </summary>
        public static IEnumerable<T> GetUpwardEnumerator<T>(this Transform self)
        {
            foreach (var transform in self.GetUpwardEnumerator())
            {
                if (transform.TryGetComponent<T>(out var component))
                {
                    yield return component;
                }
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

        /// <summary> Calculates max transform depth </summary>
        public static int GetDepth(this Transform self, int depth = 0)
        {
            var result = depth;
            foreach (Transform child in self)
                result = Mathf.Max(result, child.GetDepth(depth + 1));
            return result;
        }

        /// <summary> Returns transform hierarchy path separated by delimiter </summary>
        public static string GetHierarchyPath(this Transform self, char delimiter = '/')
        {
            var builder = new StringBuilder();
            builder.Append(self.name);
            var parent = self.parent;
            while (parent != null)
                builder.Insert(0, delimiter).Insert(0, parent.name);
            return builder.ToString();
        }

        /// <summary> Safely handles destroying of all transform children </summary>
        public static void DestroyChildren(this Transform self)
        {
            var childCount = self.childCount;
            for (int i = childCount - 1; i > -1; --i)
            {
                var child = self.GetChild(i);
                child.gameObject.Destroy();
            }
        }

        /// <summary> Safely handles destroying transform child at given index </summary>
        public static void DestroyChild(this Transform self, int index)
        {
            if (-1 < index && index < self.childCount)
            {
                var child = self.GetChild(index);
                child.gameObject.Destroy();
            }
        }

        /// <summary> Returns a transform child component by index </summary>
        public static T GetChild<T>(this Transform self, int index)
        {
            var child = self.GetChild(index);
            return child.GetComponent<T>();
        }

        /// <summary> Returns a transform first child </summary>
        public static Transform GetFirstChild(this Transform self)
        {
            return self.GetChild(0);
        }

        /// <summary> Returns a transform first child component </summary>
        public static T GetFirstChild<T>(this Transform self)
        {
            var child = self.GetFirstChild();
            return child.GetComponent<T>();
        }

        /// <summary> Returns a transform last child </summary>
        public static Transform GetLastChild(this Transform self)
        {
            return self.GetChild(self.childCount - 1);
        }

        /// <summary> Returns a transform last child component </summary>
        public static T GetLastChild<T>(this Transform self)
        {
            var child = self.GetLastChild();
            return child.GetComponent<T>();
        }

        /// <summary> Attempts retrieving transform child at given index </summary>
        public static bool TryGetChild(this Transform self, int index, out Transform child)
        {
            child = default;
            if (-1 < index && index < self.childCount)
            {
                child = self.GetChild(index);
                return true;
            }
            return false;
        }

        /// <summary> Attempts retrieving transform child component at given index </summary>
        public static bool TryGetChild<T>(this Transform self, int index, out T component)
        {
            component = default;
            return (
                self.TryGetChild(index, out var child) &&
                child.TryGetComponent(out component)
            );
        }

        /// <summary> Attempts retrieving transform first child </summary>
        public static bool TryGetFirstChild(this Transform self, out Transform child)
        {
            return self.TryGetChild(0, out child);
        }

        /// <summary> Attempts retrieving transform first child component </summary>
        public static bool TryGetFirstChild<T>(this Transform self, out T component)
        {
            component = default;
            return (
                self.TryGetFirstChild(out var child) &&
                child.TryGetComponent(out component)
            );
        }

        /// <summary> Attempts retrieving transform last child </summary>
        public static bool TryGetLastChild(this Transform self, out Transform child)
        {
            return self.TryGetChild(self.childCount - 1, out child);
        }

        /// <summary> Attempts retrieving transform last child component </summary>
        public static bool TryGetLastChild<T>(this Transform self, out T component)
        {
            component = default;
            return (
                self.TryGetLastChild(out var child) &&
                child.TryGetComponent(out component)
            );
        }
    }
}
