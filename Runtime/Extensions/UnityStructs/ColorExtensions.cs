using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common.Extensions
{
    public static class ColorExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 XYZ(this Color self)
        {
            return new Vector3(self.r, self.g, self.b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 XYZW(this Color self)
        {
            return new Vector4(self.r, self.g, self.b, self.a);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Color WithR(this Color self, float r)
        {
            return new Color(r, self.g, self.b, self.a);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Color WithG(this Color self, float g)
        {
            return new Color(self.r, g, self.b, self.a);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Color WithB(this Color self, float b)
        {
            return new Color(self.r, self.g, b, self.a);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Color WithA(this Color self, float a)
        {
            return new Color(self.r, self.g, self.b, a);
        }
    }
}
