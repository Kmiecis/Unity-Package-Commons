using UnityEngine;

namespace Common
{
    public static class UScreen
    {
        public static Vector2Int Size
        {
            get => new Vector2Int(Screen.width, Screen.height);
        }
    }
}