using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common.Extensions
{
    public static class ColorExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 XYZ(this Color self)
            => new Vector3(self.r, self.g, self.b);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 XYZW(this Color self)
            => new Vector4(self.r, self.g, self.b, self.a);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Color RGB_(this Color self, float a = 1.0f)
            => new Color(self.r, self.g, self.b, a);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Color RG_A(this Color self, float b = 1.0f)
            => new Color(self.r, self.g, b, self.a);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Color R_BA(this Color self, float g = 1.0f)
            => new Color(self.r, g, self.b, self.a);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Color _GBA(this Color self, float r = 1.0f)
            => new Color(r, self.g, self.b, self.a);
    }
}