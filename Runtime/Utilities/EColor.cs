using UnityEngine;

namespace Common
{
    public enum EColor
    {
        Red,
        Green,
        Blue,
        White,
        Black,
        Yellow,
        Magenta,
        Cyan,
        Grey,
        Clear
    }

    public static class EColorExtensions
    {
        public static Color ToColor(this EColor self)
        {
            switch (self)
            {
                case EColor.Red: return Color.red;
                case EColor.Green: return Color.green;
                case EColor.Blue: return Color.blue;
                case EColor.White: return Color.white;
                case EColor.Black: return Color.black;
                case EColor.Yellow: return Color.yellow;
                case EColor.Magenta: return Color.magenta;
                case EColor.Cyan: return Color.cyan;
                case EColor.Grey: return Color.grey;
            }
            return Color.clear;
        }
    }
}