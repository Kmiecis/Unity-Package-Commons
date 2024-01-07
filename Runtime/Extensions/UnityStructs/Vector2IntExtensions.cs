using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common.Extensions
{
    public static class Vector2IntExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int XY_(this Vector2Int self, int i = 0)
        {
            return new Vector3Int(self.x, self.y, i);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int X_Y(this Vector2Int self, int i = 0)
        {
            return new Vector3Int(self.x, i, self.y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int _XY(this Vector2Int self, int i = 0)
        {
            return new Vector3Int(i, self.x, self.y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int YX_(this Vector2Int self, int i = 0)
        {
            return new Vector3Int(self.y, self.x, i);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Y_X(this Vector2Int self, int i = 0)
        {
            return new Vector3Int(self.y, i, self.x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int _YX(this Vector2Int self, int i = 0)
        {
            return new Vector3Int(i, self.y, self.x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int YX(this Vector2Int self)
        {
            return new Vector2Int(self.y, self.x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int WithX(this Vector2Int self, int x)
        {
            return new Vector2Int(x, self.y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int WithY(this Vector2Int self, int y)
        {
            return new Vector2Int(self.x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 Normalized(this Vector2Int self)
        {
            var l = self.magnitude;
            return new Vector2(self.x / l, self.y / l);
        }
    }
}
