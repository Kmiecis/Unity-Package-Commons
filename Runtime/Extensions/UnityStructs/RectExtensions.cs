using UnityEngine;

namespace Common.Extensions
{
    public static class RectExtensions
    {
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
