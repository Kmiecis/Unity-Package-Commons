using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common.Extensions
{
    public static class Color32Extensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Color32 WithR(this Color32 c, byte r)
        {
            return new Color32(r, c.g, c.b, c.a);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Color32 WithG(this Color32 c, byte g)
        {
            return new Color32(c.r, g, c.b, c.a);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Color32 WithB(this Color32 c, byte b)
        {
            return new Color32(c.r, c.g, b, c.a);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Color32 WithA(this Color32 c, byte a)
        {
            return new Color32(c.r, c.g, c.b, a);
        }
    }
}
