using UnityEngine;

namespace Common.Extensions
{
    public static class RectExtensions
    {
        public static Rect WithX(this Rect self, float x)
        {
            var result = self;
            result.x = x;
            return result;
        }

        public static Rect WithY(this Rect self, float y)
        {
            var result = self;
            result.y = y;
            return result;
        }

        public static Rect WithWidth(this Rect self, float width)
        {
            var result = self;
            result.width = width;
            return result;
        }

        public static Rect WithHeight(this Rect self, float height)
        {
            var result = self;
            result.height = height;
            return result;
        }
    }
}
