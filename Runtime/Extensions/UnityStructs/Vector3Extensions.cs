using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common.Extensions
{
    public static class Vector3Extensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 XY(this Vector3 self)
        {
            Vector2 r;
            r.x = self.x;
            r.y = self.y;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 XZ(this Vector3 self)
        {
            Vector2 r;
            r.x = self.x;
            r.y = self.z;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 YZ(this Vector3 self)
        {
            Vector2 r;
            r.x = self.y;
            r.y = self.z;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 X__(this Vector3 self, float y = 0.0f, float z = 0.0f)
        {
            self.y = y;
            self.z = z;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 _X_(this Vector3 self, float x = 0.0f, float z = 0.0f)
        {
            self.y = self.x;
            self.x = x;
            self.z = z;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 __X(this Vector3 self, float x = 0.0f, float y = 0.0f)
        {
            self.z = self.x;
            self.x = x;
            self.y = y;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Y__(this Vector3 self, float y = 0.0f, float z = 0.0f)
        {
            self.x = self.y;
            self.y = y;
            self.z = z;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 _Y_(this Vector3 self, float x = 0.0f, float z = 0.0f)
        {
            self.x = x;
            self.z = z;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 __Y(this Vector3 self, float x = 0.0f, float y = 0.0f)
        {
            self.z = self.y;
            self.x = x;
            self.y = y;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Z__(this Vector3 self, float y = 0.0f, float z = 0.0f)
        {
            self.x = self.z;
            self.y = y;
            self.z = z;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 _Z_(this Vector3 self, float x = 0.0f, float z = 0.0f)
        {
            self.y = self.z;
            self.x = x;
            self.z = z;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 __Z(this Vector3 self, float x = 0.0f, float y = 0.0f)
        {
            self.x = x;
            self.y = y;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 XY_(this Vector3 self, float z = 0.0f)
        {
            self.z = z;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 X_Z(this Vector3 self, float y = 0.0f)
        {
            self.y = y;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 _YZ(this Vector3 self, float x = 0.0f)
        {
            self.x = x;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 XZY(this Vector3 self)
        {
            Vector3 r;
            r.x = self.x;
            r.y = self.z;
            r.z = self.y;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 YXZ(this Vector3 self)
        {
            Vector3 r;
            r.x = self.y;
            r.y = self.x;
            r.z = self.z;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 YZX(this Vector3 self)
        {
            Vector3 r;
            r.x = self.y;
            r.y = self.z;
            r.z = self.x;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 ZXY(this Vector3 self)
        {
            Vector3 r;
            r.x = self.z;
            r.y = self.x;
            r.z = self.y;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 ZYX(this Vector3 self)
        {
            Vector3 r;
            r.x = self.z;
            r.y = self.y;
            r.z = self.x;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector4 XYZ_(this Vector3 self, float w = 0.0f)
        {
            Vector4 r;
            r.x = self.z;
            r.y = self.y;
            r.z = self.x;
            r.w = w;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Add(this Vector3 self, float f)
        {
            self.x += f;
            self.y += f;
            self.z += f;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Add(this Vector3 self, int i)
        {
            self.x += i;
            self.y += i;
            self.z += i;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Add(this Vector3 self, Vector3 v)
        {
            self.x += v.x;
            self.y += v.y;
            self.z += v.z;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Add(this Vector3 self, Vector3Int v)
        {
            self.x += v.x;
            self.y += v.y;
            self.z += v.z;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Sub(this Vector3 self, float f)
        {
            self.x -= f;
            self.y -= f;
            self.z -= f;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Sub(this Vector3 self, int i)
        {
            self.x -= i;
            self.y -= i;
            self.z -= i;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Sub(this Vector3 self, Vector3 v)
        {
            self.x -= v.x;
            self.y -= v.y;
            self.z -= v.z;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Sub(this Vector3 self, Vector3Int v)
        {
            self.x -= v.x;
            self.y -= v.y;
            self.z -= v.z;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Mul(this Vector3 self, float f)
        {
            self.x *= f;
            self.y *= f;
            self.z *= f;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Mul(this Vector3 self, int i)
        {
            self.x *= i;
            self.y *= i;
            self.z *= i;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Mul(this Vector3 self, Vector3 v)
        {
            self.x *= v.x;
            self.y *= v.y;
            self.z *= v.z;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Mul(this Vector3 self, Vector3Int v)
        {
            self.x *= v.x;
            self.y *= v.y;
            self.z *= v.z;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Div(this Vector3 self, float f)
        {
            var e = 1 / f;
            self.x *= e;
            self.y *= e;
            self.z *= e;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Div(this Vector3 self, int i)
        {
            var e = 1.0f / i;
            self.x *= e;
            self.y *= e;
            self.z *= e;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Div(this Vector3 self, Vector3 v)
        {
            self.x /= v.x;
            self.y /= v.y;
            self.z /= v.z;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Div(this Vector3 self, Vector3Int v)
        {
            self.x /= v.x;
            self.y /= v.y;
            self.z /= v.z;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Color RGB(this Vector3 self)
        {
            Color r;
            r.r = self.x;
            r.g = self.y;
            r.b = self.z;
            r.a = 0.0f;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Color RGBA(this Vector3 self, float a = 1.0f)
        {
            Color r;
            r.r = self.x;
            r.g = self.y;
            r.b = self.z;
            r.a = a;
            return r;
        }
    }
}
