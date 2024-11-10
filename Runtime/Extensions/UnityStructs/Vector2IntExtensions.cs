using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common.Extensions
{
    public static class Vector2IntExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int XY_(this Vector2Int self, int i = 0)
            => new Vector3Int(self.x, self.y, i);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int X_Y(this Vector2Int self, int i = 0)
            => new Vector3Int(self.x, i, self.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int _XY(this Vector2Int self, int i = 0)
            => new Vector3Int(i, self.x, self.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int YX_(this Vector2Int self, int i = 0)
            => new Vector3Int(self.y, self.x, i);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Y_X(this Vector2Int self, int i = 0)
            => new Vector3Int(self.y, i, self.x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int _YX(this Vector2Int self, int i = 0)
            => new Vector3Int(i, self.y, self.x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int YX(this Vector2Int self)
            => new Vector2Int(self.y, self.x);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int _Y(this Vector2Int self, int x = 0)
            => new Vector2Int(x, self.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int X_(this Vector2Int self, int y = 0)
            => new Vector2Int(self.x, y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Add(this Vector2Int self, float f)
            => new Vector2(self.x + f, self.y + f);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Add(this Vector2Int self, int i)
            => new Vector2Int(self.x + i, self.y + i);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Sub(this Vector2Int self, float f)
            => new Vector2(self.x - f, self.y - f);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Sub(this Vector2Int self, int i)
            => new Vector2Int(self.x - i, self.y - i);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Div(this Vector2Int self, Vector2 v)
            => new Vector2(self.x / v.x, self.y / v.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int Div(this Vector2Int self, Vector2Int v)
            => new Vector2Int(self.x / v.x, self.y / v.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Normalized(this Vector2Int self)
        {
            var l = self.magnitude;
            return new Vector2(self.x / l, self.y / l);
        }
    }
}
