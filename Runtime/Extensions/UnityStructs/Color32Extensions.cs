using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common
{
    public static class Color32Extensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ToHex(this Color32 self)
        {
            return $"#{self.r:X2}{self.g:X2}{self.b:X2}";
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Color32 _GBA(this Color32 self, byte r = byte.MaxValue)
        {
            self.r = r;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Color32 R_BA(this Color32 self, byte g = byte.MaxValue)
        {
            self.g = g;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Color32 RG_A(this Color32 self, byte b = byte.MaxValue)
        {
            self.b = b;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Color32 RGB_(this Color32 self, byte a = byte.MaxValue)
        {
            self.a = a;
            return self;
        }
    }
}
