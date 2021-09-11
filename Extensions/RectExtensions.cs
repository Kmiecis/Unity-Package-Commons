using UnityEngine;

namespace Common.Extensions
{
    public static class RectExtensions
    {
        public static Rect CopyAndSet(this Rect rect, float x = default, float y = default, float width = default, float height = default)
        {
            var result = new Rect();
            result.x = x == default ? rect.x : x;
            result.y = y == default ? rect.y : y;
            result.width = width == default ? rect.width : width;
            result.height = height == default ? rect.height : height;
            return result;
        }
    }
}
