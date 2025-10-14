using System.Collections.Generic;
using UnityEngine;

namespace Common
{
    public static class RectTransformExtensions
    {
        private static readonly Vector3[] _WorldCorners = new Vector3[4];

        public static RectTransform GetRectRoot(this RectTransform self)
        {
            var root = self;
            while (root.parent is RectTransform parent)
            {
                root = parent;
            }
            return root;
        }

        public static Vector2 GetRealSize(this RectTransform self)
        {
            var anchorMin = self.anchorMin;
            var anchorMax = self.anchorMax;

            var size = self.rect.size;
            var sizeDelta = self.sizeDelta;

            if (!Mathf.Approximately(anchorMin.x, anchorMax.x))
                size.x -= sizeDelta.x;
            if (!Mathf.Approximately(anchorMin.y, anchorMax.y))
                size.y -= sizeDelta.y;

            return size;
        }

        public static Vector2 GetParentRealSize(this RectTransform self)
        {
            var parent = self.parent as RectTransform;
            if (parent != null) return parent.GetRealSize();
            return new Vector2(Screen.width, Screen.height);
        }

        public static Vector2 GetParentSize(this RectTransform self)
        {
            var parent = self.parent as RectTransform;
            if (parent != null) return parent.rect.size;
            return new Vector2(Screen.width, Screen.height);
        }

        public static Rect GetWorldRect(this RectTransform self)
        {
            self.GetWorldCorners(_WorldCorners);
            var position = _WorldCorners[0];
            var size = _WorldCorners[2] - position;
            return new Rect(position, size);
        }

        public static Vector2 GetWorldRectOffset(this RectTransform self, RectTransform other)
        {
            var selfRect = self.GetWorldRect();
            var otherRect = other.GetWorldRect();
            return otherRect.GetOffset(selfRect);
        }

        /// <summary> Get <see cref="RectTransform"/> enumerator enclosing a 'screenPoint', including self </summary>
        public static IEnumerable<RectTransform> GetEnclosersEnumerator(this RectTransform self, Vector2 screenPoint)
        {
            foreach (var rectTransform in self.GetDownwardEnumerator<RectTransform>())
            {
                if (rectTransform.ContainsScreenPoint(screenPoint))
                {
                    yield return rectTransform;
                }
            }
        }

        /// <summary> Get <see cref="{T}"/> enumerator enclosing a 'screenPoint', including self </summary>
        public static IEnumerable<T> GetEnclosersEnumerator<T>(this RectTransform self, Vector2 screenPoint)
        {
            foreach (var rectTransform in self.GetEnclosersEnumerator(screenPoint))
            {
                if (rectTransform.TryGetComponent<T>(out var component))
                {
                    yield return component;
                }
            }
        }

        public static Rect GetPixelRect(this RectTransform self, Canvas canvas)
        {
            return RectTransformUtility.PixelAdjustRect(self, canvas);
        }

        public static bool ContainsScreenPoint(this RectTransform self, Vector2 screenPoint)
        {
            return RectTransformUtility.RectangleContainsScreenPoint(self, screenPoint);
        }

        public static bool ContainsScreenPoint(this RectTransform self, Vector2 screenPoint, Camera camera)
        {
            return RectTransformUtility.RectangleContainsScreenPoint(self, screenPoint, camera);
        }

        public static bool ContainsScreenPoint(this RectTransform self, Vector2 screenPoint, Camera camera, Vector4 offset)
        {
            return RectTransformUtility.RectangleContainsScreenPoint(self, screenPoint, camera, offset);
        }

        public static bool TryGetWorldPointFromScreenPoint(this RectTransform self, Camera camera, Vector2 screenPoint, out Vector3 worldPoint)
        {
            return RectTransformUtility.ScreenPointToWorldPointInRectangle(self, screenPoint, camera, out worldPoint);
        }

        public static bool TryGetLocalPointFromScreenPoint(this RectTransform self, Camera camera, Vector2 screenPoint, out Vector2 localPoint)
        {
            return RectTransformUtility.ScreenPointToLocalPointInRectangle(self, screenPoint, camera, out localPoint);
        }

        public static void FlipLayoutOnAxis(this RectTransform self, int axis, bool keepPositioning, bool recursive)
        {
            RectTransformUtility.FlipLayoutOnAxis(self, axis, keepPositioning, recursive);
        }

        public static void FlipLayoutAxes(this RectTransform self, bool keepPositioning, bool recursive)
        {
            RectTransformUtility.FlipLayoutAxes(self, keepPositioning, recursive);
        }
    }
}
