using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common.Extensions
{
    public static class ColorExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string Hex(this Color self)
        {
            var r = (byte)Mathf.RoundToInt(self.r * 255.0f);
            var g = (byte)Mathf.RoundToInt(self.g * 255.0f);
            var b = (byte)Mathf.RoundToInt(self.b * 255.0f);
            return string.Format("{0:X2}{1:X2}{2:X2}", r, g, b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 XYZ(this Color self)
        {
            Vector3 r;
            r.x = self.r;
            r.y = self.g;
            r.z = self.b;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 XYZW(this Color self)
        {
            Vector4 r;
            r.x = self.r;
            r.y = self.g;
            r.z = self.b;
            r.w = self.a;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Color RGB_(this Color self, float a = 1.0f)
        {
            self.a = a;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Color RG_A(this Color self, float b = 1.0f)
        {
            self.b = b;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Color R_BA(this Color self, float g = 1.0f)
        {
            self.g = g;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Color _GBA(this Color self, float r = 1.0f)
        {
            self.r = r;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Color Add(this Color self, float f)
        {
            self.r += f;
            self.g += f;
            self.b += f;
            self.a += f;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Color Add(this Color self, Color c)
        {
            self.r += c.r;
            self.g += c.g;
            self.b += c.b;
            self.a += c.a;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Color Sub(this Color self, float f)
        {
            self.r -= f;
            self.g -= f;
            self.b -= f;
            self.a -= f;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Color Sub(this Color self, Color c)
        {
            self.r -= c.r;
            self.g -= c.g;
            self.b -= c.b;
            self.a -= c.a;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Color Mul(this Color self, float f)
        {
            self.r *= f;
            self.g *= f;
            self.b *= f;
            self.a *= f;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Color Mul(this Color self, Color c)
        {
            self.r *= c.r;
            self.g *= c.g;
            self.b *= c.b;
            self.a *= c.a;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Color Div(this Color self, float f)
        {
            var e = 1 / f;
            self.r *= e;
            self.g *= e;
            self.b *= e;
            self.a *= e;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Color Div(this Color self, Color c)
        {
            self.r /= c.r;
            self.g /= c.g;
            self.b /= c.b;
            self.a /= c.a;
            return self;
        }
    }
}