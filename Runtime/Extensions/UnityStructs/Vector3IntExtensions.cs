using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common.Extensions
{
    public static class Vector3IntExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int XY(this Vector3Int self)
            => new Vector2Int(self.x, self.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int XZ(this Vector3Int self)
            => new Vector2Int(self.x, self.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int YZ(this Vector3Int self)
            => new Vector2Int(self.y, self.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int _YZ(this Vector3Int self, int x)
            => new Vector3Int(x, self.y, self.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int X_Z(this Vector3Int self, int y)
            => new Vector3Int(self.x, y, self.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int XY_(this Vector3Int self, int z)
            => new Vector3Int(self.x, self.y, z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Add(this Vector3Int self, float f)
            => new Vector3(self.x + f, self.y + f, self.z + f);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Add(this Vector3Int self, int i)
            => new Vector3Int(self.x + i, self.y + i, self.z + i);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Sub(this Vector3Int self, float f)
            => new Vector3(self.x - f, self.y - f, self.z - f);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Sub(this Vector3Int self, int i)
            => new Vector3Int(self.x - i, self.y - i, self.z - i);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Mul(this Vector3Int self, Vector3 v)
            => new Vector3(self.x * v.x, self.y * v.y, self.z * v.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Div(this Vector3Int self, Vector3 v)
            => new Vector3(self.x / v.x, self.y / v.y, self.z / v.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Div(this Vector3Int self, Vector3Int v)
            => new Vector3Int(self.x / v.x, self.y / v.y, self.z / v.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Normalized(this Vector3Int self)
        {
            var l = self.magnitude;
            return new Vector3(self.x / l, self.y / l, self.z / l);
        }
    }
}
