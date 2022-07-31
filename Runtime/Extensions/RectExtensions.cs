using UnityEngine;

namespace Common.Extensions
{
    public static class RectExtensions
    {
        public static Rect CopyAndSet(this Rect self, float x = default, float y = default, float width = default, float height = default)
        {
            var result = new Rect();
            result.x = x == default ? self.x : x;
            result.y = y == default ? self.y : y;
            result.width = width == default ? self.width : width;
            result.height = height == default ? self.height : height;
            return result;
        }
    }
}
