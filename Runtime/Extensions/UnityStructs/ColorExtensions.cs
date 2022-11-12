using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common.Extensions
{
    public static class ColorExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Color WithAlpha(this Color c, float a)
        {
            return new Color(c.r, c.g, c.b, a);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Color WithBlue(this Color c, float b)
        {
            return new Color(c.r, c.g, b, c.a);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Color WithGreen(this Color c, float g)
        {
            return new Color(c.r, g, c.b, c.a);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Color WithRed(this Color c, float r)
        {
            return new Color(r, c.g, c.b, c.a);
        }
    }
}
