using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common
{
    public static class Vector2Extensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 X_Y(this Vector2 v)
        {
            return new Vector3(v.x, 0.0f, v.y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 XY_(this Vector2 v)
        {
            return new Vector3(v.x, v.y, 0.0f);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 _XY(this Vector2 v)
        {
            return new Vector3(0.0f, v.x, v.y);
        }
    }
}