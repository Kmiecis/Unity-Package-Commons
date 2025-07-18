using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common
{
    public static class Vector4Extensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 XYZ(this Vector4 self)
        {
            Vector3 r;
            r.x = self.x;
            r.y = self.y;
            r.z = self.z;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 _YZW(this Vector4 self, float x = 0.0f)
        {
            Vector4 r;
            r.x = x;
            r.y = self.y;
            r.z = self.z;
            r.w = self.w;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 X_ZW(this Vector4 self, float y = 0.0f)
        {
            Vector4 r;
            r.x = self.x;
            r.y = y;
            r.z = self.z;
            r.w = self.w;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 XY_W(this Vector4 self, float z = 0.0f)
        {
            Vector4 r;
            r.x = self.x;
            r.y = self.y;
            r.z = z;
            r.w = self.w;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 XYZ_(this Vector4 self, float w = 0.0f)
        {
            Vector4 r;
            r.x = self.x;
            r.y = self.y;
            r.z = self.z;
            r.w = w;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Add(this Vector4 self, float f)
        {
            self.x += f;
            self.y += f;
            self.z += f;
            self.w += f;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Add(this Vector4 self, int i)
        {
            self.x += i;
            self.y += i;
            self.z += i;
            self.w += i;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Add(this Vector4 self, Vector4 v)
        {
            self.x += v.x;
            self.y += v.y;
            self.z += v.z;
            self.w += v.w;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Sub(this Vector4 self, float f)
        {
            self.x -= f;
            self.y -= f;
            self.z -= f;
            self.w -= f;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Sub(this Vector4 self, int i)
        {
            self.x -= i;
            self.y -= i;
            self.z -= i;
            self.w -= i;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Sub(this Vector4 self, Vector4 v)
        {
            self.x -= v.x;
            self.y -= v.y;
            self.z -= v.z;
            self.w -= v.w;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Mul(this Vector4 self, float f)
        {
            self.x *= f;
            self.y *= f;
            self.z *= f;
            self.w *= f;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Mul(this Vector4 self, int i)
        {
            self.x *= i;
            self.y *= i;
            self.z *= i;
            self.w *= i;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Mul(this Vector4 self, Vector4 v)
        {
            self.x *= v.x;
            self.y *= v.y;
            self.z *= v.z;
            self.w *= v.w;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Div(this Vector4 self, float f)
        {
            var e = 1 / f;
            self.x *= e;
            self.y *= e;
            self.z *= e;
            self.w *= e;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Div(this Vector4 self, int i)
        {
            var e = 1.0f / i;
            self.x *= e;
            self.y *= e;
            self.z *= e;
            self.w *= e;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 Div(this Vector4 self, Vector4 v)
        {
            self.x /= v.x;
            self.y /= v.y;
            self.z /= v.z;
            self.w /= v.w;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Color RGBA(this Vector4 self)
        {
            Color r;
            r.r = self.x;
            r.g = self.y;
            r.b = self.z;
            r.a = self.w;
            return r;
        }
    }
}
