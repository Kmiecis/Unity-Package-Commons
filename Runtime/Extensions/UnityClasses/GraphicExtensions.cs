using UnityEngine.UI;

namespace Common.Extensions
{
    public static class GraphicExtensions
    {
        public static float GetAlpha(this Graphic self)
        {
            return self.color.a;
        }

        public static void SetAlpha(this Graphic self, float value)
        {
            self.color = self.color.RGB_(value);
        }
    }
}