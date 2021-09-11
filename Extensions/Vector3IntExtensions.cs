using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common.Extensions
{
    public static class Vector3IntExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int XY(this Vector3Int v)
        {
            return new Vector2Int(v.x, v.y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int XZ(this Vector3Int v)
        {
            return new Vector2Int(v.x, v.z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int YZ(this Vector3Int v)
        {
            return new Vector2Int(v.y, v.z);
        }
    }
}
