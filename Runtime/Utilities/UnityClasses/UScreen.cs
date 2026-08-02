using UnityEngine;

namespace Common
{
    public static class UScreen
    {
        public static Vector2Int Size
        {
            get => new Vector2Int(Screen.width, Screen.height);
        }

        public static Rect Rect
        {
            get => new Rect(0.0f, 0.0f, Screen.width, Screen.height);
        }

        public static Rect GetSquare()
        {
            var width = Screen.width;
            var height = Screen.height;
            var size = Mathf.Min(width, height);
            var left = (width - size) * 0.5f;
            var bottom = (height - size) * 0.5f;
            return new Rect(left, bottom, size, size);
        }
    }
}