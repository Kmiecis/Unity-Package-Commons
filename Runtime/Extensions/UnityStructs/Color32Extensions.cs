using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common
{
    public static class Color32Extensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Color32 _GBA(this Color32 self, byte r = byte.MaxValue)
            => new Color32(r, self.g, self.b, self.a);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Color32 R_BA(this Color32 self, byte g = byte.MaxValue)
            => new Color32(self.r, g, self.b, self.a);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Color32 RG_A(this Color32 self, byte b = byte.MaxValue)
            => new Color32(self.r, self.g, b, self.a);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Color32 RGB_(this Color32 self, byte a = byte.MaxValue)
            => new Color32(self.r, self.g, self.b, a);
    }
}
