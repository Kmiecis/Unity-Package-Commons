using System.Collections.Generic;
using UnityEngine;

namespace Common.Extensions
{
    public static class RectTransformExtensions
    {
        public static Vector2 GetVisibleSize(this RectTransform self)
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

        /// <summary> Get <see cref="RectTransform"/> enumerator enclosing a 'screenPoint', including self </summary>
        public static IEnumerable<RectTransform> GetEnclosersEnumerator(this RectTransform self, Vector2 screenPoint)
        {
            foreach (var rectTransform in self.GetDownwardEnumerator<RectTransform>())
            {
                if (RectTransformUtility.RectangleContainsScreenPoint(rectTransform, screenPoint))
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
    }
}
