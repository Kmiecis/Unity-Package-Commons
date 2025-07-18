using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common
{
    public static class Vector2Extensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 X_(this Vector2 self, float y = 0.0f)
        {
            self.y = y;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 _Y(this Vector2 self, float x = 0.0f)
        {
            self.x = x;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 YX(this Vector2 self)
        {
            Vector2 r;
            r.x = self.y;
            r.y = self.x;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 X__(this Vector2 self, float y = 0.0f, float z = 0.0f)
        {
            Vector3 r;
            r.x = self.x;
            r.y = y;
            r.z = z;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 _X_(this Vector2 self, float x = 0.0f, float z = 0.0f)
        {
            Vector3 r;
            r.x = x;
            r.y = self.x;
            r.z = z;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 __X(this Vector2 self, float x = 0.0f, float y = 0.0f)
        {
            Vector3 r;
            r.x = x;
            r.y = y;
            r.z = self.x;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Y__(this Vector2 self, float y = 0.0f, float z = 0.0f)
        {
            Vector3 r;
            r.x = self.y;
            r.y = y;
            r.z = z;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 _Y_(this Vector2 self, float x = 0.0f, float z = 0.0f)
        {
            Vector3 r;
            r.x = x;
            r.y = self.y;
            r.z = z;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 __Y(this Vector2 self, float x = 0.0f, float y = 0.0f)
        {
            Vector3 r;
            r.x = x;
            r.y = y;
            r.z = self.y;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 XY_(this Vector2 self, float z = 0.0f)
        {
            Vector3 r;
            r.x = self.x;
            r.y = self.y;
            r.z = z;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 X_Y(this Vector2 self, float y = 0.0f)
        {
            Vector3 r;
            r.x = self.x;
            r.y = y;
            r.z = self.y;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 _XY(this Vector2 self, float x = 0.0f)
        {
            Vector3 r;
            r.x = x;
            r.y = self.x;
            r.z = self.y;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 YX_(this Vector2 self, float z = 0.0f)
        {
            Vector3 r;
            r.x = self.y;
            r.y = self.x;
            r.z = z;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Y_X(this Vector2 self, float y = 0.0f)
        {
            Vector3 r;
            r.x = self.y;
            r.y = y;
            r.z = self.x;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 _YX(this Vector2 self, float x = 0.0f)
        {
            Vector3 r;
            r.x = x;
            r.y = self.y;
            r.z = self.x;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Add(this Vector2 self, float f)
        {
            self.x += f;
            self.y += f;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Add(this Vector2 self, int i)
        {
            self.x += i;
            self.y += i;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Add(this Vector2 self, Vector2 v)
        {
            self.x += v.x;
            self.y += v.y;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Add(this Vector2 self, Vector2Int v)
        {
            self.x += v.x;
            self.y += v.y;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Sub(this Vector2 self, float f)
        {
            self.x -= f;
            self.y -= f;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Sub(this Vector2 self, int i)
        {
            self.x -= i;
            self.y -= i;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Sub(this Vector2 self, Vector2 v)
        {
            self.x -= v.x;
            self.y -= v.y;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Sub(this Vector2 self, Vector2Int v)
        {
            self.x -= v.x;
            self.y -= v.y;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Mul(this Vector2 self, float f)
        {
            self.x *= f;
            self.y *= f;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Mul(this Vector2 self, int i)
        {
            self.x *= i;
            self.y *= i;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Mul(this Vector2 self, Vector2 v)
        {
            self.x *= v.x;
            self.y *= v.y;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Mul(this Vector2 self, Vector2Int v)
        {
            self.x *= v.x;
            self.y *= v.y;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Div(this Vector2 self, float f)
        {
            var e = 1 / f;
            self.x *= e;
            self.y *= e;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Div(this Vector2 self, int i)
        {
            var e = 1.0f / i;
            self.x *= e;
            self.y *= e;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Div(this Vector2 self, Vector2 v)
        {
            self.x /= v.x;
            self.y /= v.y;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Div(this Vector2 self, Vector2Int v)
        {
            self.x /= v.x;
            self.y /= v.y;
            return self;
        }
    }
}
