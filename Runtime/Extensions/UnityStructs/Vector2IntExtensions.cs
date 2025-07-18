using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common
{
    public static class Vector2IntExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int XY_(this Vector2Int self, int i = 0)
        {
            Vector3Int r = Vector3Int.zero;
            r.x = self.x;
            r.y = self.y;
            r.z = i;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 XY_(this Vector2Int self, float f)
        {
            Vector3 r;
            r.x = self.x;
            r.y = self.y;
            r.z = f;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int X_Y(this Vector2Int self, int i = 0)
        {
            Vector3Int r = Vector3Int.zero;
            r.x = self.x;
            r.y = i;
            r.z = self.y;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 X_Y(this Vector2Int self, float f)
        {
            Vector3 r;
            r.x = self.x;
            r.y = f;
            r.z = self.y;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int _XY(this Vector2Int self, int i = 0)
        {
            Vector3Int r = Vector3Int.zero;
            r.x = i;
            r.y = self.x;
            r.z = self.y;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 _XY(this Vector2Int self, float f)
        {
            Vector3 r;
            r.x = f;
            r.y = self.x;
            r.z = self.y;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int YX_(this Vector2Int self, int i = 0)
        {
            Vector3Int r = Vector3Int.zero;
            r.x = self.y;
            r.y = self.x;
            r.z = i;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 YX_(this Vector2Int self, float f)
        {
            Vector3 r;
            r.x = self.y;
            r.y = self.x;
            r.z = f;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Y_X(this Vector2Int self, int i = 0)
        {
            Vector3Int r = Vector3Int.zero;
            r.x = self.y;
            r.y = i;
            r.z = self.x;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Y_X(this Vector2Int self, float f)
        {
            Vector3 r;
            r.x = self.y;
            r.y = f;
            r.z = self.x;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int _YX(this Vector2Int self, int i = 0)
        {
            Vector3Int r = Vector3Int.zero;
            r.x = i;
            r.y = self.y;
            r.z = self.x;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 _YX(this Vector2Int self, float f)
        {
            Vector3 r;
            r.x = f;
            r.y = self.y;
            r.z = self.x;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int YX(this Vector2Int self)
        {
            Vector2Int r = Vector2Int.zero;
            r.x = self.y;
            r.y = self.x;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int X_(this Vector2Int self, int y = 0)
        {
            self.y = y;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 X_(this Vector2Int self, float y)
        {
            Vector2 r;
            r.x = self.x;
            r.y = y;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int _Y(this Vector2Int self, int x = 0)
        {
            self.x = x;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 _Y(this Vector2Int self, float x)
        {
            Vector2 r;
            r.x = x;
            r.y = self.y;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Add(this Vector2Int self, float f)
        {
            Vector2 r;
            r.x = self.x + f;
            r.y = self.y + f;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Add(this Vector2Int self, int i)
        {
            self.x += i;
            self.y += i;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Add(this Vector2Int self, Vector2 v)
        {
            v.x = self.x + v.x;
            v.y = self.y + v.y;
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Add(this Vector2Int self, Vector2Int v)
        {
            self.x += v.x;
            self.y += v.y;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Sub(this Vector2Int self, float f)
        {
            Vector2 r;
            r.x = self.x - f;
            r.y = self.y - f;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Sub(this Vector2Int self, int i)
        {
            self.x -= i;
            self.y -= i;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Sub(this Vector2Int self, Vector2 v)
        {
            v.x = self.x - v.x;
            v.y = self.y - v.y;
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Sub(this Vector2Int self, Vector2Int v)
        {
            self.x -= v.x;
            self.y -= v.y;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Mul(this Vector2Int self, float f)
        {
            Vector2 r;
            r.x = self.x * f;
            r.y = self.y * f;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Mul(this Vector2Int self, int i)
        {
            self.x *= i;
            self.y *= i;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Mul(this Vector2Int self, Vector2 v)
        {
            v.x = self.x * v.x;
            v.y = self.y * v.y;
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Mul(this Vector2Int self, Vector2Int v)
        {
            self.x *= v.x;
            self.y *= v.y;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Div(this Vector2Int self, float f)
        {
            Vector2 r;
            var e = 1 / f;
            r.x = self.x * e;
            r.y = self.y * e;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Div(this Vector2Int self, int i)
        {
            self.x /= i;
            self.y /= i;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Div(this Vector2Int self, Vector2 v)
        {
            v.x = self.x / v.x;
            v.y = self.y / v.y;
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Div(this Vector2Int self, Vector2Int v)
        {
            self.x /= v.x;
            self.y /= v.y;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Normalized(this Vector2Int self)
        {
            Vector2 r;
            var e = 1 / self.magnitude;
            r.x = self.x * e;
            r.y = self.y * e;
            return r;
        }
    }
}
