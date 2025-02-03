using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common.Extensions
{
    public static class Vector3IntExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int XY(this Vector3Int self)
        {
            Vector2Int r = Vector2Int.zero;
            r.x = self.x;
            r.y = self.y;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int XZ(this Vector3Int self)
        {
            Vector2Int r = Vector2Int.zero;
            r.x = self.x;
            r.y = self.z;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int YZ(this Vector3Int self)
        {
            Vector2Int r = Vector2Int.zero;
            r.x = self.y;
            r.y = self.z;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int XY_(this Vector3Int self, int z = 0)
        {
            self.z = z;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 XY_(this Vector3Int self, float z)
        {
            Vector3 r;
            r.x = self.x;
            r.y = self.y;
            r.z = z;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int X_Z(this Vector3Int self, int y = 0)
        {
            self.y = y;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 X_Z(this Vector3Int self, float y)
        {
            Vector3 r;
            r.x = self.x;
            r.y = y;
            r.z = self.z;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int _YZ(this Vector3Int self, int x = 0)
        {
            self.x = x;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 _YZ(this Vector3Int self, float x)
        {
            Vector3 r;
            r.x = x;
            r.y = self.y;
            r.z = self.z;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Add(this Vector3Int self, float f)
        {
            Vector3 r;
            r.x = self.x + f;
            r.y = self.y + f;
            r.z = self.z + f;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Add(this Vector3Int self, int i)
        {
            self.x += i;
            self.y += i;
            self.z += i;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Add(this Vector3Int self, Vector3 v)
        {
            v.x = self.x + v.x;
            v.y = self.y + v.y;
            v.z = self.z + v.z;
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Add(this Vector3Int self, Vector3Int v)
        {
            self.x += v.x;
            self.y += v.y;
            self.z += v.z;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Sub(this Vector3Int self, float f)
        {
            Vector3 r;
            r.x = self.x - f;
            r.y = self.y - f;
            r.z = self.z - f;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Sub(this Vector3Int self, int i)
        {
            self.x -= i;
            self.y -= i;
            self.z -= i;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Sub(this Vector3Int self, Vector3 v)
        {
            v.x = self.x - v.x;
            v.y = self.y - v.y;
            v.z = self.z - v.z;
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Sub(this Vector3Int self, Vector3Int v)
        {
            self.x -= v.x;
            self.y -= v.y;
            self.z -= v.z;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Mul(this Vector3Int self, float f)
        {
            Vector3 r;
            r.x = self.x * f;
            r.y = self.y * f;
            r.z = self.z * f;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Mul(this Vector3Int self, int i)
        {
            self.x *= i;
            self.y *= i;
            self.z *= i;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Mul(this Vector3Int self, Vector3 v)
        {
            v.x = self.x * v.x;
            v.y = self.y * v.y;
            v.z = self.z * v.z;
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Mul(this Vector3Int self, Vector3Int v)
        {
            self.x *= v.x;
            self.y *= v.y;
            self.z *= v.z;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Div(this Vector3Int self, float f)
        {
            Vector3 r;
            var e = 1 / f;
            r.x = self.x * e;
            r.y = self.y * e;
            r.z = self.z * e;
            return r;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Div(this Vector3Int self, int i)
        {
            self.x /= i;
            self.y /= i;
            self.z /= i;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Div(this Vector3Int self, Vector3 v)
        {
            v.x = self.x / v.x;
            v.y = self.y / v.y;
            v.z = self.z / v.z;
            return v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Div(this Vector3Int self, Vector3Int v)
        {
            self.x /= v.x;
            self.y /= v.y;
            self.z /= v.z;
            return self;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Normalized(this Vector3Int self)
        {
            Vector3 r;
            var e = 1 / self.magnitude;
            r.x = self.x * e;
            r.y = self.y * e;
            r.z = self.z * e;
            return r;
        }
    }
}
