using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common.Extensions
{
    public static class Color32Extensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Color32 WithR(this Color32 self, byte r)
        {
            return new Color32(r, self.g, self.b, self.a);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Color32 WithG(this Color32 self, byte g)
        {
            return new Color32(self.r, g, self.b, self.a);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Color32 WithB(this Color32 self, byte b)
        {
            return new Color32(self.r, self.g, b, self.a);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Color32 WithA(this Color32 self, byte a)
        {
            return new Color32(self.r, self.g, self.b, a);
        }
    }
}
