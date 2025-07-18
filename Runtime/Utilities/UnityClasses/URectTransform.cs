using System.Collections.Generic;
using UnityEngine;

namespace Common
{
    public static class URectTransform
    {
        public static IEnumerable<RectTransform> RectanglesContainingScreenPoint(RectTransform parent, Vector2 screenPoint)
        {
            foreach (var child in parent.GetDownwardEnumerator())
            {
                if (child is RectTransform childRect &&
                    RectTransformUtility.RectangleContainsScreenPoint(childRect, screenPoint))
                {
                    yield return childRect;
                }
            }
        }
    }
}