using System.Runtime.CompilerServices;
using UnityEngine;

namespace Common.Extensions
{
    public static class Vector2Extensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 XY_(this Vector2 v, float f = 0.0f)
        {
            return new Vector3(v.x, v.y, f);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 X_Y(this Vector2 v, float f = 0.0f)
        {
            return new Vector3(v.x, f, v.y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 _XY(this Vector2 v, float f = 0.0f)
        {
            return new Vector3(f, v.x, v.y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 YX_(this Vector2 v, float f = 0.0f)
        {
            return new Vector3(v.y, v.x, f);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 Y_X(this Vector2 v, float f = 0.0f)
        {
            return new Vector3(v.y, f, v.x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 _YX(this Vector2 v, float f = 0.0f)
        {
            return new Vector3(f, v.y, v.x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 YX(this Vector2 v)
        {
            return new Vector2(v.y, v.x);
        }
    }
}
