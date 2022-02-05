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
    }
}
