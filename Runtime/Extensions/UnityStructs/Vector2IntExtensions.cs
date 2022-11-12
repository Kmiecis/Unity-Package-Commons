using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common.Extensions
{
    public static class Vector2IntExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int XY_(this Vector2Int v, int i = 0)
        {
            return new Vector3Int(v.x, v.y, i);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int X_Y(this Vector2Int v, int i = 0)
        {
            return new Vector3Int(v.x, i, v.y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int _XY(this Vector2Int v, int i = 0)
        {
            return new Vector3Int(i, v.x, v.y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int YX_(this Vector2Int v, int i = 0)
        {
            return new Vector3Int(v.y, v.x, i);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int Y_X(this Vector2Int v, int i = 0)
        {
            return new Vector3Int(v.y, i, v.x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3Int _YX(this Vector2Int v, int i = 0)
        {
            return new Vector3Int(i, v.y, v.x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int YX(this Vector2Int v)
        {
            return new Vector2Int(v.y, v.x);
        }
    }
}
