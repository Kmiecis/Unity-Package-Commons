using Common.Mathematics;
using UnityEngine;

namespace Common.Extensions
{
    public static class RectExtensions
    {
        public static Vector2 GetOffset(this Rect self, Rect bounds)
        {
            var dmin = Mathx.Max(bounds.min - self.min, 0.0f);
            var dmax = Mathx.Max(self.max - bounds.max, 0.0f);
            return dmax - dmin;
        }

        public static Rect WithX(this Rect self, float x)
        {
            return new Rect(x, self.y, self.width, self.height);
        }

        public static Rect WithY(this Rect self, float y)
        {
            return new Rect(self.x, y, self.width, self.height);
        }

        public static Rect WithWidth(this Rect self, float width)
        {
            return new Rect(self.x, self.y, width, self.height);
        }

        public static Rect WithHeight(this Rect self, float height)
        {
            return new Rect(self.x, self.y, self.width, height);
        }
    }
}
