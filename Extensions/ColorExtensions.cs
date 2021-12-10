using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common.Extensions
{
    public static class ColorExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Color RGB_(this Color c, float a)
        {
            return new Color(c.r, c.g, c.b, a);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Color RG_A(this Color c, float b)
        {
            return new Color(c.r, c.g, b, c.a);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Color R_BA(this Color c, float g)
        {
            return new Color(c.r, g, c.b, c.a);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Color _GBA(this Color c, float r)
        {
            return new Color(r, c.g, c.b, c.a);
        }
    }
}
